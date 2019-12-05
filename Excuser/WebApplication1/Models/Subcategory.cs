namespace WebApplication1.Models
{
	public class Subcategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }
	}
}