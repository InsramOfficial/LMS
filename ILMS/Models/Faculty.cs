using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Routing;

namespace ILMS.Models
{
	[Table("faculty")]
	public class Faculty
	{
		[Key]
		public int id { get; set; }
		public string  Faculty_Type { get; set; }
		public string Description { get; set; }
		public string status { get; set; }
		//public DateTime created_on { get; set; }
		//public DateTime updated_on { get; set; }
	}
}
