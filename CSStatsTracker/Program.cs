using Blazored.LocalStorage;
using CSStatsTracker;
using CSStatsTracker.Services.LastMatch;
using CSStatsTracker.Services.LastMatchStats;
using CSStatsTracker.Services.PlayerStats;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Dependencies
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IPlayerStatsService, PlayerStatsService>();
builder.Services.AddScoped<ILastMatchService, LastMatchService>();
builder.Services.AddScoped<ILastMatchStatsService, LastMatchStatsService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("FaceitClient", client =>
{
    client.BaseAddress = new Uri("https://open.faceit.com/data/v4/");
    client.DefaultRequestHeaders.Add("Authorization", "Bearer c270aaf6-113f-4af1-8b11-65911b3faaae");
});

await builder.Build().RunAsync();
