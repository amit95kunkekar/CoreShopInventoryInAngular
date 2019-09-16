using Abp.Web.Mvc.Views;

namespace CoreShopInventoryInAngular.Web.Views
{
    public abstract class CoreShopInventoryInAngularWebViewPageBase : CoreShopInventoryInAngularWebViewPageBase<dynamic>
    {

    }

    public abstract class CoreShopInventoryInAngularWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CoreShopInventoryInAngularWebViewPageBase()
        {
            LocalizationSourceName = CoreShopInventoryInAngularConsts.LocalizationSourceName;
        }
    }
}