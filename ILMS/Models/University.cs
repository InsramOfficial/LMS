using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ILMS.Models
{
	[Table("university")]
	public class University
	{
		[Key]
		public int id { get; set; }
		public string? University_name { get; set; }
		public string ?URL { get; set; }
		public string ?location { get; set; }
		public string ?status { get; set; }
	}
}
