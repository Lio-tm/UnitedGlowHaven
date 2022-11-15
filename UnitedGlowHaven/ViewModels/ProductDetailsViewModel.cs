using System.ComponentModel.DataAnnotations;
using System;

namespace UnitedGlowHaven.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }
        [Required]
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        [Required]
        public Decimal Prijs { get; set; }
        [Required]
        public string Afbeelding { get; set; }
        [Required]
        public string ProductNummer { get; set; }
    }
}
