
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using Negocio.IRepositorios;
using Negocio.IServicios;
using Negocio.Servicios;

namespace PuntoDeVenta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<Login>();

                Application.Run(login);
            }


        }

        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped(cadCon => "");
            services.AddTransient<IRepositorioUsuario, RepositorioUsuario>().AddTransient<ServicioAutenticacion>();
            services.AddTransient<IServicioAutenticacion, ServicioAutenticacion>().AddTransient<Login>();
        }
    }
}
