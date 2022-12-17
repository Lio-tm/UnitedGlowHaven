using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.ViewModels
{
    public class GebruikerCreateViewModel
    {
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
