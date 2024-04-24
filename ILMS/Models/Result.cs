using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{

	[Table("result")]
	public class Result
	{
		public int id { get; set; }
		public string maximum_marks { get; set; }
		public string marks_obtained { get; set; }
		public string grade { get; set; }
		public string percentage { get; set; }
		public string GPA { get; set; }
		public string CGPA { get; set; }
		public string status { get; set; }
		public int Subject_id { get; set; }
		public int Exam_id { get; set; }

	}
}
