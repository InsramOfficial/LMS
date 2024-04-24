using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("courses")]
	public class Course
	{
		[Key]
		public int id { get; set; }
		public string? Cou_Name { get; set; }
		public string ?Description { get; set; }
		public string ?Abstract { get; set; }
		public string ?Bilography { get; set; }
	}
}
