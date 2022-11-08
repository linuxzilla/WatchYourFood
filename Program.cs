using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Entities;
using Serilog;
using WatchYourFood.Facades;
using WatchYourFood.Helpers;
using WatchYourFood.Repositories;
using WatchYourFood.Repositories.Core;

// ####### Beginning of Main() #######

var builder = WebApplication.CreateBuilder(args);

// Setup application logging
builder.Host.UseSerilog((_, config) => { config.WriteTo.Console(); });

// Get default MongoDb configuration
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection(nameof(MongoDbSettings))
);

// Initialize DB repositories as singletons
builder.Services.AddSingleton<IRepository>(new RecipeRepository());

// Dependency injection
// https://www.dofactory.com/net/facade-design-pattern
// ToDo: Write static class "Extensions"
builder.Services.AddScoped<UserAccountFacades>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}"
    );
});

if (app.Environment.IsDevelopment())
{
    app.UseSpa(spa => { spa.UseProxyToSpaDevelopmentServer("http://localhost:3000"); });
}
else
{
    app.MapFallbackToFile("index.html");
}

// Initialize MongoDb instance
var settings = app.Services.GetRequiredService<IOptions<MongoDbSettings>>().Value;

if (string.IsNullOrEmpty(settings.Username) || string.IsNullOrEmpty(settings.Password))
{
    await DB.InitAsync(settings.Database, settings.MongoHost, settings.Port);
}
else
{
    await DB.InitAsync(settings.Database, new MongoClientSettings()
    {
        Server = new MongoServerAddress(settings.MongoHost, settings.Port),
        Credential =
            MongoCredential.CreateCredential(settings.Database, settings.Username, settings.Password)
    });
}

app.Run();