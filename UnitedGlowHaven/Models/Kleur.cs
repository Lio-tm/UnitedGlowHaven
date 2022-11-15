using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class Kleur
    {
        public int KleurId { get; set; }
        [Required]
        public string Naam { get; set; }
    }
}
