using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CoreShopInventoryInAngular.EntityFramework;

namespace CoreShopInventoryInAngular.Migrator
{
    [DependsOn(typeof(CoreShopInventoryInAngularDataModule))]
    public class CoreShopInventoryInAngularMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CoreShopInventoryInAngularDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}