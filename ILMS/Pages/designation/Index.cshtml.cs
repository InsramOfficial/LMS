using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.designation
{
	public class IndexModel : PageModel
	{
		public List<Designation> companies1 { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.designations.ToList();
		}


		public IActionResult OnPostCreate(string name, string salary, string Duration, string description, string previous_job, string Created_by, string  commision, string hire_date )
		{
			var U = new Designation
			{
				Name = name,
				salary = salary,
				Duration = Duration,
				description = description,
				previous_job = previous_job,
				created_by = Created_by,
				hire_date= hire_date,
				commision = commision,

			};

			db.designations.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.designations.Find(id);
			db.designations.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.designations.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id, string name, string salary, string Duration, string description, string previous_job, string Created_by, string commision, string hire_date)
		{
			var company1 = db.designations.Find(id);
			company1.description = description;
			company1.Duration = Duration;
			company1.Name = name;
			company1.salary = salary;
			company1.previous_job = previous_job;
			company1.commision = commision;
			company1.hire_date = hire_date;
			company1.created_by = Created_by;

			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
