using ILMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.Singin_page
{
    public class LoginModel : PageModel
    {
		private readonly SignInManager<IdentityUser> signInManager;

		[BindProperty]
		public Login Login { get; set; }

		public LoginModel( SignInManager<IdentityUser> signInManager)
		{
			this.signInManager = signInManager;
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (ModelState.IsValid)
			{
				var result = await signInManager.PasswordSignInAsync(Login.Email, Login.Password,Login.RememberME , false);

				if (result.Succeeded)
				{
					// Redirect to the appropriate page after successful login
					return RedirectToPage("/Index");
				}

				ModelState.AddModelError("", "Invalid login attempt");
			}

			return Page();
		}
	}
}
