using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnitedGlowHaven.Models;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> producten { get; set; }

        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            
            _logger = logger;
        }

        public IActionResult Index()
        {
            producten = new List<Product>();
            producten.Add(new Product { Naam = "T-shirt 1", ProductId = 1, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 2", ProductId = 2, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 3", ProductId = 3, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 4", ProductId = 4, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 5", ProductId = 5, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 6", ProductId = 6, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 7", ProductId = 7, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 8", ProductId = 8, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 9", ProductId = 9, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 10", ProductId = 10, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 11", ProductId = 11, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 12", ProductId = 12, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 13", ProductId = 13, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = producten
            };
            return View(vm);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(int id)
        {
            producten = new List<Product>();
            producten.Add(new Product { Naam = "T-shirt 1", ProductId = 1, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 2", ProductId = 2, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 3", ProductId = 3, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 4", ProductId = 4, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 5", ProductId = 5, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 6", ProductId = 6, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 7", ProductId = 7, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 8", ProductId = 8, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 9", ProductId = 9, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 10", ProductId = 10, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 11", ProductId = 11, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 12", ProductId = 12, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            producten.Add(new Product { Naam = "T-shirt 13", ProductId = 13, Afbeelding = "~/images/tshirt.jpg", Beschrijving = "een zwarte t-shirt van katoen", Prijs = 15, ProductNummer = "TSH0988145DZW" });
            Product product = producten.Where(p => p.ProductId == id).FirstOrDefault();

            ProductDetailsViewModel vm = new ProductDetailsViewModel()
            {
                Naam = product.Naam,
                Prijs = product.Prijs,
                Beschrijving = product.Beschrijving
            };
            return View(vm);
        }
    }
}
