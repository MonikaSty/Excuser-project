using System;

namespace WebApplication1.Infrastructure.ExcuseExtensions
{
	public static class Extensions
	{
		public static string AddName(this string excuseBody, string name = "")
		{
			if (!string.IsNullOrEmpty(name))
				name = " " + name;

			return excuseBody.Replace("%name%", name);
		}
	}
}