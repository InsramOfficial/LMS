using ILMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ILMS.Pages.student
{
	public class IndexModel : PageModel
	{
		public List<Student> companies1 { get; set; }
		public List<Departemement> d { get; set; }
		public List<pro> P{ get; set; }
		public List<Scheme_of_Study> s { get; set; }
		public List<Country> c { get; set; }
		public List<Religion> r { get; set; }
		private DatabaseContext db;

		public IndexModel(DatabaseContext _db)
		{
			db = _db;
		}
		public void OnGet()
		{
			companies1 = db.students.ToList();
			d = db.departements.ToList();
			c = db.countries.ToList();
			r = db.religions.ToList();
			s = db.schemes.ToList();
			P = db.program.ToList();
        }


		public IActionResult OnPostCreate(int Country_id, int dep_id, string Name,
			string Father_Name, string Email, string Other_Email,
			int Religion_id, string Gender, string stu_Cnic,
			string Date_of_Birth,
			string Mobile_Number, string Other_Mobile_Number,
			 string marital_status, string domicile_district,
			 string blood_group, string Nationality, string additional_information, string Hostal
			,string Form_number, string Registration,string Roll_number,
			 string Fa_Cnic,string Gardian_name, int Gardian_Cnic, int Gardian_number,
			int Session,string Matric_school_name, int Matric_marks,string clg_name,
			int Intermediate_marks,string Status, int scheme_of_study,string Registration_number,string Description,string Guardian_Address,int Program_id)
		{
			var U = new Student
			{
				Name = Name,
				Country_id = Country_id,
				dep_id = dep_id,
				Father_Name = Father_Name,
				Email = Email,
				Other_Email = Other_Email,
				Religion_id = Religion_id,
				Gender = Gender,
				stu_Cnic = stu_Cnic,
				Date_of_Birth = Date_of_Birth,
				Mobile_Number = Mobile_Number,
				Other_Mobile_Number = Other_Mobile_Number,
				marital_status = marital_status,
				domicile_district = domicile_district,
				Nationality = Nationality,
				blood_group = blood_group,
				additional_information = additional_information,
				Hostal = Hostal,
				Form_number = Form_number,
				Registration_number = Registration_number,
				Roll_number = Roll_number,
				Fa_Cnic = Fa_Cnic,
				Gardian_name = Gardian_name,
				Guardian_Address= Guardian_Address,
				Session = Session,
				Matric_school_name = Matric_school_name,
				Matric_marks = Matric_marks,
				clg_name = clg_name,
				Intermediate_marks = Intermediate_marks,
				Gardian_Cnic = Gardian_Cnic,
				Gardian_number = Gardian_number,
				Status = Status,
				scheme_of_study = scheme_of_study,
				Description= Description,
                Program_id= Program_id,
				

            };

			db.students.Add(U);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnPostDelete(int id)
		{
			var company = db.students.Find(id);
			db.students.Remove(company);
			db.SaveChanges();
			return RedirectToPage("Index");
		}
		public IActionResult OnGetFind(int id)
		{
			var company = db.students.Find(id);
			return new JsonResult(company);
		}
		public IActionResult OnPostUpdate( int id , int Country_id, int dep_id, string Name,int Program_id,

            string Father_Name, string Email, string Other_Email,
			int Religion_id, string Gender, string stu_Cnic,
			string Date_of_Birth,
			string Mobile_Number, string Other_Mobile_Number,
			 string marital_status, string domicile_district,
			 string blood_group, string Nationality, string additional_information, string Hostal
			, string Form_number, string Registration, string Roll_number,
			 string Fa_Cnic, string Gardian_name, int Gardian_Cnic, int Gardian_number,
			int Session, string Matric_school_name, int Matric_marks, string clg_name,
			int Intermediate_marks, string Status, int scheme_of_study, string Registration_number, string Description, string Guardian_Address)
		{
			var company1 = db.students.Find(id);
			company1.Country_id = Country_id;
			company1.Name = Name;
			company1.dep_id = dep_id;
			company1.Father_Name = Father_Name;
			company1.Email = Email;
			company1.Other_Email = Other_Email;
			company1.Religion_id = Religion_id;
			company1.Gender = Gender;
			company1.stu_Cnic = stu_Cnic;
			company1.Date_of_Birth = Date_of_Birth;
			company1.Mobile_Number = Mobile_Number;
			company1.Other_Mobile_Number = Other_Mobile_Number;
			company1.marital_status = marital_status;
			company1.domicile_district = domicile_district;
			company1.blood_group = blood_group;
			company1.Nationality = Nationality;
			company1.Form_number = Form_number;
			company1.Registration_number = Registration_number;
			company1.Roll_number = Roll_number;
			company1.Fa_Cnic = Fa_Cnic;
			company1.Hostal = Hostal;
			company1.Gardian_name = Gardian_name;
			company1.Gardian_Cnic = Gardian_Cnic;
			company1.Gardian_number = Gardian_number;
			company1.Session = Session;
			company1.domicile_district = domicile_district;
			company1.Matric_school_name = Matric_school_name;
			company1.Matric_marks = Matric_marks;
			company1.clg_name = clg_name;
			company1.Intermediate_marks = Intermediate_marks;
			company1.Description = Description;
			company1.Status = Status;
			company1.Country_id = Country_id;
			company1.Nationality = Nationality;
			company1.scheme_of_study = scheme_of_study;
			company1.Program_id = Program_id;
			


            db.SaveChanges();
			return RedirectToPage("Index");
		}

	}
}
