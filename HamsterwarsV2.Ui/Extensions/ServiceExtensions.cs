
using Blazored.Toast;
using Entities.Models;
using HamsterwarsV2.Ui.Services;
using SharedHelpers.DataTransferObjects;
using Syncfusion.Blazor;

namespace HamsterwarsV2.Ui.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureServiceManager(this IServiceCollection services) 
        {
           services.AddScoped<IRequestService, RequestService>();
            services.AddSyncfusionBlazor();
        }

        public static void ConfigureHamster(this IServiceCollection services) =>
            services.AddScoped<Hamster>();

    }
}
