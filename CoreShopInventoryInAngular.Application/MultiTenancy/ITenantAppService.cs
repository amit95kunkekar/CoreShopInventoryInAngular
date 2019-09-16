using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CoreShopInventoryInAngular.MultiTenancy.Dto;

namespace CoreShopInventoryInAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
