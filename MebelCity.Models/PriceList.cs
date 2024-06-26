using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models
{
    public class PriceList
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
