using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowski.Identity
{
    public class Initializer
    {
        public readonly RoleManager<IdentityRole> _roleManager;

        public Initializer(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

      
    }


        //await roleManager.CreateAsync(new ApplicationRole("Manager"));

        //await roleManager.CreateAsync(new ApplicationRole("User"));

        //var userRole = await roleManager.FindByNameAsync("User");

        //await roleManager.AddClaimAsync(userRole, new Claim(CustomClaimTypes.Permission, Permissions.User.View));

        //await roleManager.AddClaimAsync(userRole, new Claim(CustomClaimTypes.Permission, Permissions.Team.View));

        //var managerRole = await roleManager.FindByNameAsync("Manager");

        //await roleManager.AddClaimAsync(managerRole, new Claim(CustomClaimTypes.Permission, Permissions.Users.Add));

        //await roleManager.AddClaimAsync(managerRole, new Claim(CustomClaimTypes.Permission, Permissions.Teams.Addremove));
    
}
