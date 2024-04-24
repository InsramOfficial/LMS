using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.program
{
	public class IndexModel : PageModel
	{
		public List<pro> companies1 { get; set; }
		public List<Faculty> f { get; set; }
		public List<University> u { get; set; }
		public List<Departemement> d { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.program.ToList();
			d = db.departements.ToList();
			f = db.faculies.ToList();
			u = db.universities.ToList();
		}


		public IActionResult OnPostCreate(string Name, int Faulty_id, int university_id,int dep_id)
		{
			var U = new pro
			{
				Name=Name,
				Faulty_id= Faulty_id,
				dep_id = dep_id,
				university_id = university_id,


			};

			db.program.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.program.Find(id);
			db.program.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.program.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Name, int Faulty_id, int university_id, int dep_id)
		{
			var company1 = db.program.Find(id);
			company1.Name = Name;
			company1.Faulty_id = Faulty_id;
			company1.university_id = university_id;
			company1.dep_id = dep_id;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
