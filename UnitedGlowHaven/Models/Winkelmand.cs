using System.Collections.Generic;

namespace UnitedGlowHaven.Models
{
    public class Winkelmand
    {
        public int WinkelmandId { get; set; }
        public bool Afgerekend { get; set; }
        public Klant klant { get; set; }
        public ICollection<WinkelmandProduct> WinkelmandProducten { get; set; }
    }
}
