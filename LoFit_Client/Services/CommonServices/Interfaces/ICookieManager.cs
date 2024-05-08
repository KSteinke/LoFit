namespace LoFit_Client.Services.CommonServices.Interfaces;
/// <summary>
/// Interface for handling cookies acitivities like setting, Getting, existance check.
/// </summary>
public interface ICookieManager
{
    public Task<string> GetValueAsync(string key);
    Task SetValueAsync<T>(string key, T value, int expirationDays);
    Task<bool> ExistsAsync(string key);
}