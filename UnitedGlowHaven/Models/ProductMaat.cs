using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class ProductMaat
    {
        [Key]
        public int ProductMaatId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int MaatId { get; set; }
        public Product Product { get; set; }
        public Maat Maat { get; set; }
    }
}
