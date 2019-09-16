using Abp.MultiTenancy;
using CoreShopInventoryInAngular.Authorization.Users;

namespace CoreShopInventoryInAngular.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}