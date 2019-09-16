using CoreShopInventoryInAngular.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CoreShopInventoryInAngular.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly CoreShopInventoryInAngularDbContext _context;

        public InitialHostDbBuilder(CoreShopInventoryInAngularDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
