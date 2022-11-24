using Microsoft.AspNetCore.Identity;

namespace UnitedGlowHaven.Areas.Identity.Data
{
    public class CustomUser: IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }
        [PersonalData]
        public string Email { get; set; }
    }
}
