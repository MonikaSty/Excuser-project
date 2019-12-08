using WebApplication1.Models;

namespace WebApplication1.Service
{
	public interface IExcuseService
	{
		ExcuseResponse GetMatchingExcuseOrDefault(ExcuseRequest request);
	}
}