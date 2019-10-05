using System;
using System.Threading.Tasks;
using IdentityProject.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Data
{
    public class SeedData
    {
        public static async Task Initialize(ApplicationDbContext context,
                             UserManager<ApplicationUser> userManager,
                             RoleManager<ApplicationRole> roleManager)
        {
            //this line was caused the problem when i seed data
            //context.Database.EnsureCreated();

            string adminId = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("admin@test.tr") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@test.tr",
                    FirstName = "Adam",
                    LastName = "Ict",
                    Email = "admin@test.tr",
                    PhoneNumber = "5524169960",
                    Gender = "Male",
                    Country = "Turkwy",
                    City = "Istanbul"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId = user.Id;
            }
            if (await userManager.FindByNameAsync("member@test.tr") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "member@test.tr",
                    FirstName = "Member",
                    LastName = "Ict",
                    Email = "member@test.tr",
                    PhoneNumber = "5524169961",
                    Gender = "Male",
                    Country = "Turkwy",
                    City = "Istanbul"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}
