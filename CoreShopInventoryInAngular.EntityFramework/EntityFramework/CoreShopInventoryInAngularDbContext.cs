using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using CoreShopInventoryInAngular.Authorization.Roles;
using CoreShopInventoryInAngular.Authorization.Users;
using CoreShopInventoryInAngular.MultiTenancy;

namespace CoreShopInventoryInAngular.EntityFramework
{
    public class CoreShopInventoryInAngularDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CoreShopInventoryInAngularDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CoreShopInventoryInAngularDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CoreShopInventoryInAngularDbContext since ABP automatically handles it.
         */
        public CoreShopInventoryInAngularDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public CoreShopInventoryInAngularDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public CoreShopInventoryInAngularDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
