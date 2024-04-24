using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.campus
{
	public class IndexModel : PageModel
	{
		public List<Campus> companies1 { get; set; }
		public List<University> u { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.campuses.ToList();
			u = db.universities.ToList();
		}


		public IActionResult OnPostCreate(string Name, string url, string location, string status,int Uni_id)
		{
			var U = new Campus
			{
				Name = Name,
				URL = url,
				status = status,
				location = location,
				Uni_id= Uni_id,

			};

			db.campuses.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.campuses.Find(id);
			db.campuses.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.campuses.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Name, string url, string location, string status,int Uni_id)
		{
			var company1 = db.campuses.Find(id);
			company1.Name = Name;
			company1.status = status;
			company1.URL = url;
			company1.location = location;
			company1.Uni_id = Uni_id;

			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
