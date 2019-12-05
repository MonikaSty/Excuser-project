using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Service
{ 
	public class KeywordService : IKeywordService
	{
		private readonly IStorageService _storageService; 
				public KeywordService(IStorageService storageService)
		{
			_storageService = storageService; 
		}
		
		public IEnumerable<Keyword> GetAllKeywords()
		{
			return _storageService.GetAllKeywords();
		}
	}
}