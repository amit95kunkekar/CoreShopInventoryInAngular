using Abp.Modules;
using Abp.MultiTenancy;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Castle.MicroKernel.Registration;
using NSubstitute;

namespace CoreShopInventoryInAngular.Tests
{
    [DependsOn(
        typeof(CoreShopInventoryInAngularApplicationModule),
        typeof(CoreShopInventoryInAngularDataModule),
        typeof(AbpTestBaseModule))]
    public class CoreShopInventoryInAngularTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Registering fake services

            IocManager.IocContainer.Register(
                Component.For<IAbpZeroDbMigrator>()
                    .UsingFactoryMethod(() => Substitute.For<IAbpZeroDbMigrator>())
                    .LifestyleSingleton()
                );
        }
    }
}
