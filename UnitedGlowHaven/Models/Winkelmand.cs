using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class Winkelmand
    {
        [Key]
        public int WinkelmandId { get; set; }
        [Required]
        public bool Afgerekend { get; set; }
        [Required]
        public int KlantId { get; set; }
        public Klant klant { get; set; }
        public ICollection<WinkelmandProduct> WinkelmandProducten { get; set; }
    }
}
