using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnitedGlowHaven.Data;
using UnitedGlowHaven.Data.UnitOfWork;
using UnitedGlowHaven.Models;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _uow;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<ActionResult<IEnumerable<Product>>> Index()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = await _uow.ProductRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }
        public async Task<ActionResult<IEnumerable<Product>>> Details(int id)
        {
            var product = await _uow.ProductRepository.GetById(id);
            List<Product> producten = await _uow.ProductRepository.GetAll()
                .Where(p => p.ProductId == id)
                .ToListAsync();

            if (product != null)
            {
                ProductDetailsViewModel vm = new ProductDetailsViewModel()
                {
                    ProductId = product.ProductId,
                    Naam = product.Naam,
                    Beschrijving = product.Beschrijving,
                    Prijs = product.Prijs,
                    Afbeelding = product.Afbeelding,
                    ProductNummer = product.ProductNummer
                };
                return View(vm);
            }
            else
            {
                ProductListViewModel vm = new ProductListViewModel()
                {
                    Producten = await _uow.ProductRepository.GetAll().ToListAsync()
                };
                return View("Index", vm);
            }
        }
    }
}
