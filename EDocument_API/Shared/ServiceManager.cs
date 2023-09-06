using EDocument_API.Helpers;
using EDocument_Data.Consts;
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models;
using EDocument_EF;
using EDocument_Services.Auth_Service;
using EDocument_Services.AutoMapper_Service;
using EDocument_Services.Helpers;
using EDocument_Services.Mail_Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace EDocument_API.Shared
{
    public static class ServiceManager
    {
        public static IServiceCollection InjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region Default

            services.AddControllers();
            services.AddEndpointsApiExplorer();

            #endregion Default

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

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
            });

            #endregion Swagger

            #region Database

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ApplicationConsts.ConnectionString));

            #endregion Database

            #region ASP.Net Identity

            services.AddIdentity<User,Role>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            #endregion ASP.Net Identity

            #region logging

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddFile("log_{0:yyyy}-{0:MM}-{0:dd}.log", fileLoggerOpts =>
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

            #endregion Mail

            #region AutoMapper

            services.AddAutoMapper(typeof(AutoMapperProfile));

            #endregion AutoMapper

            #region Cors

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200");
                });
            });

            #endregion Cors

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
                      ValidateIssuerSigningKey = true,
                      ValidIssuer = configuration["JWT:Issuer"],
                      ValidAudience = configuration["JWT:Audience"],
                      IssuerSigningKey = AuthService.GetSymmetricSecurityKey()
                  };
              });

            #endregion Authentication

            #region Autorization

            services.AddAuthorization(options =>
            {
                options.AddPolicy(ApplicationRole.ADMIN.ToString(), policy => policy.RequireClaim(nameof(ApplicationRole), ApplicationRole.ADMIN.ToString()));
                options.AddPolicy(ApplicationRole.HR.ToString(), policy => policy.RequireClaim(nameof(ApplicationRole), ApplicationRole.HR.ToString()));
                options.AddPolicy(ApplicationRole.FINANCE.ToString(), policy => policy.RequireClaim(nameof(ApplicationRole), ApplicationRole.FINANCE.ToString()));
                options.AddPolicy(ApplicationRole.IT.ToString(), policy => policy.RequireClaim(nameof(ApplicationRole), ApplicationRole.IT.ToString()));
            });

            #endregion Autorization

            return services;
        }
    }
}