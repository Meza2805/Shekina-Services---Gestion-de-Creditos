using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices.FormulariosHijos
{
    public partial class Frm_AgregarPersona : Form
    {
        Persona persona_r = new Persona();
        public Frm_AgregarPersona()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite capturar teclas en el formulario
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnGuardar, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnCancelar, 5);
        }


        public void Tipo_Entrada(bool tipo)
        {
            if (tipo)
            {
                GrpAgregarCliente.Text = "Agregar Cliente";
                PicPhotoCliente.Image = Properties.Resources.AgregarPersona;
            }
            else
            {
                GrpAgregarCliente.Text = "Editar Cliente";
                PicPhotoCliente.Image = Properties.Resources.EditarPersona;
            }
        }

        public void RecibirDatosPersona(Persona persona)
        {
            txtPrimerNombreCliente.Text = persona.PrimerNombre;
            txtSegundoNombreCliente.Text = persona.SegundoNombre;
            txtPrimerApellidoCliente.Text = persona.PrimerApellido;
            txtSegundoApellidoCliente.Text = persona.SegundoApellido;
            txtNoCedulaCliente.Text = persona.NoCedula;
            txtTelefonoCliente.Text = persona.NoTelefono;
            txtDireccionCliente.Text = persona.Direccion;
            dtFechaNacCliente.Value = persona.FechaNacimiento;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AgregarPersona_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario
            }
        }
    }
}
