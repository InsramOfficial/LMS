using System.Data;
using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Net.WebSockets;

namespace ILMS.Pages.Singin_page
{
	public class SignupModel : PageModel
	{
		private readonly UserManager<IdentityUser> userManager;


		public SignInManager<IdentityUser> SignInManager { get; set; }
		private readonly SignInManager<IdentityUser> signInManager;



		[BindProperty]
		public Signup Model { get; set; }
		[BindProperty]
		public Login Login { get; set; }
		public SignupModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			this.userManager = userManager;
			this.SignInManager = signInManager;
		}

		public async Task<IActionResult> OnPostAsync()
		{
			if (ModelState.IsValid)
			{
				var user = new IdentityUser()
				{
					UserName = Model.Email,
					Email = Model.Email

				};
				var result = await userManager.CreateAsync(user, Model.Password);
				if (result.Succeeded)
				{
					await SignInManager.SignInAsync(user, false);
					return RedirectToPage("/Index");
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
			}
			return Page();
		}


		//public async Task<IActionResult> OnPostLoginAsync()
		//{
		//	if (ModelState.IsValid)
		//	{
		//		var result = await signInManager.PasswordSignInAsync(Login.Email, Login.Password, false, false);

		//		if (result.Succeeded)
		//		{
		//			// Redirect to the appropriate page after successful login
		//			return RedirectToPage("/Index");
		//		}

		//		ModelState.AddModelError("", "Invalid login attempt");
		//	}

		//	return Page();
		//}

		//public async Task<IActionResult> OnPostLoginAsync(string returnUrl = null)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		var identityresult = await SignInManager.PasswordSignInAsync(Login.Email, Login.Password, false);
		//		if (identityresult.Succeeded)
		//		{
		//			if (returnUrl == null || returnUrl == "/")
		//			{
		//				return RedirectToPage("Index");
		//			}
		//		}
		//		else
		//		{
		//			return RedirectToPage(returnUrl);
		//		}
		//		ModelState.AddModelError("", "Username or Password incorrect");
		//	}
		//	return Page();
		//}


	}
}

//		public Signup Signup { get; set; }

//		var user = await _userManager.FindByNameAsync(Login_Form.Email);

//			if (user != null && await _userManager.CheckPasswordAsync(user, Login_Form.Password))
//			{
//				await _signInManager.SignInAsync(user, false);

//				return RedirectToPage("Index");
//	}

//	ModelState.AddModelError(string.Empty, "Invalid username or password");

//			return Page();

//	//public class LoginModel : PageModel
//	//	{
//	//		private readonly SignInManager<IdentityUser> _signInManager;

//	//		public LoginModel(SignInManager<IdentityUser> signInManager)
//	//		{
//	//			_signInManager = signInManager;
//	//		}

//	//		[BindProperty]
//	//		public InputModel Input { get; set; }

//	//		public string ErrorMessage { get; set; }

//	//		public class InputModel
//	//		{
//	//			[Required]
//	//			[EmailAddress]
//	//			public string Email { get; set; }

//	//			[Required]
//	//			[DataType(DataType.Password)]
//	//			public string Password { get; set; }
//	//		}

//	//		public void OnGet()
//	//		{
//	//		}

//	//		public async Task<IActionResult> OnPostAsync(string returnUrl = null)
//	//		{
//	//			returnUrl ??= Url.Content("~/");

//	//			if (ModelState.IsValid)
//	//			{
//	//				var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, lockoutOnFailure: false);
//	//				if (result.Succeeded)
//	//				{
//	//					return LocalRedirect(returnUrl);
//	//				}
//	//				else
//	//				{
//	//					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
//	//					ErrorMessage = "Invalid login attempt.";
//	//					return Page();
//	//				}
//	//			}

//	//			return Page();
//	//		}
//	//	}



