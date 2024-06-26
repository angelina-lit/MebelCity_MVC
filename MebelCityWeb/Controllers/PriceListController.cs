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
			List<PriceList> objPriceList = _db.PriceLists.ToList();
			return View(objPriceList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(PriceList obj)
		{
			if (ModelState.IsValid)
			{
				_db.PriceLists.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Edit(PriceList obj)
		{
			if (ModelState.IsValid)
			{
				_db.PriceLists.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
