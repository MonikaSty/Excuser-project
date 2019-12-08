using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.DbContext;
using WebApplication1.Service;

namespace WebApplication1
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvcCore().AddRazorViewEngine().AddJsonFormatters();
			services.AddScoped<IKeywordService, KeywordService>();
			services.AddScoped<IExcuseService, ExcuseService>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IStorageService, StorageService>();
			services.AddScoped<ExcuserContex>();
			services.AddDbContext<ExcuserContex>(options =>
				options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ExcuserContext;Trusted_Connection=True;MultipleActiveResultSets=true"));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseMvcWithDefaultRoute();

		}
	}
}
