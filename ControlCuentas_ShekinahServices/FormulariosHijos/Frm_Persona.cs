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
        private Persona _persona = new Persona();

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
            DataTable dtPersonas = ConvertToDataTable(persona);

            dgvPersona.DataSource = dtPersonas;
            dgvPersona.Columns[0].Visible = false;//Id
            dgvPersona.Columns[2].Visible = false;//PrimerNombre
            dgvPersona.Columns[3].Visible = false;//SegundoNombre
            dgvPersona.Columns[4].Visible = false;//PrimerApellido
            dgvPersona.Columns[5].Visible = false;//SegundoApellido
            dgvPersona.Columns[7].Visible = false;//FechaNacimiento

            dgvPersona.Columns[1].HeaderText = "Cedula";
            dgvPersona.Columns[6].HeaderText = "Nombre Completo";

          


            bSPersonas.DataSource = dgvPersona.DataSource;



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
            ////// player.Play(); // Reproduce el sonido
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ////// player.Play(); // Reproduce el sonido
            var Formulario = _serviceProvider.GetRequiredService<Frm_AgregarPersona>();
            Formulario.Tipo_Entrada(true);
            Formulario.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            ////// player.Play(); // Reproduce el sonido
            var Formulario = _serviceProvider.GetRequiredService<Frm_AgregarPersona>();
            Formulario.Tipo_Entrada(false);
            Formulario.RecibirDatosPersona(CargarDatosPersona());
            Formulario.ShowDialog();

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            ////// player.Play(); // Reproduce el sonido
        }


        private Persona CargarDatosPersona()
        {

         

            if (dgvPersona.SelectedRows.Count > 0)
            {
                DataGridViewRow FilaSeleccionada = dgvPersona.SelectedRows[0];
                _persona.NoCedula = FilaSeleccionada.Cells[1].Value.ToString();
                _persona.PrimerNombre = FilaSeleccionada.Cells[2].Value.ToString();
                _persona.SegundoNombre = FilaSeleccionada.Cells[3].Value.ToString();
                _persona.PrimerApellido = FilaSeleccionada.Cells[4].Value.ToString();
                _persona.SegundoApellido = FilaSeleccionada.Cells[5].Value.ToString();
                _persona.FechaNacimiento = Convert.ToDateTime(FilaSeleccionada.Cells[7].Value.ToString());
                _persona.Direccion = FilaSeleccionada.Cells[10].Value.ToString();
                _persona.NoTelefono = FilaSeleccionada.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de cargar los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return _persona;
        }


        private void Busqueda_Persona(string filter_R)
        {
            try
            {
                // Asegurar que el BindingSource tiene datos
               if (bSPersonas.DataSource != null)
                {
                    string filter = filter_R;
                    // Obtener el texto del TextBox y manejar caracteres especiales
                    // string filter = filter_R.Trim().Replace("'", "''"); // Escapa comillas simples

                    // Aplicar filtro si hay texto ingresado
                    if (!string.IsNullOrEmpty(filter))
                    {
                        bSPersonas.Filter = $"NombreCompleto LIKE '%{filter}%'";
                    }
                    else
                    {
                        bSPersonas.RemoveFilter(); // Si el filtro está vacío, se limpia el filtro
                    }

                    // Refrescar la vista
                    dgvPersona.DataSource = bSPersonas;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al filtrar los datos: " + ex.Message);
            }
        }


        public static DataTable ConvertToDataTable(IEnumerable<Persona> personas)
        {
            DataTable dataTable = new DataTable("Personas");

            // Definir columnas en base a las propiedades de la clase Persona
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("NoCedula", typeof(string));
            dataTable.Columns.Add("PrimerNombre", typeof(string));
            dataTable.Columns.Add("SegundoNombre", typeof(string));
            dataTable.Columns.Add("PrimerApellido", typeof(string));
            dataTable.Columns.Add("SegundoApellido", typeof(string));
            dataTable.Columns.Add("NombreCompleto", typeof(string)); // Propiedad calculada
            dataTable.Columns.Add("FechaNacimiento", typeof(DateTime));
            dataTable.Columns.Add("Edad", typeof(string)); // Propiedad calculada
            dataTable.Columns.Add("NoTelefono", typeof(string));
            dataTable.Columns.Add("Direccion", typeof(string));
            dataTable.Columns.Add("FechaCreacion", typeof(DateTime));

            // Llenar el DataTable con la lista de personas
            foreach (var persona in personas)
            {
                dataTable.Rows.Add(
                    persona.Id,
                    persona.NoCedula,
                    persona.PrimerNombre,
                    persona.SegundoNombre,
                    persona.PrimerApellido,
                    persona.SegundoApellido,
                    persona.NombreCompleto, // Se calcula automáticamente
                    persona.FechaNacimiento,
                    persona.Edad, // Se calcula automáticamente
                    persona.NoTelefono,
                    persona.Direccion,
                    persona.FechaCreacion
                );
            }

            return dataTable;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Busqueda_Persona(txtBusqueda.Text);
        }
    }
}
