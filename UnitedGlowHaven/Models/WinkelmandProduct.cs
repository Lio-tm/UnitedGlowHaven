using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitedGlowHaven.Models
{
    public class WinkelmandProduct
    {
        [Key]
        public int WinkelmandProductId { get; set; }
        public int Aantal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prijs { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotaal { get; set; }
        public int WinkelmandId { get; set; }
        public int ProductId { get; set; }
        public Winkelmand Winkelmand { get; set; }
        public Product Product { get; set; }
    }
}
