using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Helpers
{
    /// <summary>
    /// Bővítő metódusokat tartalmaz a RoleManager osztályhoz.
    /// </summary>
    public static class RoleHelper
    {
        private static async Task EnsureRoleCreated(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
        public static async Task EnsureRolesCreated(this RoleManager<IdentityRole> roleManager)
        {
            // Ide kerülnek a szerepkörök
            await EnsureRoleCreated(roleManager, "Normal");
            await EnsureRoleCreated(roleManager, "Employee");
            await EnsureRoleCreated(roleManager, "Admin");
        }
    }
}
