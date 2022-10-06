using Serilog;
using WatchYourFood.Dao.Core;
using WatchYourFood.Models.Core;
using WatchYourFood.Services;

var builder = WebApplication.CreateBuilder(args);

// Setup application logging

builder.Host.UseSerilog((context, config) =>
{
    config.WriteTo.Console();
});

// Setup MongoDb instance

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection(nameof(MongoDbSettings))
);

builder.Services.AddSingleton<MongoDbContext>();

builder.Services.AddScoped<IDataServices, DataServices>();

// Add services to the container.

builder.Services.AddControllersWithViews();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    // This pulls the code comments into the Swagger docs.
    // See: https://github.com/domaindrivendev/Swashbuckle.AspNetCore#include-descriptions-from-xml-comments
    //string filePath = Path.Combine(System.AppContext.BaseDirectory, "Api.xml");
    //config.IncludeXmlComments(filePath);
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
    app.UseHttpsRedirection();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}"
    );
});

if (app.Environment.IsDevelopment())
{
    app.UseSpa(spa =>
    {
        spa.UseProxyToSpaDevelopmentServer("http://localhost:3000");
    });
}
else
{
    app.MapFallbackToFile("index.html");
}

app.Run();
