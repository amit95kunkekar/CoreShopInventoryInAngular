using Abp.AutoMapper;
using CoreShopInventoryInAngular.Sessions.Dto;

namespace CoreShopInventoryInAngular.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}