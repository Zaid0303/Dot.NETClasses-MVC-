using System.ComponentModel.DataAnnotations;

namespace classes.net.Models
{
	public class StudentClass
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Please enter Name")]
		[StringLength(100)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter Gender")]
		[StringLength(100)]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Please enter Date of Birth")]
		[Display(Name = "Date of Birth")]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		[Required(ErrorMessage = "Please enter Batch Time")]
		[Display(Name = "Batch Time")]
		[DataType(DataType.Time)]
		public DateTime BatchTime { get; set; }

		[Required(ErrorMessage = "Please enter Phone No.")]
		[Display(Name = "Phone No.")]
		[Phone]
		public string PhoneNumber { get; set; }


	}
}
