using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UnitedGlowHaven.Areas.Identity.Data;
using UnitedGlowHaven.Migrations;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    [Authorize(Roles = "admin")]
    public class GebruikerController : Controller
    {
        private UserManager<CustomUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public GebruikerController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            GebruikerListViewModel viewModel = new GebruikerListViewModel()
            {
                Gebruikers = _userManager.Users.ToList()
            };
            return View(viewModel);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GebruikerCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser gebruiker = new CustomUser
                {
                    Voornaam = viewModel.Voornaam,
                    Achternaam = viewModel.Achternaam,
                    UserName = viewModel.UserName,
                    Email = viewModel.Email
                    
                };
                IdentityResult result = await _userManager.CreateAsync(gebruiker, viewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(viewModel);
        }

        //public async Task<IActionResult> Delete(string id)
        //{
        //    CustomUser user = await _userManager.FindByIdAsync(id);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    GebruikerDeleteViewModel viewModel = new GebruikerDeleteViewModel()
        //    {
        //        GebruikerId = id,
        //        Voornaam = user.Voornaam,
        //        Achternaam = user.Achternaam
        //    };
        //    return View(viewModel);
        //}

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", _userManager.Users.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", _userManager.Users.ToList());
        }
        public IActionResult Edit(string id)
        {
            CustomUser gebruiker = _userManager.Users.Where(k => k.Id == id).FirstOrDefault();


            if (gebruiker != null)
            {
                GebruikerEditViewModel viewModel = new GebruikerEditViewModel()
                {
                    GebruikerId = gebruiker.Id,
                    Voornaam = gebruiker.Voornaam,
                    Achternaam = gebruiker.Achternaam,
                    Email = gebruiker.UserName,

                };
                return View(viewModel);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult Details(string id)
        {
            CustomUser gebruiker = _userManager.Users.Where(k => k.Id == id).FirstOrDefault();


            if (gebruiker != null)
            {
                GebruikerDetailsViewModel viewModel = new GebruikerDetailsViewModel()
                {
                    GebruikerId = gebruiker.Id,
                    Voornaam = gebruiker.Voornaam,
                    Achternaam = gebruiker.Achternaam,
                    Email = gebruiker.UserName,

                };
                return View(viewModel);
            }
            else
            {
                GebruikerListViewModel viewModel = new GebruikerListViewModel()
                {
                    Gebruikers = _userManager.Users.ToList()
                };
                return RedirectToAction("Index", viewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GebruikerEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser gebruiker = await _userManager.FindByIdAsync(viewModel.GebruikerId);

                gebruiker.Voornaam = viewModel.Voornaam;
                gebruiker.Achternaam = viewModel.Achternaam;
                gebruiker.Email = viewModel.Email;

                IdentityResult result = await _userManager.UpdateAsync(gebruiker);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(viewModel);
        }

        public IActionResult GrantPermissions()
        {
            GrantPermissionsViewModel viewModel = new GrantPermissionsViewModel()
            {
                Gebruikers = new SelectList(_userManager.Users.ToList(), "Id", "UserName"),
                Rollen = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> GrantPermissions(GrantPermissionsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = await _userManager.FindByIdAsync(viewModel.GebruikerId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                else
                    ModelState.AddModelError("", "User or role Not Fount");
            }
            return View(viewModel);
        }

    }
}

