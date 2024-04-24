using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.city
{
    public class IndexModel : PageModel
	{
		public List<City> companies1 { get; set; }
		
		private readonly DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}

		public void OnGet()
		{
			companies1 = db.cities.ToList();
			

		}


		public IActionResult OnPostCreate( string CName)
		{
			var company = new City
			{

				City_Name = CName,
			};

			db.cities.Add(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.cities.Find(id);
			db.	cities.Remove(company);

			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.cities.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string CName)
		{
			var company1 = db.cities.Find(id);
			
			company1.City_Name = CName;
			db.SaveChanges();
			return RedirectToPage("Index");
		}
	}
}
