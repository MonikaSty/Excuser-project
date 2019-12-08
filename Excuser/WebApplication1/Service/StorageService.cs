using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authentication;
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

		public Excuse GetExcuseForParameters(ExcuseRequest request)
		{
			var excuses = _dbContext.Excuses
				.Include(x => x.ExcuseKeywords)
				.ThenInclude(x => x.Keyword)
				.Where(x => x.SubcategoryId == request.SubcategoryId)
				.Where(x => x.Tone == request.Tone)
				.Where(x => !request.ExcludedExcuseIds.Contains(x.Id));

				//Based on keyword-matches find the best fitting excuse. If excuses share the same score pick a random one.
				excuses = excuses.OrderByDescending(x=> x.ExcuseKeywords.Count(y=>request.KeywordIds.Contains(y.Keyword.Id)))
				.ThenBy(x=>Guid.NewGuid());  

			return excuses.FirstOrDefault();
		}
	}
}