using KratomShop.Data;
using Microsoft.AspNetCore.Identity;

namespace KratomShop.Servicies
{
    public class RoleSeed
    {
        public static async Task SeedRoleAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string adminRole = "Admin";

            // Pokud role Admin neexistuje, vytvoříme ji
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                var roleResult = await roleManager.CreateAsync(new IdentityRole(adminRole));
                if (!roleResult.Succeeded)
                {
                    throw new Exception("Nepodařilo se vytvořit roli Admin.");
                }
            }

            string adminEmail = "marek.pilar@hotmail.cz";

            // Najdeme uživatele podle emailu
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            // Pokud uživatel neexistuje, skončí funkce
            if (adminUser == null)
            {
                return;
            }

            // Pokud uživateli role Admin ještě není přiřazena, přidáme ji
            if (!await userManager.IsInRoleAsync(adminUser, adminRole))
            {
                var addRoleResult = await userManager.AddToRoleAsync(adminUser, adminRole);
                if (!addRoleResult.Succeeded)
                {
                    throw new Exception("Nepodařilo se přiřadit roli Admin uživateli.");
                }
            }
        }
    }
}
