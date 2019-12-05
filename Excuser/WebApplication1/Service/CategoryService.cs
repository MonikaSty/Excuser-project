using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Service
{
	public class CategoryService : ICategoryService
	{
		private readonly IStorageService _storageService;

		public CategoryService(IStorageService storageService)
		{
			_storageService = storageService;
		}

		public IEnumerable<Category> GetAllCategories()
		{
			return _storageService.GetAllCategories(); 
		}

		public IEnumerable<Subcategory> GetAllSubcategories(int categoryId)
		{
			return _storageService.GetAllSubcategories(categoryId);
		}
	}
}