using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.scheme_of_study
{
	public class IndexModel : PageModel
	{
		public List<View_1_Scheme> companies1 { get; set; }
		public List<Session> s { get; set; }
		public List<University> u { get; set; }
		public List<Course> C { get; set; }
		public List<Campus> c { get; set; }
		public List<Departemement> d { get; set; }

		private readonly DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.view.ToList();
			c = db.campuses.ToList();
			d = db.departements.ToList();
			s = db.sessions.ToList();
			u = db.universities.ToList();
			C = db.courses.ToList();
		}


		public IActionResult OnPostCreate(int departement_id, int university_id, int session, int campus_id, int Course_id)
		{
			var U = new Scheme_of_Study
			{
				departement_id = departement_id,
				university_id = university_id,
				session = session,
				campus_id = campus_id,
				Course_id= Course_id,
			};

			db.schemes.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.schemes.Find(id);
			db.schemes.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.schemes.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, int departement_id, int university_id, int session, int campus_id, int Course_id)
		{
			var company1 = db.schemes.Find(id);
			company1.departement_id = departement_id;
			company1.university_id = university_id;
			company1.session = session;
			company1.campus_id = campus_id;
			company1.Course_id = Course_id;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
