using Aplicacion;
using ControlCuentas_ShekinahServices.FormulariosHijos;
using Datos;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio;

namespace ControlCuentas_ShekinahServices
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var servicesProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Frm_Main());

            var mainForm = servicesProvider.GetRequiredService<Frm_Main>();
            Application.Run(mainForm);

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            ///Para usar un Json en la manipulacion de cadenas de conexion he instalado dos paquetes, puede verificarlos en los paquetes de la capa vista
            ///Tambien es importante en las propiedades del archivo json colocar la opcion "Copiar Siempre" en modulo Copiar en el directorio de salida
            ///Hacer permite que el compilador encuentre nuestro archivo Json
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json",optional: false, reloadOnChange: true).Build();

            //Se procede a inyectar el ORM 
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConexionLocal")));

            services.AddTransient<AgregarPersona>(); /// Implemento el caso de uso de la capa Aplicacion
            services.AddTransient<IRepositorio<Persona>, PersonaRepositorio>();  //Inyecto la entidad del caso de uso, y el repositorio del cual depende

            services.AddTransient<Frm_Main>();
            services.AddTransient<Frm_Principal>();
        }

    }
}