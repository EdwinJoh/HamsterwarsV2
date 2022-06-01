using Blazored.LocalStorage;
using Entities.Models;
using HamsterwarsV2.Ui.Services;
using HamsterwarsV2.Ui.Services.AuthService;
using Microsoft.AspNetCore.Components.Authorization;

namespace HamsterwarsV2.Ui.Extensions;
/// <summary>
/// This helps us clean up the program.cs class and keep all out services together.
/// </summary>
public static class ServiceExtensions
{
    public static void ConfigureServiceManager(this IServiceCollection services)
    {
        services.AddScoped<IRequestService, RequestService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddBlazoredLocalStorage();
        services.AddOptions();
        services.AddAuthorizationCore();
        services.AddScoped<AuthenticationStateProvider, CustomerAuthStateProvider>();
    }
    public static void ConfigureHamster(this IServiceCollection services) =>
    services.AddScoped<Hamster>();
}
