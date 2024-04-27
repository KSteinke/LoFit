namespace LoFit_Client.Services.CommonServices.Interfaces;
public interface ICookieManager
{
    public Task<string> GetValueAsync(string key);
    public Task SetValueAsync<T>(string key, T value);
    Task<bool> ExistsAsync(string key);
}