using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("Attendence")]
	public class Attendence
	{
		[Key]
		public int id { get; set; }
		public string ?time_arrive{ get; set; }
		public string ?time_leave{ get; set; }
	}
}
