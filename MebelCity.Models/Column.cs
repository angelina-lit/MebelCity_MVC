using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace MebelCity.Models
{
	public class Column
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Это поле является обязательным к заполнению.")]
		[MaxLength(40)]
		[DisplayName("Наименование колонки")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Это поле является обязательным к заполнению.")]
		[DisplayName("Тип содержимого колонки")]
		public string TypeOfContent { get; set; }
		public PriceList PriceList { get; set; }
        public int PriceListId { get; set; }
    }
}
