using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.Areas.Identity.Data
{
    public class CustomUser: IdentityUser
    {
        [PersonalData]
        public string Voornaam { get; set; }
        [PersonalData]
        public string Achternaam { get; set; }
        [PersonalData]
        public string Straat { get; set; }
        [PersonalData]
        public int Huisnummer { get; set; }
        [PersonalData]
        public string Postocde { get; set; }
        [PersonalData]
        public string Gemeente { get; set; }
        public ICollection<Winkelmand> Winkelmand { get; set; }
    }
}
