using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBCONTEXT;
using Microsoft.EntityFrameworkCore;
//using SistemaVenta.DAL.Interfaces;
//using SistemaVenta.DAL.Implementacion;
//using SistemaVenta.BLL.Interfaces;
//using SistemaVenta.BLL.Implementacion;


namespace SistemaVenta.IOC
{
	public static class Dependencia
	{

		public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<DBVENTAContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
			});
		}
	
	}
}

