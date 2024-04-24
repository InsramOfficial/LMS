using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("scheme")]
	public class View_1_Scheme
	{
		[Key]
		public int id { get; set; }
		public string ?DName { get; set; }
		public string semester_calender { get; set; }
		public string University_name { get; set; }
		public string Name { get; set; }
		public string Cou_Name { get; set; }
	}
}
