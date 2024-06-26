using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
