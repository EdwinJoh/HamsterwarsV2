using HamsterwarsV2.Ui;
using HamsterwarsV2.Ui.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Smart.Blazor;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5000/") });

builder.Services.ConfigureServiceManager();
builder.Services.ConfigureHamster();
builder.Services.AddSmart();

await builder.Build().RunAsync();
