using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContext;
using WebApplication1.Models;

namespace WebApplication1.Service
{
	public class StorageService : IStorageService
	{
		private readonly ExcuserContex _dbContext; 
		public StorageService(ExcuserContex dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<Keyword> GetAllKeywords()
		{
			return _dbContext.Keywords;
		}
		public IEnumerable<Category> GetAllCategories()
		{
			return _dbContext.Categories;
		}		
		public IEnumerable<Subcategory> GetAllSubcategories()
		{
			return _dbContext.Subcategories;
		}
		public IEnumerable<Subcategory> GetAllSubcategories(int categoryId)
		{
			return _dbContext.Subcategories.Where(x =>  x.CategoryId == categoryId);
		}		

	}
}