using MebelCity.Models;
using Microsoft.AspNetCore.Mvc;
using MebelCity.DataAccess.Data;
using MebelCity.Models.ViewModel;
using MebelCity.Models.Enums;

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
			PriceListDetailVM model = new PriceListDetailVM();
			model.Column = new List<Column>()
			{
				new Column() { Id = 1, Name = "Наименование товара", TypeOfContent = ColumnType.Line},
				new Column() { Id = 2, Name = "Код товара", TypeOfContent = ColumnType.Number}
			};
			
			return View(model);
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