using System.Runtime.CompilerServices;
using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.exam
{
	public class IndexModel : PageModel
	{
		public List<Exam> companies1 { get; set; }
		public List<Subject> S { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.exams.ToList();
			S = db.subjects.ToList();
		}


		public IActionResult OnPostCreate(string Exam_date, string Exam_time, string Agenda, string Notified,string Repeat,string Exam_time_end,int Subject_id, string Exam_type)
		{
			var U = new Exam
			{
				Exam_date = Exam_date,
				Exam_time = Exam_time,
				Agenda = Agenda,
				Notified = Notified,
				Repeat = Repeat,
				Exam_time_end = Exam_time_end,
				Subject_id = Subject_id,
				Exam_type=Exam_type,
			};

			db.exams.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.exams.Find(id);
			db.exams.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.exams.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string Exam_date, string Exam_time, string Agenda, string Notified, string Repeat, string Exam_time_end, int Subject_id, string Exam_type)
		{
			var company1 = db.exams.Find(id);
			company1.Exam_date = Exam_date;
			company1.Exam_time = Exam_time;
			company1.Agenda = Agenda;
			company1.Notified = Notified;
			company1.Repeat = Repeat;
			company1.Subject_id = Subject_id;
			company1.Exam_time_end = Exam_time_end;
			company1.Exam_type= Exam_type;
			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
