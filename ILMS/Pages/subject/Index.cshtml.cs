using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.subject
{
	public class IndexModel : PageModel
	{
		public List<Subject> companies1 { get; set; }
		public List<Course> C { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.subjects.ToList();
			C = db.courses.ToList();
		}


		public IActionResult OnPostCreate(string Name, string lab_hrs, string lec_hrs, string credit_hrs,string Marks,int Course_id)
		{
			var U = new Subject
			{
				Name = Name,
				lab_hrs = lab_hrs,
				lec_hrs = lec_hrs,
				credit_hrs = credit_hrs,
				Marks = Marks,
				Course_id= Course_id,
			};

			db.subjects.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.subjects.Find(id);
			db.subjects.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.subjects.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Name, string lab_hrs, string lec_hrs, string credit_hrs, string Marks, int Course_id)
		{
			var company1 = db.subjects.Find(id);
			company1.Name = Name;
			company1.lab_hrs = lab_hrs;
			company1.lec_hrs =	lec_hrs;
			company1.credit_hrs = credit_hrs;
			company1.Marks = Marks;
			company1.Course_id = Course_id;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
