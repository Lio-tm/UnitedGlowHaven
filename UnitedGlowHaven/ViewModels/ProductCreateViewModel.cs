using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.ViewModels
{
    public class ProductCreateViewModel
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public decimal Prijs { get; set; }
        public string Afbeelding { get; set; }        
        public int CategorieId { get; set; }
        public int KleurId { get; set; }
        public int MaatId { get; set; }
        public string ProductNummer { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
