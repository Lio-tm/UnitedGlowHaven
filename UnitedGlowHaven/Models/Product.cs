using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prijs { get; set; }
        [Required]
        public string Afbeelding { get; set; }
        [Required]
        public string ProductNummer { get; set; }
        [Required]
        public int KleurId { get; set; }
        
        [Required]
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public Kleur Kleur { get; set; }
        public ICollection<ProductMaat> ProductMaten { get; set; }
        public ICollection<WinkelmandProduct> WinkelmandProducten { get; set; }
        [NotMapped]

        public IFormFile ImageFile { get; set; }

    }
}
