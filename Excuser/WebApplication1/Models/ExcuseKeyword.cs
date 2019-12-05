namespace WebApplication1.Models
{
	public class ExcuseKeyword
	{
		public int ExcuseId { get; set; }
		public Excuse Excuse { get; set; }
		public int KeywordId { get; set; }
		public Keyword Keyword { get; set; }
	}
}
