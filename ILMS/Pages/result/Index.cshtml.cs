using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.result
{
	public class IndexModel : PageModel
	{
		public List<Result> companies1 { get; set; }
		public List<Subject> S { get; set; }
		public List<Exam> E { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.results.ToList();
			E = db.exams.ToList();
			S = db.subjects.ToList();
		}


		public IActionResult OnPostCreate(string maximum_marks, string marks_obtained, string status, string percentage, string grade, string GPA, string CGPA,int Exam_id,int Subject_id)
		{
			var U = new Result
			{
				maximum_marks = maximum_marks,
				marks_obtained = marks_obtained,
				status = status,
				percentage = percentage,
				grade = grade,
				GPA = GPA,
				CGPA = CGPA,
				Exam_id=Exam_id,
				Subject_id= Subject_id,
			};

			db.results.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.results.Find(id);
			db.results.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.results.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string maximum_marks, string marks_obtained, string status, string percentage, string grade, string GPA, string CGPA, int Exam_id, int Subject_id)
		{
			var company1 = db.results.Find(id);
			company1.maximum_marks = maximum_marks;
			company1.marks_obtained = marks_obtained;
			company1.status = status;
			company1.percentage = percentage;
			company1.grade = grade;
			company1.GPA = GPA;
			company1.CGPA = CGPA;
			company1.Exam_id = Exam_id;
			company1.Subject_id = Subject_id;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
