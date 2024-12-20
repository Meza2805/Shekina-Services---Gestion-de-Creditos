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
        public Frm_AgregarPersona()
        {
            InitializeComponent();
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnGuardar, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnCancelar, 5);
        }


         public void Tipo_Entrada(bool tipo)
        {
            if (tipo)
            {
                GrpAgregarCliente.Text = "Agregar Persona";
                PicPhotoCliente.Image = Properties.Resources.AgregarPersona;
            }
            else
            {
                GrpAgregarCliente.Text = "Editar Persona";
                PicPhotoCliente.Image = Properties.Resources.EditarPersona;
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
