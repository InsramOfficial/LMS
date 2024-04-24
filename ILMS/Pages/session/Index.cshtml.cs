using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.session
{
	public class IndexModel : PageModel
	{
		public List<Session> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.sessions.ToList();
		}


		public IActionResult OnPostCreate(string Number_of_Semester, string lab_hrs, string lec_hrs, string credit_hrs, string semester_calender, string number_of_books)
		{
			var U = new Session
			{
				Number_of_Semester = Number_of_Semester,
				lab_hrs = lab_hrs,
				lec_hrs = lec_hrs,
				credit_hrs = credit_hrs,
				number_of_books = number_of_books,
				semester_calender = semester_calender,
			};

			db.sessions.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.sessions.Find(id);
			db.sessions.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.sessions.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Number_of_Semester, string lab_hrs, string lec_hrs, string credit_hrs, string semester_calender, string number_of_books)
		{
			var company1 = db.sessions.Find(id);
			company1.Number_of_Semester = Number_of_Semester;
			company1.lab_hrs = lab_hrs;
			company1.lec_hrs = lec_hrs;
			company1.credit_hrs = credit_hrs; 
			company1.semester_calender = semester_calender; 
			company1.number_of_books = number_of_books;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
