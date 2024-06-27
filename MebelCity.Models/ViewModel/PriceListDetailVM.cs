using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models.ViewModel
{
	public class PriceListDetailVM
	{
		public int Id { get; set; }
		[Required]
		public PriceList PriceList { get; set; }

		public Column Column { get; set; }
	}
}
