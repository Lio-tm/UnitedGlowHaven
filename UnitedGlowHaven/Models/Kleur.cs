using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class Kleur
    {
        [Key]
        public int KleurId { get; set; }
        [Required]
        public string Naam { get; set; }
        public ICollection<Product> Producten { get; set; }

    }
}
