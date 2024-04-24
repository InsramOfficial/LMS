using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("program")]
	public class pro
	{
		[Key]
		public int id { get; set; }
		public string? Name { get; set; }
		public int Faulty_id { get; set; }
		public int dep_id { get; set; }
		public int university_id { get; set; }
	}
}
