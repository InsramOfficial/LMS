using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ILMS.Models
{
	[Table("campus")]
	public class Campus
	{
		public int id { get; set; }
		public string Name { get; set; }
		public string status { get; set; }
		public string URL { get; set; }
		public string location { get; set; }
		public int Uni_id { get; set; }
		//public DateTime created_on { get; set; }
		//public DateTime updated_on { get; set; }
	}
}
