using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly IWebHostEnvironment _hostEnvironment;

        public AdminController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _uow = unitOfWork;
            _hostEnvironment = hostEnvironment; 
        }


        public async Task<ActionResult<IEnumerable<Product>>> Producten()
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
                Producten = await _uow.ProductRepository.GetAll().ToListAsync()
            };
            return View(vm);
        }

        public async Task<ActionResult<IEnumerable<Product>>> Orders()
        {
            OrdersViewModel vm = new OrdersViewModel()
            {
                Orders = await _uow.WinkelmandRepository.GetAll()
                .Where(o => o.Afgerekend == true)
                .ToListAsync()
            };
            return View(vm);
        }
        public async Task<ActionResult<IEnumerable<Product>>> ProductDetails(int id)
        {
            var product = await _uow.ProductRepository.GetById(id);
            List<Product> producten = await _uow.ProductRepository.GetAll()
                .Include(p => p.Kleur)
                .Include(p => p.Categorie)
                .Include(p => p.Maat)
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
                    ProductNummer = product.ProductNummer,
                    Kleur = product.Kleur,
                    Categorie = product.Categorie,
                    Maat = product.Maat,
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
        public async Task<ActionResult<IEnumerable<Product>>> OrderDetails(int id)
        {
            var order = await _uow.WinkelmandRepository.GetById(id);
            List<Winkelmand> orders = await _uow.WinkelmandRepository.GetAll()
                .Where(p => p.WinkelmandId == id)
                .Include(p => p.WinkelmandProducten)
                .ToListAsync();

            List<WinkelmandProduct> winkelmandProducten = await _uow.WinkelmandProductRepository.GetAll()
           .Include(w => w.Product)
           .Where(w => w.WinkelmandId == id)
           .ToListAsync();

            if (order != null)
            {
                WinkelmandViewModel vm = new WinkelmandViewModel()
                {
                    WinkelmandId = order.WinkelmandId,
                    WinkelmandProducten = winkelmandProducten,
                    CustomUserId = order.CustomUserId
                };
                return View(vm);
            }
            else
            {
                ProductListViewModel vm = new ProductListViewModel()
                {
                    Producten = await _uow.ProductRepository.GetAll().ToListAsync()
                };
                return View(vm);
            }
        }
        [HttpGet]
        public async Task<ActionResult<Winkelmand>> DeleteOrder(int id)
        {
            Winkelmand winkelmand = await _uow.WinkelmandRepository.GetById(id);
            if (winkelmand == null) return NotFound();

            _uow.WinkelmandRepository.Delete(winkelmand);
            await _uow.Save();

            return RedirectToAction("Orders");
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
                ProductNummer = product.ProductNummer,
                Kleur = product.Kleur,
                Categorie = product.Categorie,
                Maat = product.Maat

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
        public async Task<ActionResult> ProductCreate([Bind("Naam", "Beschrijving", "Prijs", "ProductNummer", "KleurId", "CategorieId", "MaatId", "ImageFile")] ProductCreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = vm.ProductNummer;
                string extension = Path.GetExtension(vm.ImageFile.FileName);
                vm.Afbeelding = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/images/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await vm.ImageFile.CopyToAsync(fileStream);
                }
                _uow.ProductRepository.Create(new Product()
                {
                    Naam = vm.Naam,
                    Beschrijving = vm.Beschrijving,
                    Prijs = vm.Prijs,
                    ProductNummer = vm.ProductNummer,
                    KleurId = vm.KleurId,
                    CategorieId = vm.CategorieId,
                    MaatId = vm.MaatId,
                    ImageFile = vm.ImageFile,
                    Afbeelding = vm.Afbeelding,
                });
                await _uow.Save();
                return RedirectToAction(nameof(Producten));
            }
            return View(vm);
        }
    }
}
