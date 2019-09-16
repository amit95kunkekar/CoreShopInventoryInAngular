using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CoreShopInventoryInAngular.Configuration.Dto;

namespace CoreShopInventoryInAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CoreShopInventoryInAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
