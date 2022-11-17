using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class Product
    {
        [Key]
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
        [Required]
        public int KleurId { get; set; }
        public Kleur Kleur { get; set; }
        [Required]
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public ICollection<ProductMaat> ProductMaten { get; set; }

    }
}
