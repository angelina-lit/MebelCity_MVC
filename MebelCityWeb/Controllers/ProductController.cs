using MebelCity.Models;
using Microsoft.AspNetCore.Mvc;
using MebelCity.DataAccess.Data;

namespace MebelCityWeb.Controllers
{
	public class ProductController : Controller
	{
		private readonly ApplicationDbContext _db;

		public ProductController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			List<Product> objProduct = _db.Products.ToList();
			return View(objProduct);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Product obj)
		{
			if (ModelState.IsValid)
			{
				_db.Products.Add(obj);
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
		public IActionResult Edit(Product obj)
		{
			if (ModelState.IsValid)
			{
				_db.Products.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
