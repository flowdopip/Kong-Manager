namespace Kong.Master.Infrastructure.HttpClient
{
    using System.Threading.Tasks;

    public interface IHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);

        Task PutAsync(string requestUri, object body);

        Task PatchAsync(string requestUri, object body);

        Task DeleteAsync(string requestUri);
    }
}
