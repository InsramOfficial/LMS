using System;
using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.university
{

	public class IndexModel : PageModel
	{
		public List<University> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.universities.ToList();
		}


		public IActionResult OnPostCreate(string University_name, string url, string location, string status)
		{
			var U = new University
			{
				University_name = University_name,
				URL = url,
				status=status,
				location=location,

			};

			db.universities.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.universities.Find(id);
			db.universities.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.universities.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string University_name, string url, string location, string status)
		{
			var company1 = db.universities.Find(id);
			company1.location = location;
			company1.status = status;
			company1.URL = url;
			company1.status = status;
			company1.University_name = University_name;

			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
