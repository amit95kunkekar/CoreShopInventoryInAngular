using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using CoreShopInventoryInAngular.EntityFramework;

namespace CoreShopInventoryInAngular.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<CoreShopInventoryInAngularDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}
