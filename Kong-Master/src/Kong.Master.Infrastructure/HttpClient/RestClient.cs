namespace Kong.Master.Infrastructure.HttpClient
{
    using Serialization;
    using System;
    using System.Threading.Tasks;

    public class RestClient : IHttpClient
    {
        private static readonly System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();

        private readonly string baseUrl;

        public RestClient(string url)
        {
            this.baseUrl = url;
            httpClient.BaseAddress = new Uri(this.baseUrl);
        }

        public async Task DeleteAsync(string requestUri)
        {
            await httpClient.DeleteAsync(requestUri);            
        }

        public async Task<T> GetAsync<T>(string requestUri)
        {
            var response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<T>(json);
            }

            throw new NotFoundException();
        }

        public Task PatchAsync(string requestUri, object body)
        {
            throw new NotImplementedException();
        }

        public Task PutAsync(string requestUri, object body)
        {
            throw new NotImplementedException();
        }
    }
}
