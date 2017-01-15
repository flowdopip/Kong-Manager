namespace Kong.Master.Application.Services.Consumers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Interfaces;
    using Kong.Master.Infrastructure.HttpClient;

    public class ConsumerServices : IConsumerServices
    {
        private readonly IHttpClient client;

        public ConsumerServices(IHttpClient client)
        {
            this.client = client;
        }

        public async Task<List<Application.Dto.Consumers.Consumers>> GetConsumersAsync()
        {
            return await this.client.GetAsync<List<Application.Dto.Consumers.Consumers>>("/consumers").ConfigureAwait(false);            
        }
    }
}
