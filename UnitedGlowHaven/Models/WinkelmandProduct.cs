namespace UnitedGlowHaven.Models
{
    public class WinkelmandProduct
    {
        public int WinkelmandProductId { get; set; }
        public int WinkelmandId { get; set; }
        public int ProductId { get; set; }
        public Winkelmand Winkelmand { get; set; }
        public Product Product { get; set; }
    }
}
