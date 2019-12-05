using System.Collections.Generic;
using WebApplication1.Infrastrcuture.Utils;

namespace WebApplication1.Models
{
	public class ExcuseRequest
	{
		//Validation
		public Subcategory Subcategory { get; set; }
		public string Name { get; set; }
		public Tone Tone { get; set; }
		public List<Keyword> Keywords { get; set; }
	}
}