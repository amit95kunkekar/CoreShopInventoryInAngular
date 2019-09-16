using System.Threading.Tasks;
using Abp.Application.Services;
using CoreShopInventoryInAngular.Configuration.Dto;

namespace CoreShopInventoryInAngular.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}