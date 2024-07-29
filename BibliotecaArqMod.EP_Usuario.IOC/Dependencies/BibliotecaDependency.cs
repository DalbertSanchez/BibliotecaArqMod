using BibliotecaArqMod.EP_Usuario.Application.Interfaces;
using BibliotecaArqMod.EP_Usuario.Application.Services;
using BibliotecaArqMod.EP_Usuario.Domain.Entities;
using BibliotecaArqMod.EP_Usuario.Domain.Interfaces;
using BibliotecaArqMod.EP_Usuario.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BibliotecaArqMod.EP_Usuario.IOC.Dependencies
{
    public static class BibliotecaDependency
    {
        public static void AddBibliotecaDependency(this IServiceCollection services) 
        {

            #region "Repositorios"
            services.AddScoped<IUsuarioRepository,UsuarioRepository>();
            services.AddScoped<IEstadoPrestamoRepository,EstadoPrestamoRepository>();
            #endregion

            #region "Servicios"
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IEstadoPrestamoService, EstadoPrestamoService>();
            #endregion

        }
    }
}
