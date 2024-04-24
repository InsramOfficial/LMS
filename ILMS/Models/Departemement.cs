using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("departement")]
	public class Departemement
	{
		[Key]
		public int id { get; set; }
		public string DName { get; set; }
		public string location { get; set; }
		public string Official_number { get; set; }
		public string Description { get; set; }
		public string status { get; set; }
		public string Created_by { get; set; }
	}
}
