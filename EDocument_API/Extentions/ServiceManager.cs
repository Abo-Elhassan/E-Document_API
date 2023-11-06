using EDocument_API.Extentions;
using EDocument_Services.File_Service;
using EDocument_Data.Consts;
using EDocument_Data.Models;
using EDocument_Data.Models.Shared;
using EDocument_EF;
using EDocument_Reposatories.Generic_Reposatories;
using EDocument_Repositories.Application_Repositories.Request_Reviewer_Repository;
using EDocument_Services.Auth_Service;
using EDocument_Services.AutoMapper_Service;
using EDocument_Services.Mail_Service;
using EDocument_UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Net;
using System.Reflection;
using System.Threading.RateLimiting;
using EDocument_Repositories.Application_Repositories.UserRepository;

namespace EDocument_API.Extentions
{
    public static class ServiceManager
    {
        public static IServiceCollection InjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region Default

            services.AddControllers();
            services.AddEndpointsApiExplorer();

            #endregion Default

            #region Database

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ApplicationConsts.ConnectionString));

            #endregion Database

            #region ASP.Net Identity

            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.MaxValue;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            #endregion ASP.Net Identity

            #region ApiBehavior Configuration

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    List<string> errors = actionContext.ModelState
                        .Where(e => e.Value?.Errors.Count > 0)
                        .SelectMany(x => x.Value.Errors)
                        .Select(x => x.ErrorMessage).ToList();

                    return new BadRequestObjectResult(new ApiResponse<List<string>> { StatusCode = (int)HttpStatusCode.BadRequest, Details = errors });
                };
            });

            services.AddRateLimiter(rateLimiterOptions =>
            {
                rateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

                rateLimiterOptions.AddFixedWindowLimiter("fixed", options =>
                {
                    options.PermitLimit = 10;
                    options.Window = TimeSpan.FromSeconds(10);
                    options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                    options.QueueLimit = 5;
                });
            });


            services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 100 * 1024 * 1024;
            });

        
        #endregion ApiBehavior Configuration

            #region Authentication

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
            {

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ClockSkew= TimeSpan.Zero,
                    ValidateLifetime = true,
                    ValidateIssuer = true,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidateAudience = true,
                    ValidAudience = configuration["JwtSettings:Audience"],
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = AuthService.GetSymmetricSecurityKey()

                };
            });

            #endregion Authentication

            #region Services

            #region logging

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddFile("Log/log_{0:yyyy}-{0:MM}-{0:dd}.log", fileLoggerOpts =>
                {
                    fileLoggerOpts.FormatLogFileName = fName =>
                    {
                        return string.Format(fName, DateTime.UtcNow);
                    };
                });
            });

            #endregion logging

            #region Mail

            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddScoped<IMailService, MailService>();

            #endregion Mail

            #region File

            services.AddTransient<IFileService, FileService>();

            #endregion Mail

            #region Authentication

            services.AddScoped<IAuthService, AuthService>();

            #endregion Authentication

            #endregion Services

            #region Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRequestReviewerRepository, RequestReviewerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            #endregion Repositories

            #region AutoMapper

            services.AddAutoMapper(typeof(AutoMapperProfile));

            #endregion AutoMapper

            #region Cors

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins(ApplicationConsts.ClientOrigin);
                });
            });

            #endregion Cors

            #region Versioning

            services.AddApiVersioning(opt =>
            {
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.ReportApiVersions = true;
                opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader());
            });

            services.AddVersionedApiExplorer(setup =>
            {
                setup.GroupNameFormat = "'v'VVV";
                setup.SubstituteApiVersionInUrl = true;
            });

            #endregion Versioning

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                var securitySchema = new OpenApiSecurityScheme
                {
                    Description = "JWT Auth Bearer Scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = JwtBearerDefaults.AuthenticationScheme
                    }
                };

                c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, securitySchema);
                var securityRequirement = new OpenApiSecurityRequirement
                {
                    {
                        securitySchema, new[]
                        {
                            JwtBearerDefaults.AuthenticationScheme
                        }
                    }
                };
                c.AddSecurityRequirement(securityRequirement);

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.ConfigureOptions<ConfigureSwaggerOptions>();

            #endregion Swagger

            #region Appsettings Configurations

            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));

            #endregion Appsettings Configurations

            return services;
        }
    }
}