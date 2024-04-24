using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.classe
{
	public class IndexModel : PageModel
	{
		public List<Class> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.classes.ToList();
		}


		public IActionResult OnPostCreate(string class_title)
		{
			var U = new Class
			{
				class_title = class_title,
			};

			db.classes.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.classes.Find(id);
			db.classes.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.classes.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string class_title)
		{
			var company1 = db.classes.Find(id);
			company1.class_title = class_title;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
