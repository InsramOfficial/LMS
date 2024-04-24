using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace ILMS.Models
{
	[Table("employee")]
	public class Employee
	{
		[Key]
		public int id { get; set; }
		public int Country_id { get; set; }
		public int designation_id { get; set; }
		public int dep_id { get; set; }
		public string  Name { get; set; }
		public string Father_Name { get; set; }
		public string Email { get; set; }
		public string Other_Email { get; set; }
		public int Religion_id { get; set; }
		public string Gender { get; set; }
		public int Cnic { get; set; }
		public string Date_of_Birth { get; set; }
		public string Mobile_Number { get; set; }
		public string Other_Mobile_Number { get; set; }
		public string specialization { get; set; }
		public string marital_status { get; set; }
		public string experience { get; set; }
		public string additional_information { get; set; }
		public string domicile_district { get; set; }
		public string blood_group { get; set; }
		public string Nationality { get; set; }
		public string Passport_Number { get; set; }
		public int Faculty_Type { get; set; }
	}
}
