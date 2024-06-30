using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelCity.Models
{
	public class PriceListDetail
	{
		public PriceList PriceList { get; set; }
		public List<Product> Products { get; set; }
	}
}
