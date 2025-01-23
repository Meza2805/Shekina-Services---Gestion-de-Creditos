using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnAcceder, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnCancelar, 5);
        }

        private void Grp_Acceso_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
