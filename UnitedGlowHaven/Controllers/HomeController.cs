using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnitedGlowHaven.Data;
using UnitedGlowHaven.Data.Repositories;
using UnitedGlowHaven.Data.UnitOfWork;
using UnitedGlowHaven.Models;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uow;
        public HomeController(IUnitOfWork unitOfWork)
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
    }
}

