using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICategoryService _categoryService;

		public HomeController(ICategoryService categoryService)
		{
			_categoryService = categoryService; 
		}
		public IActionResult Index()
		{
			var categories = _categoryService.GetAllCategories();
			return View(categories);
		}
	}
}