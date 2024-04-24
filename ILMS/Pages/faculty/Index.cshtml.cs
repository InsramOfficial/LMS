using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.faculty
{
	public class IndexModel : PageModel
	{
		public List<Faculty> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.faculies.ToList();
		}


		public IActionResult OnPostCreate(string Faculty_Type, string Description, string status)
		{
			var U = new Faculty
			{
				Faculty_Type = Faculty_Type,
				Description = Description,
				status = status,

			};

			db.faculies.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.faculies.Find(id);
			db.faculies.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.faculies.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Faculty_Type, string Description, string status)
		{
			var company1 = db.faculies.Find(id);
			company1.status = status;
			company1.Description = Description;
			company1.Faculty_Type = Faculty_Type;


			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
