using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("designation")]
	public class Designation
	{
		[Key]
		public int id { get; set; }
		public string Name { get; set; }
		public string salary { get; set; }
		public string Duration { get; set; }
		public string description { get; set; }
		public string previous_job { get; set; }
		public string hire_date { get; set; }
		public string commision { get; set; }
		public string created_by { get; set; }

	}
}
