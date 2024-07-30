namespace BibliotecaArqMod.EP_Usuario.Web.Services.httpClientService
{
    public interface IHttpClientService
    {
        Task<T> GetAsync<T>(string endpoint);
        Task<T> PostAsync<T>(string endpoint, object data);
    }
}
