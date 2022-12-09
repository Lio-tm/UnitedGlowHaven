using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitedGlowHaven.Areas.Identity.Data;

namespace UnitedGlowHaven.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;

        public IndexModel(
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [PersonalData]
            public string Voornaam { get; set; }
            [PersonalData]
            public string Achternaam { get; set; }
            [PersonalData]

            public string Straat { get; set; }
            [PersonalData]
            public int Huisnummer { get; set; }
            [PersonalData]
            public string Postocde { get; set; }
            [PersonalData]
            public string Gemeente { get; set; }
        }

        private async Task LoadAsync(CustomUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var Voornaam = await Task.FromResult(user.Voornaam);
            var Achternaam = await Task.FromResult(user.Achternaam);
            var Straat = await Task.FromResult(user.Straat);
            var Huisnummer = await Task.FromResult(user.Huisnummer);
            var Postcode = await Task.FromResult(user.Postocde);
            var Gemeente = await Task.FromResult(user.Gemeente);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Voornaam = Voornaam,
                Achternaam = Achternaam,
                Straat = Straat,
                Huisnummer = Huisnummer,
                Postocde = Postcode,
                Gemeente = Gemeente
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }
            user.Voornaam = Input.Voornaam;
            user.Achternaam = Input.Achternaam;
            user.Straat = Input.Straat;
            user.Huisnummer = Input.Huisnummer;
            user.Postocde = Input.Postocde;
            user.Gemeente = Input.Gemeente;

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
