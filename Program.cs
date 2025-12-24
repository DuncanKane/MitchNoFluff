using MitchNoFluff.ApiClients;
using MitchNoFluff.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IFootballApiService, FootballApiService>();

builder.Services.AddHttpClient<FootballApiClient>((sp, client) =>
{
    var config = sp.GetRequiredService<IConfiguration>();

    client.BaseAddress = new Uri(config["ExternalApis:FootballApi:BaseUrl"]!);
    client.DefaultRequestHeaders.Add(
        "X-Api-Key",
        config["ExternalApis:FootballApi:ApiKey"]
    );
});


builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddComposers()
    .Build();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();


app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });


await app.RunAsync();
