using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ILMS.Models
{
	
	public class Signup
	{
		
		[Required]
		[DataType(DataType.EmailAddress)]

		public string ? Email { get; set; }
		[DataType(DataType.Password)]
		public string ?Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage="Password and Confirm Password Did not Match ")]
		public string Confirm_Password { get; set; }

	}
}
