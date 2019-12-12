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
		[Route("/CustomizeForm/PostForm/")]
		[HttpPost]
		public IActionResult PostForm(ExcuseRequest request)
		{
			var excuse = _excuseService.GetMatchingExcuseOrDefault(request);
			ViewBag.Id = excuse.Id;
			ViewBag.Name = excuse.Name;
			ViewBag.Body = excuse.Body;
			return View("ExcuseResponseView");
		}

		[Route("/CustomizeForm/GenerateForm/")]
		[HttpPost]
		public IActionResult GenerateForm([FromBody] ExcuseRequest request)
		{	
			var excuse = _excuseService.GetMatchingExcuseOrDefault(request);
			ViewBag.Id = excuse.Id;
			ViewBag.Name = excuse.Name;
			ViewBag.Body = excuse.Body;
			return View("ExcuseResponseView");
		}
	}
}