using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ILMS.Models
{
	[Table("subject")]
	public class Subject
	{
		[Key]
		public int id { get; set; }
		public string Name { get; set; }
		public string lab_hrs { get; set; }
		public string lec_hrs { get; set; }
		public string credit_hrs { get; set; }
		public string Marks { get; set; }
		public int Course_id { get; set; }
	}
}
