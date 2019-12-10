using System;
using System.Collections.Generic;
using System.Dynamic;
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
		
		public IActionResult Index(int categoryId = 4)
		{
			ViewBag.Subcategories = _categoryService.GetAllSubcategories(categoryId).ToList();
			ViewBag.Keywords = _keywordService.GetAllKeywords().ToList();
			ViewBag.Tones = Enum.GetNames(typeof(Tone)).ToList();
			ViewBag.CategoryName = _categoryService.GetCatgoryName(categoryId);
			return View();
		}

		[HttpPost]
		public IActionResult PostForm(ExcuseRequest request)
		{
			//if (!ModelState.IsValid)
			//	return new StatusCodeResult(500);

			var response = _excuseService.GetMatchingExcuseOrDefault(request);
			return View("ExcuseResponseView", response);
		}
	}
}