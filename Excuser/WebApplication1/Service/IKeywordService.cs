using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Service
{
	public interface IKeywordService
	{
		 IEnumerable<Keyword> GetAllKeywords(); 
	}
}