using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices.Message_Persl
{
    public partial class Frm_Acceso_Bienvenida : Form
    {
        public Frm_Acceso_Bienvenida()
        {
            InitializeComponent();
            Libreria_Interna.AplicarBordesEsquinasBoton(btnAceptar,20);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Mensaje(string mensaje)
        {
            lbMensaje.Text = mensaje;
            Libreria_Interna.CentrarLabel_Horizontal(lbMensaje, this);
        }
    }
}
