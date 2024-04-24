using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.attendence
{
	public class IndexModel : PageModel
	{
		public List<Attendence> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.attendences.ToList();
		}


		public IActionResult OnPostCreate(string time_leave, string time_arrive)
		{
			var U = new Attendence
			{
				time_arrive = time_arrive,
				time_leave = time_leave,
				
			};

			db.attendences.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.attendences.Find(id);
			db.attendences.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.attendences.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string time_leave, string time_arrive)
		{
			var company1 = db.attendences.Find(id);
			company1.time_arrive = time_arrive;
			company1.time_leave = time_leave;
			
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
