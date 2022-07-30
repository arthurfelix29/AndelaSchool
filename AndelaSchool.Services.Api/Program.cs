using AndelaSchool.Services.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
           .SetBasePath(builder.Environment.ContentRootPath)
           .AddJsonFile("appsettings.json", true, true)
           .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
           .AddEnvironmentVariables();

builder.Services
           .AddDependencyInjection()
           .AddPersistence(builder.Configuration)
           .AddCore()
           .AddControllers()
           .AddJson();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();
app.UseRouting();

app.UseSwaggerWithVersioning();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

public partial class Program { }