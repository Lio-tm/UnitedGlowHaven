using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnitedGlowHaven.Data;
using UnitedGlowHaven.Models;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    public class ProductController : Controller
    {
        private readonly UnitedGlowHavenContext _context;
        public ProductController(UnitedGlowHavenContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = _context.Producten.ToList(),
            };
            return View(vm);
        }

        public IActionResult Details(int id)
        {
            Product product = _context.Producten.Where(p => p.ProductId == id).FirstOrDefault();

            ProductDetailsViewModel vm = new ProductDetailsViewModel()
            {
                Naam = product.Naam,
                Prijs = product.Prijs,
                Beschrijving = product.Beschrijving,
                Afbeelding = product.Afbeelding,
                ProductId = product.ProductId,
                ProductNummer = product.ProductNummer,

            };
            return View(vm);
        }
    }
}
