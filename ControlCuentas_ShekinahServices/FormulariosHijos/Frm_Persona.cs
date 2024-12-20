using Aplicacion;
using ControlCuentas_ShekinahServices.Formularios_de_Carga;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices.FormulariosHijos
{

    public partial class Frm_Persona : Form
    {
        private IRepositorio<Persona> _repositorio;
        private readonly IServiceProvider _serviceProvider;

        // Crear un reproductor de sonido
     SoundPlayer player = new SoundPlayer(Properties.Resources.MouseClickPunchy);


        public Frm_Persona(IRepositorio<Persona> repositorio, IServiceProvider serviceProvider)  //Aca realizo la inyeccion de dependencias
        {                                                                                        // la dependecia del repositorio para poder establecer las reglas del negocio de la entidad
            _repositorio = repositorio;                                                         // y la dependencia del serviceProvider para poder inyectar los formularios hijos y/o formularios de carga
            _serviceProvider = serviceProvider;
            InitializeComponent();                                                               //Inicializo los componentes
            Libreria_Interna.AplicarBordesEsquinasBoton(btnAgregarCliente, 5);                 //Aplico bordes redondeados al boton
            Libreria_Interna.AplicarBordesEsquinasBoton(btnEditarCliente, 5);                  //Aplico bordes redondeados al boton
            Libreria_Interna.AplicarBordesEsquinasBoton(btnEliminarCliente, 5);                //Aplico bordes redondeados al boton
        }

        private async Task Refrescar()
        {
            var persona = await _repositorio.ObtenerListadoAsync();
            dgvPersona.DataSource = persona;
        }

        private async void Frm_Persona_Load(object sender, EventArgs e)
        {

            using (var FrmCarga = _serviceProvider.GetRequiredService<Frm_Carga_01>())
            {
                FrmCarga.Show();
                FrmCarga.BringToFront();
                this.Enabled = false;
                try
                {
                    await Refrescar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    FrmCarga.Close();
                    this.Enabled = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            player.Play(); // Reproduce el sonido
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            player.Play(); // Reproduce el sonido
            var Formulario = _serviceProvider.GetRequiredService<Frm_AgregarPersona>();
            Formulario.Tipo_Entrada(true);
            Formulario.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            player.Play(); // Reproduce el sonido
            var Formulario = _serviceProvider.GetRequiredService<Frm_AgregarPersona>();
            Formulario.Tipo_Entrada(false);
            Formulario.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            player.Play(); // Reproduce el sonido
        }
    }
}
