using System.ComponentModel.DataAnnotations;

namespace MebelCity.Models.ViewModel
{
    public class ColumnVM
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string TypeOfContent { get; set; }
    }
}
