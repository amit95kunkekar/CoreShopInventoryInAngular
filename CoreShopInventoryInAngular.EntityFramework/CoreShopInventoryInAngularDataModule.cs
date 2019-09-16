using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using CoreShopInventoryInAngular.EntityFramework;

namespace CoreShopInventoryInAngular
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(CoreShopInventoryInAngularCoreModule))]
    public class CoreShopInventoryInAngularDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CoreShopInventoryInAngularDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
