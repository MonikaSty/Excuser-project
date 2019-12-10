using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Infrastrcuture.Utils;

namespace WebApplication1.Models
{
	public class ExcuseRequest
	{
		[Required]
		public int SubcategoryId { get; set; }
		public List<int> ExcludedExcuseIds { get; set; } = new List<int>();
		[StringLength(15, ErrorMessage = "Name length can't be more than 15 characters.")]
		public string Name { get; set; }
		[Required]
		public Tone Tone { get; set; }
		public List<int> KeywordIds { get; set; }
	}
}