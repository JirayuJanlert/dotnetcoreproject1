using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace authproject.Areas.Identity.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager,
         RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (!await roleManager.RoleExistsAsync("user"))
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }

            var defaultUser = new ApplicationUser
            {
                FirstName = "Jirayu",
                LastName = "Janlert",
                Email = "admin@localhost",
                UserName = "admin@localhost"
            };

            if (userManager.Users.All(u => u.UserName != defaultUser.UserName)){
                await userManager.CreateAsync(defaultUser, "12345678");
            }

            defaultUser = await userManager.FindByNameAsync("admin@localhost");



            if(!await userManager.IsInRoleAsync(defaultUser, "admin"))
            {
                await userManager.AddToRoleAsync(defaultUser, "admin");
            }

        }

    
    }
}