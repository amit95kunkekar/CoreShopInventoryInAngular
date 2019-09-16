using System.Threading.Tasks;
using Abp.Application.Services;
using CoreShopInventoryInAngular.Sessions.Dto;

namespace CoreShopInventoryInAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
