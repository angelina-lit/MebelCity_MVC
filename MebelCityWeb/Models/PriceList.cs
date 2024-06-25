using System.ComponentModel.DataAnnotations;

namespace MebelCityWeb.Models
{
	public class PriceList
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
