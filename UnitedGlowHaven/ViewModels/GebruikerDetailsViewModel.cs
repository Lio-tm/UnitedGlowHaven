using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.ViewModels
{
    public class GebruikerDetailsViewModel
    {
        public string Achternaam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public string GebruikerId { get; set; }
    }
}
