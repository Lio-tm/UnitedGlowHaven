using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class WinkelmandProduct
    {
        [Key]
        public int WinkelmandProductId { get; set; }
        public int WinkelmandId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public Winkelmand Winkelmand { get; set; }
        public Product Product { get; set; }
    }
}
