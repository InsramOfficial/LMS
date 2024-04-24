using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("session")]
	public class Session
	{
		public int id { get; set; }
		public string Number_of_Semester { get; set; }
		public string semester_calender { get; set; }
		public string number_of_books { get; set; }
		public string lec_hrs { get; set; }
		public string lab_hrs { get; set; }
		public string credit_hrs { get; set; }

	}
}
