using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Service
{
	public interface ICategoryService
	{
		IEnumerable<Category> GetAllCategories();
		IEnumerable<Subcategory> GetAllSubcategories(int categroyId);
		string GetCatgoryName(int id);
	}
}