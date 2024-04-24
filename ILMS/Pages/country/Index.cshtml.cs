using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.country
{
	public class IndexModel : PageModel
	{
		public List<Country> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.countries.ToList();
		}


		public IActionResult OnPostCreate(string Name)
		{
			var U = new Country
			{
				Name = Name,
				
			};

			db.countries.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.countries.Find(id);
			db.countries.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.countries.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Name)
		{
			var company1 = db.countries.Find(id);
			company1.Name = Name;
			
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
