namespace UnitedGlowHaven.Models
{
    public class ProductMaat
    {
        public int ProductMaatId { get; set; }
        public int ProductId { get; set; }
        public int MaatId { get; set; }
        public Product Product { get; set; }
        public Maat Maat { get; set; }
    }
}
