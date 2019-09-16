using Abp.Authorization;
using CoreShopInventoryInAngular.Authorization.Roles;
using CoreShopInventoryInAngular.Authorization.Users;

namespace CoreShopInventoryInAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
