using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastrcuture.Utils;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
	public class CustomizeFormController : Controller
	{
		private readonly ICategoryService _categoryService; 
		private readonly IKeywordService _keywordService;
		private readonly IExcuseService _excuseService;

		public CustomizeFormController(ICategoryService categoryService, IKeywordService keywordService, IExcuseService excuseService)
		{
			_categoryService = categoryService;
			_keywordService = keywordService;
			_excuseService = excuseService;
		}
		
		public IActionResult Index(int categoryId)
		{
			var subcategories = _categoryService.GetAllSubcategories(categoryId).ToList();
			var keywords = _keywordService.GetAllKeywords().ToList();
			var tones = Enum.GetNames(typeof(Tone)).ToList();
			return View(new CustomizeFormRequest(subcategories, keywords, tones));
		}

		[HttpPost]
		public IActionResult PostFrom([FromBody]ExcuseRequest request)
		{
			if(!ModelState.IsValid)
				return new StatusCodeResult(500);

			var response = _excuseService.GetMatchingExcuseOrDefault(request);
			return View("ExcuseResponseView", response);
		}
	}
}