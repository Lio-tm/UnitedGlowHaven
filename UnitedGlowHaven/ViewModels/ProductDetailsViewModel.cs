using System.ComponentModel.DataAnnotations;
using System;
using UnitedGlowHaven.Models;
using System.Collections.Generic;

namespace UnitedGlowHaven.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }
        
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        [DataType(DataType.Currency)]
        public decimal Prijs { get; set; }
        
        public string Afbeelding { get; set; }
        public Kleur Kleur { get; set; }
        public Categorie Categorie { get; set; }
        public Maat Maat { get; set; }
        
        public string ProductNummer { get; set; }
    }
}
