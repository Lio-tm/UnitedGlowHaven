using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using UnitedGlowHaven.Areas.Identity.Data;
using UnitedGlowHaven.ViewModels;

namespace UnitedGlowHaven.Controllers
{
    public class GebruikerController : Controller
    {
        private UserManager<CustomUser> _userManager;

        public GebruikerController(UserManager<CustomUser> userManager)
        {
            _userManager = userManager;
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
                    UserName = viewModel.Email,
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

        public async Task<IActionResult> Delete(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            GebruikerDeleteViewModel viewModel = new GebruikerDeleteViewModel()
            {
                GebruikerId = id,
                Voornaam = user.Voornaam,
                Achternaam = user.Achternaam
            };
            return View(viewModel);
        }

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

    }
}

