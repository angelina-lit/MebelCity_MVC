using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models.ViewModel
{
    public class PriceListVM
    {
        [Required]
        public string Name { get; set; }
        public ColumnVM[]? Columns { get; set; }
    }
}
