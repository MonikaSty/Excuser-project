using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Service
{
	public interface IStorageService
	{
		IEnumerable<Keyword> GetAllKeywords();
		IEnumerable<Subcategory> GetAllSubcategories();
		IEnumerable<Subcategory> GetAllSubcategories(int categoryId);
		IEnumerable<Category> GetAllCategories();
		Excuse GetExcuseForParameters(ExcuseRequest request);
	}
}