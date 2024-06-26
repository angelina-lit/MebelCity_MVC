using MebelCity.Models;
using Microsoft.AspNetCore.Mvc;
using MebelCity.DataAccess.Data;

namespace MebelCityWeb.Controllers
{
	public class PriceListController : Controller
	{
		private readonly ApplicationDbContext _db;

        public PriceListController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
		{
			List<PriceList> obgPriceList = _db.PriceLists.ToList();
			return View();
		}
	}
}
