using Aplicacion;
using ControlCuentas_ShekinahServices.Formularios_de_Carga;
using ControlCuentas_ShekinahServices.FormulariosHijos;
using ControlCuentas_ShekinahServices.Message_Persl;
using ControlCuentas_ShekinahServices.MessageBox_Personalizados;
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
            // 1. Crear una nueva colección de servicios.
            //    `ServiceCollection` es una clase proporcionada por .NET para registrar servicios
            //    que serán manejados por el contenedor de inyección de dependencias.
            //    Esta colección actuará como un "registro" donde se añaden todos los servicios necesarios.
            var services = new ServiceCollection();

            // 2. Llamar a un método (en este caso `ConfigureServices`) para configurar los servicios necesarios.
            //    Este método generalmente se utiliza para registrar los servicios que tu aplicación va a usar.
            //    Por ejemplo, puedes registrar clases, interfaces, y configuraciones de dependencia.
            ConfigureServices(services);

            // 3. Construir el proveedor de servicios.
            //    `BuildServiceProvider` toma todos los servicios registrados en la colección
            //    y los organiza en un contenedor que manejará sus ciclos de vida (transient, scoped, singleton).
            //    Este contenedor permitirá crear instancias de los servicios cuando se necesiten,
            //    y administrará la inyección de dependencias entre ellos.
            var servicesProvider = services.BuildServiceProvider();

            // Nota:
            //    A partir de aquí, puedes usar `servicesProvider` para solicitar instancias de los servicios
            //    registrados, resolviendo automáticamente sus dependencias.


            var mainForm = servicesProvider.GetRequiredService<Frm_Main>();
            var mainLogin = servicesProvider.GetRequiredService<Acceso>();
            Application.Run(mainLogin);

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Configuración del archivo JSON:
            // Se utiliza un archivo `appsettings.json` para manejar configuraciones como cadenas de conexión.
            // Comentarios adicionales:
            // 1. Se requiere que el archivo `appsettings.json` esté en el directorio de salida (por ejemplo, bin/Debug).
            //    Para lograr esto, asegúrate de que su propiedad "Copiar al directorio de salida" esté configurada como "Copiar siempre".
            // 2. Dos paquetes NuGet deben estar instalados:
            //    - Microsoft.Extensions.Configuration
            //    - Microsoft.Extensions.Configuration.Json

            // Aquí se construye una configuración que carga el archivo JSON de configuración.
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // El archivo JSON es obligatorio.
                .Build();

            // Inyección del ORM (Entity Framework Core):
            // Se registra el contexto de base de datos (`AppDbContext`) en el contenedor de dependencias.
            // `UseSqlServer` indica que se utilizará SQL Server como motor de base de datos.
            // La cadena de conexión ("Conexion_VPS") se obtiene del archivo JSON.
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Conexion_VPS")));

            // Inyección de dependencias para casos de uso:
            // `AgregarPersona` es un caso de uso en la capa de aplicación. Se registra con un ciclo de vida "transitorio".
            services.AddTransient<AgregarPersona>();

            // Inyección de un repositorio genérico:
            // `IRepositorio<Persona>` es una interfaz genérica para manejar la entidad `Persona`.
            // `PersonaRepositorio` es la implementación concreta de este repositorio.
            // Esto permite que `AgregarPersona` y otros servicios utilicen la abstracción `IRepositorio<Persona>`.
            services.AddTransient<IRepositorio<Persona>, PersonaRepositorio>();
            services.AddTransient<IAcessoSistema<AccesoSistema>, Acceso_Sistema_Repositorio>();
            services.AddTransient<IPersona, PersonaRepositorio02>(); 


            // Inyección de dependencias para formularios:
            // Aquí se registran formularios que pertenecen a la capa de presentación.
            // Cada formulario tiene un ciclo de vida transitorio, es decir, se crea una nueva instancia cada vez que se solicita.
            services.AddTransient<Frm_Main>();       // Formulario principal
            services.AddTransient<Acceso>();       // Formulario de Acceso
            services.AddTransient<Frm_Persona>();    // Formulario para gestionar personas
            services.AddTransient<Frm_Principal>();  // Formulario de Contenedor Principal
            services.AddTransient<Frm_Carga_01>();   // Formulario de carga de Procesos Opcion 01
            services.AddTransient<Frm_Carga_02>();   // Formulario de carga de Procesos Opcion 02
            services.AddTransient<Frm_Carga_03>();   // Formulario de carga de Procesos Opcion 03
            services.AddTransient<Frm_Carga_04>();   // Formulario de carga de Procesos Opcion 04
            services.AddTransient<Frm_Carga_05>();   // Formulario de carga de Procesos Opcion 05
            services.AddTransient<Frm_Carga_06>();   // Formulario de carga de Procesos Opcion 06
            services.AddTransient<Frm_Message_SI_NO>();   // Formulario de carga de Procesos Opcion 06
            services.AddTransient<Frm_Despedida>();   // Formulario de Despedida
            services.AddTransient<Frm_AgregarPersona>();   // Formulario de Agregar Persona
            services.AddTransient<Frm_Acceso_Bienvenida>();   // Formulario de Bienvenida a Acceso a Sistema
            services.AddTransient<Frm_Cambio_Usuario>();   // Formulario de Cambiar de Sesion de Usuario

        }


    }
}