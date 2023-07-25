using CovidUsMap.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

using var universalHttpClient = new HttpClient();

builder.Services.AddSingleton(sp => {
    var config = sp.GetRequiredService<IConfiguration>();

    var section = config.GetSection("CovidApi");

    var apiKey = section.GetValue<string>("apiKey") ?? throw new Exception("CovidApi.apiKey config parameter must be provided");
    var cacheValiditySeconds = section.GetValue<int?>("cacheValiditySeconds") ?? 10;

    var result = new CovidMetricsRetriever(
            universalHttpClient, 
            apiKey, 
            TimeSpan.FromSeconds(cacheValiditySeconds)
        );

    return result;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
