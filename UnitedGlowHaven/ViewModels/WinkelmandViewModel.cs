using System.Collections.Generic;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.ViewModels
{
    public class WinkelmandViewModel
    {
        public int WinkelmandId { get; set; }
        public decimal Totaal { get; set; }
        public string CustomUserId { get; set; }
        public bool Afgerekend { get; set; }
        public List <WinkelmandProduct> WinkelmandProducten { get; set; }
    }
}
