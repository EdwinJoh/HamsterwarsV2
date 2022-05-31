
using Blazored.LocalStorage;
using Blazored.Toast;
using Entities.Models;
using HamsterwarsV2.Ui.Services;
using HamsterwarsV2.Ui.Services.AuthService;
using SharedHelpers.DataTransferObjects;

namespace HamsterwarsV2.Ui.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddBlazoredLocalStorage();

        }

        public static void ConfigureHamster(this IServiceCollection services) =>
            services.AddScoped<Hamster>();

    }
}
