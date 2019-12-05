namespace WebApplication1.Service
{
	public class ExcuseService : IExcuseService
	{
		private readonly IStorageService storageService;

		public ExcuseService(IStorageService storageService)
		{
			this.storageService = storageService;
		}
	}
}