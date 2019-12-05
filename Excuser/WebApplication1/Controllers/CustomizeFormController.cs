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

		public CustomizeFormController(ICategoryService categoryService, IKeywordService keywordService)
		{
			_categoryService = categoryService;
			_keywordService = keywordService;
		}
		
		public IActionResult Index(int categoryId)
		{
			var subcategories = _categoryService.GetAllSubcategories(categoryId).ToList();
			var keywords = _keywordService.GetAllKeywords().ToList();
			var tones = Enum.GetNames(typeof(Tone)).ToList();
			return View(new CustomizeFormRequest(subcategories, keywords, tones));
		}

		//[HttpPost]
		//public IActionResult PostFrom(ExcuseRequest request)
		//{
		//	//GenerateExcuse()
		//	return View(result);
		//}


	}
}