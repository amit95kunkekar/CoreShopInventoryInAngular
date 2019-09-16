using System.Threading.Tasks;
using Abp.Application.Services;
using CoreShopInventoryInAngular.Authorization.Accounts.Dto;

namespace CoreShopInventoryInAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
