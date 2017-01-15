using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kong.Master.Application.Services.Consumers.Interfaces
{
    public interface IConsumerServices
    {
        Task<List<Application.Dto.Consumers.Consumers>> GetConsumersAsync();
    }
}