namespace Kong.Master.Application.Services.Interfaces
{
    using Kong.Master.Application.Dto.Settings;
    using System.Threading.Tasks;

    public interface IAdminServices
    {
        Task<Settings> GetServerOptionsAsync();
    }
}