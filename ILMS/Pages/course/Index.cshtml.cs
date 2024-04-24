using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.course
{
	public class IndexModel : PageModel
	{
		public List<Course> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.courses.ToList();
		}


		public IActionResult OnPostCreate(string Cou_Name, string Description, string Abstract, string Bilography)
		{
			var U = new Course
			{
				Cou_Name = Cou_Name,
				Description = Description,
				Abstract = Abstract,
				Bilography = Bilography,
			};

			db.courses.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.courses.Find(id);
			db.courses.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.courses.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Cou_Name, string Description, string Abstract, string Bilography)
		{
			var company1 = db.courses.Find(id);
			company1.Cou_Name = Cou_Name;
			company1.Description = Description;
			company1.Abstract = Abstract;
			company1.Bilography = Bilography;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
