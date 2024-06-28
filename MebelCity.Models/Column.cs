using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using MebelCity.Models.Enums;

namespace MebelCity.Models
{
	public class Column
	{
		public int Id { get; set; }
		public string Name { get; set; }
		//public string TypeOfContent { get; set; }
		public ColumnType TypeOfContent { get; set; }

        public List<PriceList> PriceLists { get; set; }

        /*public PriceList PriceList { get; set; }
        public int PriceListId { get; set; }*/
    }
}
