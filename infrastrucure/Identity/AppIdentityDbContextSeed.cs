using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "SoftGo",
                    Email = "SoftGo@gmail.com",
                    UserName = "SoftGo@gmail.com",
                    Address = new Address
                    {
                        FirstNameAr = "سوفت",
                        LastNameAr = "جو",
                        FirstNameEn = "Soft",
                        LastNameEn = "Go",
                        Street = "Pyramid gardens",
                        City = "Giza",
                        State = "EG",
                        ZipCode = "71111"

                    }
                };
                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }
}
