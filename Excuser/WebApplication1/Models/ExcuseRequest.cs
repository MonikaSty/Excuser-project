using System.Collections.Generic;
using WebApplication1.Infrastrcuture.Utils;

namespace WebApplication1.Models
{
	public class ExcuseRequest
	{
		//Validation
		public int SubcategoryId { get; set; }
		public List<int> ExcludedExcuseIds { get; set; }
		public string Name { get; set; }
		public Tone Tone { get; set; }
		public List<int> KeywordIds { get; set; }
	}
}