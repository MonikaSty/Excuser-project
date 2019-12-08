using System.Collections.Generic;
using WebApplication1.Infrastructure.ExcuseExtensions;
using WebApplication1.Models;

namespace WebApplication1.Service
{
	public class ExcuseService : IExcuseService
	{
		private readonly IStorageService _storageService;

		public ExcuseService(IStorageService storageService)
		{
			_storageService = storageService;
		}

		public ExcuseResponse GetMatchingExcuseOrDefault(ExcuseRequest request)
		{
			var excuse = _storageService.GetExcuseForParameters(request);
			return GenerateExcuseResponseOrDefault(excuse, request.Name);
		}

		private ExcuseResponse GenerateExcuseResponseOrDefault(Excuse excuse, string name)
		{
			var body = excuse?.Body.AddName(name) ??
			           "It look like there is no match for your searching! You just have to come up with an excuse yourself.";
			return new ExcuseResponse()
			{
				Id = excuse?.Id,
				Body = body,
				Name = name
			};
		}
	}
}