using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelCity.Models
{
	public class Column
	{
		[Required(ErrorMessage = "Это поле является обязательным к заполнению.")]
		[MaxLength(40)]
		[DisplayName("Наименование колонки")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Это поле является обязательным к заполнению.")]
		[DisplayName("Тип содержимого колонки")]
		public string TypeOfContent { get; set; }
	}
}
