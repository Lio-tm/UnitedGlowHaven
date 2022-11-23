using System.ComponentModel.DataAnnotations;
using System;

namespace UnitedGlowHaven.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }
        
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        
        public Decimal Prijs { get; set; }
        
        public string Afbeelding { get; set; }
        
        public string ProductNummer { get; set; }
    }
}
