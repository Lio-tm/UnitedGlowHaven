using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class Klant
    {
        [Key]
        public int KlantId { get; set; }
        [Required]
        public string Voornaam { get; set; }
        [Required]
        public string Achternaam { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
