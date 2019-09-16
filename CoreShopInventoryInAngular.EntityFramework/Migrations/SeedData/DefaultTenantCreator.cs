using System.Linq;
using CoreShopInventoryInAngular.EntityFramework;
using CoreShopInventoryInAngular.MultiTenancy;

namespace CoreShopInventoryInAngular.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly CoreShopInventoryInAngularDbContext _context;

        public DefaultTenantCreator(CoreShopInventoryInAngularDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
