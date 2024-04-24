using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("class")]
	public class Class
	{
		[Key]
		public int id { get; set; }
		public string class_title { get; set; }

		//public string start_time { get; set; }
		//public string end_time { get; set; }


	}
}
