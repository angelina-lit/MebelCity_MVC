using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models
{
    public class PriceList
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Это поле является обязательным к заполнению.")]
		[MaxLength(40)]
		[DisplayName("Название прайс-листа")]
        public string Name { get; set; }

        public List<Column> Columns { get; set; }
    }
}
