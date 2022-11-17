using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        [Required]
        public string Naam { get; set; }
    }
}
