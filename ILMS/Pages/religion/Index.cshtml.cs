using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.religion
{
	public class IndexModel : PageModel
	{
		public List<Religion> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.religions.ToList();
		}


		public IActionResult OnPostCreate(string Name)
		{
			var U = new Religion
			{
				Name = Name,
			};

			db.religions.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.religions.Find(id);
			db.religions.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.religions.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Name)
		{
			var company1 = db.religions.Find(id);
			company1.Name = Name;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
