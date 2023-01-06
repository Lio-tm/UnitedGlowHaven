using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UnitedGlowHaven.Areas.Identity.Data;
using UnitedGlowHaven.Data;
using UnitedGlowHaven.Data.UnitOfWork;
using UnitedGlowHaven.Migrations;
using UnitedGlowHaven.Models;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    [Authorize]
    public class WinkelmandController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly UnitedGlowHavenContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public WinkelmandController(IUnitOfWork uow, UserManager<CustomUser> userManager, UnitedGlowHavenContext context)
        {
            _uow = uow;
            _userManager = userManager;
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            CustomUser user = await _userManager.GetUserAsync(HttpContext.User);
            Winkelmand winkelmand = await _context.Winkelmand.Where(w => w.CustomUserId == user.Id && w.Afgerekend == false).FirstOrDefaultAsync();

            if (winkelmand == null)
            {
                return RedirectToAction(nameof(LegeWinkelmand));
            };

            List<WinkelmandProduct> winkelmandProducten = await _uow.WinkelmandProductRepository.GetAll()
            .Include(w => w.Product)
            .Where(w => w.WinkelmandId == winkelmand.WinkelmandId)
            .ToListAsync();

            if (winkelmandProducten.Count > 0)
            {
                WinkelmandViewModel vm = new WinkelmandViewModel()
                {
                    WinkelmandId = winkelmand.WinkelmandId,
                    WinkelmandProducten = winkelmandProducten,
                };
                foreach (var item in winkelmand.WinkelmandProducten)
                {
                    vm.Totaal += item.SubTotaal;
                }
                _uow.WinkelmandRepository.Update(winkelmand);

                return View(vm);
            }

            return RedirectToAction(nameof(LegeWinkelmand));

        }
        public async Task<ActionResult> LegeWinkelmand()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> NieuwWinkelmandProduct(ProductDetailsViewModel vm)
        {
            CustomUser user = await _userManager.GetUserAsync(HttpContext.User);
            Winkelmand winkelmand = await _context.Winkelmand.Where(w => w.CustomUserId == user.Id && w.Afgerekend == false).FirstOrDefaultAsync();
            Product product = await _uow.ProductRepository.GetById(vm.ProductId);
            WinkelmandProduct winkelmandProduct = null;


            if (winkelmand == null)
            {
                winkelmand = new Winkelmand()
                {
                    CustomUserId = user.Id,
                    Afgerekend = false
                };
                _uow.WinkelmandRepository.Create(winkelmand);
                await _uow.Save();
            }
            else
            {
                winkelmandProduct = await _context.WinkelmandProducten.Where(w => w.ProductId == product.ProductId && w.WinkelmandId == winkelmand.WinkelmandId).FirstOrDefaultAsync();
            }
            if (winkelmandProduct == null)
            {
                winkelmandProduct = new WinkelmandProduct()
                {
                    Aantal = 1,
                    Prijs = product.Prijs,
                    ProductId = product.ProductId,
                    WinkelmandId = winkelmand.WinkelmandId,
                    SubTotaal = product.Prijs * 1
                };
                _uow.WinkelmandProductRepository.Create(winkelmandProduct);
                
            }
            else
            {
                winkelmandProduct.Aantal += 1;
                winkelmandProduct.SubTotaal = product.Prijs * winkelmandProduct.Aantal;
                _uow.WinkelmandProductRepository.Update(winkelmandProduct);
                
            }

           
            await _uow.Save();

            

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> DeleteProductFromShoppingcart(int id)
        {
            CustomUser user = await _userManager.GetUserAsync(HttpContext.User);
            WinkelmandProduct winkelmandProduct = await _uow.WinkelmandProductRepository.GetById(id);
            Winkelmand winkelmand = await _context.Winkelmand.Where(w => w.CustomUserId == user.Id && w.Afgerekend == false).FirstOrDefaultAsync();

            if (winkelmandProduct == null) return NotFound();

            _uow.WinkelmandProductRepository.Delete(winkelmandProduct);
            await _uow.Save();


            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Afrekenen(int id)
        {
            CustomUser user = await _userManager.GetUserAsync(HttpContext.User);
            Winkelmand winkelmand = await _uow.WinkelmandRepository.GetById(id);
            winkelmand.Afgerekend = true;
            
            _uow.WinkelmandRepository.Update(winkelmand);
            await _uow.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
