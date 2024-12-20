using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices.Message_Persl
{
    public partial class Frm_Despedida : Form
    {
        private System.Timers.Timer exitTimer;
        public Frm_Despedida()
        {
            InitializeComponent();
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 30);
            // Configurar el Timer para cerrar la aplicación en 2 segundos
            SetExitTimer();
        }
        private void SetExitTimer()
        {
            exitTimer = new System.Timers.Timer(2000); // 2000 ms = 2 segundos
            exitTimer.Elapsed += OnTimedEvent;
            exitTimer.AutoReset = false; // No repetir el evento
            exitTimer.Start();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            // Detener el Timer
            exitTimer.Stop();
            exitTimer.Dispose();

            // Cerrar toda la aplicación
            Application.Exit();
        }
    }
}
