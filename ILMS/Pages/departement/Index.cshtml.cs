using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.departement
{
	public class IndexModel : PageModel
	{
		public List<Departemement> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.departements.ToList();
		}


		public IActionResult OnPostCreate(string DName, string location, string status, string Official_number, string Description,string Created_by)
		{
			var U = new Departemement
			{
				DName = DName,
				Official_number=Official_number,
				status = status,
				location = location,
				Description = Description,
				Created_by=Created_by,

			};

			db.departements.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.departements.Find(id);
			db.departements.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.departements.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string DName, string location, string status, string Official_number, string Description,string Created_by)
		{
			var company1 = db.departements.Find(id);
			company1.location = location;
			company1.status = status;
			company1.DName = DName;
			company1.Official_number = Official_number;
			company1.Description = Description;
			company1.Created_by = Created_by;

			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
