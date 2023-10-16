using EDocument_API.Extentions;
using EDocument_API.Middlewares;
using Microsoft.AspNetCore.Mvc.ApiExplorer;


var builder = WebApplication.CreateBuilder(args);
builder.Services.InjectServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRateLimiter();
app.UseMiddleware<ExceptionMiddleware>();

var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions.Reverse())
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
    });




app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCors("AllowAll");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();