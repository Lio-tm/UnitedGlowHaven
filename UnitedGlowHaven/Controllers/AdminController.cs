using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitedGlowHaven.Data.UnitOfWork;
using UnitedGlowHaven.Models;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _uow;
        public AdminController(IUnitOfWork unitOfWork) { _uow = unitOfWork; }

        public async Task<ActionResult<IEnumerable<Product>>> Producten()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = await _uow.ProductRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }
        public async Task<ActionResult<IEnumerable<Product>>> ProductDetails(int id)
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

        [HttpGet]
        public async Task<ActionResult<Product>> EditProduct(int id)
        {
            Product product = await _uow.ProductRepository.GetById(id);
            if (product == null) return NotFound();

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

        [HttpPost]
        public async Task<IActionResult> EditProduct(int id, ProductDetailsViewModel vm)
        {
            if (id != vm.ProductId) return NotFound();
            Product product = await _uow.ProductRepository.GetById(id);

            if (ModelState.IsValid)
            {
                try
                {
                    product.ProductId = vm.ProductId;
                    product.Naam = vm.Naam;
                    product.Beschrijving = vm.Beschrijving;
                    product.Prijs = vm.Prijs;
                    product.Afbeelding = vm.Afbeelding;
                    product.ProductNummer = vm.ProductNummer;

                    _uow.ProductRepository.Update(product);
                    await _uow.Save();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    throw e;
                }
            }

            return RedirectToAction("Producten");
        }

        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            _uow.ProductRepository.Create(product);
            await _uow.Save();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            Product product = await _uow.ProductRepository.GetById(id);
            if (product == null) return NotFound();

            _uow.ProductRepository.Delete(product);
            await _uow.Save();

            return RedirectToAction("Index");
        }

        public ActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ProductCreate(ProductCreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _uow.ProductRepository.Create(new Product()
                {
                    Naam = vm.Naam,
                    Beschrijving = vm.Beschrijving,
                    Prijs = vm.Prijs,
                    Afbeelding = vm.Afbeelding,
                    ProductNummer = vm.ProductNummer,
                    KleurId = vm.KleurId,
                    CategorieId = vm.CategorieId
                });
                await _uow.Save();
                return RedirectToAction(nameof(Producten));
            }
            return View(vm);
        }
    }
}
