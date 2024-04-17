namespace LoFit_Client.Services.CommonServices;
public static class CommonServices
{
    public static void ConfigureCommonServices(IServiceCollection services)
    {
        services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44355/")});
    }
}
