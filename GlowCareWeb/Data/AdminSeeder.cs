using Microsoft.AspNetCore.Identity;

namespace GlowCareWeb.Data;

public static class AdminSeeder
{
    public static async Task SeedAdmin(UserManager<ApplicationUser> userManager)
    {
        var admin = await userManager.FindByEmailAsync("admin@glowcare.com");

        if (admin != null)
        {
            if (!await userManager.IsInRoleAsync(admin, "Admin"))
            {
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}