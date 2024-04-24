using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ILMS.Models;

namespace ILMS.Models
{
	[Table("city")]
	public class City
	{
		[Key]
		public int id { get; set; }
		
		public string ? City_Name { get; set; }
	}
}
