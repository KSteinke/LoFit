using LoFit_Client.Services.CommonServices.Interfaces;

namespace LoFit_Client.Services.CommonServices;
/// <summary>
/// Service that injects services common for both client and server. 
/// </summary>
public static class CommonServices
{
    public static void ConfigureCommonServices(IServiceCollection services)
    {
        services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44355/")});
        services.AddTransient<ICookieManager, CookieManager>();
    }
}
