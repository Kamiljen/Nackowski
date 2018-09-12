using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Nackowski.Identity
{
        public static class ApplicationDbInitializer
        {
        
        public static async void SeedClaims(RoleManager<IdentityRole> roleManager)
        {

            //await roleManager.CreateAsync(new ApplicationRole("Manager"));

            //await roleManager.CreateAsync(new ApplicationRole("User"));

            //var userRole = await roleManager.FindByNameAsync("User");

            //var adminRole = new IdentityRoleClaim()
            //await roleManager.AddClaimAsync(userRole, new IdentityRoleClaim<IdentityRole>) { });

            //await roleManager.AddClaimAsync(userRole, new Claim(CustomClaimTypes.Permission, Permissions.Team.View));

            //var managerRole = await roleManager.FindByNameAsync("Manager");

            //await roleManager.AddClaimAsync(managerRole, new Claim(CustomClaimTypes.Permission, Permissions.Users.Add));

            //await roleManager.AddClaimAsync(managerRole, new Claim(CustomClaimTypes.Permission, Permissions.Teams.Addremove));
        }
        public static void SeedUsers(UserManager<IdentityUser> userManager )
            {
                if (userManager.FindByEmailAsync("alex@test.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "alex@test.com",
                        Email = "alex@test.com"
                    };

                    IdentityResult result = userManager.CreateAsync(user, "!Nackademin002").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Admin").Wait();
                    }
                }
            }
        }
    }

