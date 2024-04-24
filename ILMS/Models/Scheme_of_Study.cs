using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILMS.Models
{
	[Table("scheme of study")]
	public class Scheme_of_Study
	{
		[Key]
		public int id { get; set; }
		public int session { get; set; }
		public int university_id { get; set; }
		public int campus_id { get; set; }
		public int departement_id { get; set; }
		public int Course_id { get; set; }
	}
}
