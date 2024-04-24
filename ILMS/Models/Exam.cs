using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("exam")]
	public class Exam
	{
		public int id { get; set; }
		public string Exam_date { get; set; }
		public string Exam_time { get; set; }
		public string Agenda { get; set; }
		public string Notified { get; set; }
		public string Repeat { get; set; }
		public string Exam_time_end { get; set; }
		public int Subject_id { get; set; }
		public string Exam_type { get; set; }
	}
}
