using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Code { get; set; }

		public List<ProductColumnValue> ColumnValues { get; set; }
	}
}
