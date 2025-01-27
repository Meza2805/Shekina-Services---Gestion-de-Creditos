using ControlCuentas_ShekinahServices.Message_Persl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace ControlCuentas_ShekinahServices.MessageBox_Personalizados
{
    public partial class Frm_Message_SI_NO : Form
    {
        private readonly IServiceProvider _serviceProvider;


        // Propiedad pública para almacenar el valor booleano para validar si el usuario hizo clic en el botón "Sí" o "No".
        public bool Resultado { get; private set; }
        // Crear un reproductor de sonido
        SoundPlayer BtnSonido = new SoundPlayer(Properties.Resources.MouseClickPunchy);


        // Importar la función CreateRoundRectRgn desde la API de Windows
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,      // Coordenada izquierda
            int nTopRect,       // Coordenada superior
            int nRightRect,     // Coordenada derecha
            int nBottomRect,    // Coordenada inferior
            int nWidthEllipse,  // Ancho de la elipse
            int nHeightEllipse  // Altura de la elipse
        );

    
        public Frm_Message_SI_NO(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
            // Aplicar bordes redondeados al formulario
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 30);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnSi, 5); // Aplicar bordes redondeados al botón "Sí"
            Libreria_Interna.AplicarBordesEsquinasBoton(btnNo, 5); // Aplicar bordes redondeados al botón "No"
            this._serviceProvider = _serviceProvider;
        }


        // Ajustar la región cuando el formulario cambia de tamaño
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30)); // Actualizar el radio
        }

        // Método público para establecer el parámetro
        public void ConfigurarMensaje(string mensaje)
        {
            lbMensaje.Text = mensaje; // Supongamos que tienes un Label llamado lblMensaje
            Libreria_Interna.CentrarLabel_Horizontal(lbMensaje, this); // Centrar el Label horizontalmente
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
           // BtnSonido.Play();
            Resultado = true;
            this.Close();
            
            //var Formulario = _serviceProvider.GetRequiredService<Frm_Despedida>();
            //Formulario.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
           // BtnSonido.Play();
            this.Close();
        }
    }
}
