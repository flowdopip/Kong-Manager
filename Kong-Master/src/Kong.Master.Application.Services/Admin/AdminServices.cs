namespace Kong.Master.Application.Services.Admin
{
    using Dto.Settings;
    using Infrastructure.HttpClient;
    using Infrastructure.Serialization;
    using Interfaces;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class AdminServices : IAdminServices
    {
        private readonly IHttpClient client;

        public AdminServices(IHttpClient client)
        {
            this.client = client;
        }

        public async Task<Settings> GetServerOptionsAsync()
        {
            return await this.client.GetAsync<Settings>("").ConfigureAwait(false);          
        }
    }
}
