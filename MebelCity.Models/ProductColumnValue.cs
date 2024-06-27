using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models
{
	public class ProductColumnValue
	{
		public int Id { get; set; }
		[Required]
		public int ColumnId { get; set; }
		[Required]
		public string Value { get; set; }
		[Required]
		public int ProductId { get; set; }
	}
}
