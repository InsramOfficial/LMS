using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.employee
{
	public class IndexModel : PageModel
	{
		public List<Employee> companies1 { get; set; }
		public List<Departemement> d { get; set; }
		public List<Designation> D { get; set; }
		public List<Country> c { get; set; }
		public List<Faculty> f { get; set; }
		public List<Religion> r { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.employees.ToList();
			d = db.departements.ToList();
			D = db.designations.ToList();
			c = db.countries.ToList();
			r = db.religions.ToList();
			f = db.faculies.ToList();
		}


		public IActionResult OnPostCreate(int Country_id,int designation_id,int dep_id,string Name, string Father_Name, string Email, string Other_Email,int Religion_id, string Gender,int  Cnic, string Date_of_Birth,
			string Mobile_Number, string Other_Mobile_Number,string specialization,
			string experience, string marital_status, string domicile_district,string blood_group,string Nationality,string Passport_Number,string additional_information,int Faculty_Type)
		{
			var U = new Employee
			{
				Name = Name,
				Country_id = Country_id,
				designation_id = designation_id,
				dep_id = dep_id,
				Father_Name = Father_Name,
				Email = Email,
				Other_Email = Other_Email,
				Religion_id = Religion_id,
				Gender = Gender,
				Cnic = Cnic,
				Date_of_Birth = Date_of_Birth,
				Mobile_Number = Mobile_Number,
				Other_Mobile_Number = Other_Mobile_Number,
				specialization = specialization,
				experience = experience,
				marital_status = marital_status,
				domicile_district = blood_group,
				Nationality = Nationality,
				Passport_Number = Passport_Number,
				blood_group = blood_group,
				additional_information = additional_information,
				Faculty_Type= Faculty_Type,


			};

			db.employees.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.employees.Find(id);
			db.employees.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.employees.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate(int id,int Country_id, int designation_id, int dep_id, string Name, string Father_Name, string Email, string Other_Email, int Religion_id, string Gender, int Cnic, string Date_of_Birth,
			string Mobile_Number, string Other_Mobile_Number, string specialization,
			string experience, string marital_status, string domicile_district, string blood_group, string Nationality, string Passport_Number, string additional_information,int Faculty_Type)
		{
			var company1 = db.employees.Find(id);
			company1.Country_id = Country_id;
			company1.designation_id = designation_id;
			company1.Name = Name;
			company1.dep_id = dep_id;
			company1.Father_Name = Father_Name;
			company1.Email = Email;
			company1.Other_Email = Other_Email;
			company1.Religion_id = Religion_id;
			company1.Gender = Gender;
			company1.Cnic = Cnic;
			company1.Date_of_Birth = Date_of_Birth;
			company1.Mobile_Number = Mobile_Number;
			company1.Other_Mobile_Number = Other_Mobile_Number;
			company1.specialization = specialization;
			company1.experience = experience;
			company1.marital_status = marital_status;
			company1.domicile_district = domicile_district;
			company1.blood_group = blood_group;
			company1.Nationality = Nationality;
			company1.Passport_Number = Passport_Number;
			company1.additional_information = additional_information;
			company1.Faculty_Type = Faculty_Type;

			db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
