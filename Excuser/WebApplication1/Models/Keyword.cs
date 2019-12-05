using System.Collections.Generic;

namespace WebApplication1.Models
{
	public class Keyword
	{
		public int Id { get; set; }
		public string Value { get; set; }
		public IList<ExcuseKeyword> ExcuseKeywords { get; set; }
	}
}