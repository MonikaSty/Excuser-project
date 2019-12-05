using System.Collections.Generic;
using WebApplication1.Infrastrcuture.Utils;

namespace WebApplication1.Models
{
	public class Excuse
	{
		public int Id { get; set; }
		public string Body { get; set; }
		public Tone Tone { get; set; }
		public int SubcategoryId { get; set; }
		public Subcategory Subcategory { get; set; }
		public IList<ExcuseKeyword> ExcuseKeywords { get; set; }
	}
}