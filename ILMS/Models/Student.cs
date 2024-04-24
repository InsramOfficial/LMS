using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("student")]
	public class Student
	{
		[Key]
		public int id { get; set; }
		public string? Form_number { get; set; }
		public string? Father_Name { get; set; }
		public string? Name { get; set; }
		public string? Registration_number { get; set; }
		public string? Roll_number { get; set; }
		public string? Email { get; set; }
		public string? Other_Email { get; set; }
		public string? Gender { get; set; }
		public string? domicile_district { get; set; }
		public string? Nationality { get; set; }
		public string? stu_Cnic { get; set; }
		public int Religion_id { get; set; }
		public string? Fa_Cnic { get; set; }
		public string? Date_of_Birth { get; set; }
		public string? Mobile_Number { get; set; }
		public string? Other_Mobile_Number { get; set; }
		public string? blood_group { get; set; }
		public string? marital_status { get; set; }
		public string? Hostal { get; set; }
		public string? Gardian_name { get; set; }
		public int Gardian_Cnic { get; set; }
		public int Gardian_number { get; set; }
		public string? Guardian_Address { get; set; }
		public int Session { get; set; }
		public int Country_id { get; set; }
		public int dep_id { get; set; }
		public int scheme_of_study { get; set; }
		public string? additional_information { get; set; }
		public string? Matric_school_name { get; set; }
		public int Matric_marks { get; set; }
		public string ?clg_name { get; set; }
		public int Intermediate_marks { get; set; }
		public string? Description { get; set; }
		public string ?Status { get; set; }
		public int Program_id { get; set; }
		

    }
}
