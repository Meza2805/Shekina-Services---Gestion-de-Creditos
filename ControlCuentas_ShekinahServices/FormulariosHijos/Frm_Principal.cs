using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices.FormulariosHijos
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            InicializarReloj();
          
        }


        private void InicializarReloj()
        {
            // Configurar el Timer
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += ActualizarReloj;
            timer1.Start();

            // Mostrar la hora inicial
            LbHoraActual.Text = ObtenerFechaEnLetras() + " " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ActualizarReloj(object sender, EventArgs e)
        {
            // Actualizar el texto del label con la fecha y hora actual en formato de 12 horas
            LbHoraActual.Text = ObtenerFechaEnLetras() + " " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private string ObtenerFechaEnLetras()
        {
            // Obtener la fecha actual
            DateTime ahora = DateTime.Now;

            // Formatear la fecha en letras
            string fechaEnLetras = ahora.ToString("dd 'de' MMMM 'del' yyyy", new CultureInfo("es-ES"));

            return fechaEnLetras;
        }


        private void CentrarLabel(Label label, Form formulario)
        {
            // Calcular la posición X e Y para centrar el Label
            int posX = (formulario.ClientSize.Width - label.Width) / 2;
            int posY = (formulario.ClientSize.Height - label.Height) / 2;

            // Asignar la nueva ubicación al Label
            label.Location = new Point(posX, posY);
        }

    }

}
