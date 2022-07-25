using Microsoft.AspNetCore.Identity;
using P_HRM.Constants;
using System.Threading.Tasks;

namespace P_HRM.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            //await roleManager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));

        }
    }
}
