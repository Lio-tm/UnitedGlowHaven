using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
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
    public class CategorieController : Controller
    {
        private readonly IUnitOfWork _uow;
        public CategorieController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ActionResult<IEnumerable<Product>>> Index(int id)
        {
            ProductListViewModel vm = new ProductListViewModel()
            {
               Producten = await _uow.ProductRepository.GetAll()
               .Include(p => p.Maat)
               .Where(p => p.CategorieId == id)
                .ToListAsync()
            };
            return View(vm);
        }
    }
}

