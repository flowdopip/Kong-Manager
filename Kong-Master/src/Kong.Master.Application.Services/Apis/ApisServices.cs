namespace Kong.Master.Application.Services.Apis
{
    using Kong.Master.Application.Services.Interfaces;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApisServices : IApisServices
    {
        private readonly HttpClient client;

        public ApisServices(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<Kong.Master.Application.Dto.Api.Apis>> GetAllAsync()
        {
            await Task.Yield();

            var response = this.client.GetAsync("/apis");

            return null;
        }
    }
}

