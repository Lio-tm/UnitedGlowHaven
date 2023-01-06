using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.ViewModels
{
    public class GebruikerCreateViewModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
