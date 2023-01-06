using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnitedGlowHaven.Areas.Identity.Data;

namespace UnitedGlowHaven.Models
{
    public class Winkelmand
    {
        [Key]
        public int WinkelmandId { get; set; }
        [Required]
        public bool Afgerekend { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Totaal { get; set; }
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        public List<WinkelmandProduct> WinkelmandProducten { get; set; }
    }
}
