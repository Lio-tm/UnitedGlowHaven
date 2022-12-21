using System.ComponentModel.DataAnnotations;

namespace UnitedGlowHaven.Models
{
    public class WinkelmandProduct
    {
        [Key]
        public int WinkelmandProductId { get; set; }
        public int Aantal { get; set; }
        public decimal Prijs { get; set; }
        public int WinkelmandId { get; set; }
        public int ProductId { get; set; }
        public Winkelmand Winkelmand { get; set; }
        public Product Product { get; set; }
    }
}
