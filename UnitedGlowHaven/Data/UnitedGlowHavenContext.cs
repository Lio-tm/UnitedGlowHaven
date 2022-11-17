using Microsoft.EntityFrameworkCore;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.Data
{
    public class UnitedGlowHavenContext : DbContext
    {
        public UnitedGlowHavenContext(DbContextOptions<UnitedGlowHavenContext> option) : base(option)
        {

        }
        public DbSet<Categorie> Categorieën { get; set; }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Kleur> Kleuren { get; set; }
        public DbSet<Maat> Maten { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<ProductMaat> ProductMaten { get; set; }
        public DbSet<Winkelmand> Winkelmand { get; set; }
        public DbSet<WinkelmandProduct> WinkelmandProducten { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().ToTable("Categorie");
            modelBuilder.Entity<Klant>().ToTable("Klant");
            modelBuilder.Entity<Kleur>().ToTable("Kleur");
            modelBuilder.Entity<Maat>().ToTable("Maat");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductMaat>().ToTable("ProductMaat");
            modelBuilder.Entity<Winkelmand>().ToTable("Winkelmand");
            modelBuilder.Entity<WinkelmandProduct>().ToTable("WinkelmandProduct");
        }
    }
}
