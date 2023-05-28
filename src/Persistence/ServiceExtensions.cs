
using ApiEcommerceWeb.Application.Common.Interfaces;
//using ApiEcommerceWeb.Application.Features.Acontecimientos.Interfaces;
using ApiEcommerceWeb.Application.Features.Clientes.Interfaces;
//using ApiEcommerceWeb.Application.Features.Eventos.Interfaces;
using ApiEcommerceWeb.Persistence.Contexts;
using ApiEcommerceWeb.Persistence.Repository;
//using ApiEcommerceWeb.Persistence.Repository.Acontecimientos;
using ApiEcommerceWeb.Persistence.Repository.Clientes;
//using ApiEcommerceWeb.Persistence.Repository.Eventos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using ApiEcommerceWeb.Application.Features.Adjunto.Interfaces;

namespace ApiEcommerceWeb.Persistence;
public static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
               builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        /*
        services.AddDbContext<ApplicationsDbPanaceaContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("Bd_Rrhh_Panacea")));

        services.AddDbContext<ApplicationsDbMarcacionesContext>(options => 
                    options.UseSqlServer(configuration.GetConnectionString("Bd_Marcaciones_GRIAMSE")));
        */

        #region Repositories

        services.AddTransient(typeof(IRepositoryAsync<>), typeof(CustomRepositoryAsync<>));
        //services.AddTransient<IAcontecimientos, AcontecimientoService>();
        services.AddTransient<IClientes, ClientesService>();
        //services.AddTransient<IAdjuntoService, AdjuntoService>();
        #endregion

        return services;
    }

}