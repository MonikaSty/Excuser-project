using System.Collections.Generic;
using WebApplication1.Infrastrcuture.Utils;

namespace WebApplication1.Models
{
	public class CustomizeFormRequest
	{
		public CustomizeFormRequest(string categoryName, List<Subcategory> subcategories, List<Keyword> keywords, List<string> tones)
		{
			CategoryName = categoryName;
			Subcategories = subcategories;
			Keywords = keywords;
			Tones = tones; 
		}
		public string CategoryName { get; set; }
		public List<Subcategory> Subcategories { get; set; }
		public List<Keyword> Keywords { get; set; }
		public List<string> Tones { get; set; }
	}
}