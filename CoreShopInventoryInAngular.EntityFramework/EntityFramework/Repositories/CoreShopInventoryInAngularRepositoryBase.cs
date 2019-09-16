using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CoreShopInventoryInAngular.EntityFramework.Repositories
{
    public abstract class CoreShopInventoryInAngularRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CoreShopInventoryInAngularDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CoreShopInventoryInAngularRepositoryBase(IDbContextProvider<CoreShopInventoryInAngularDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CoreShopInventoryInAngularRepositoryBase<TEntity> : CoreShopInventoryInAngularRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CoreShopInventoryInAngularRepositoryBase(IDbContextProvider<CoreShopInventoryInAngularDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
