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
            Libreria_Interna.AplicarBordesEsquinasBoton(btnAceptar, 20);
            Libreria_Interna.CentrarPicture_Horizontal(picImagenAccesoBienvenida, this);

            Libreria_Interna.CentrarLabel_Horizontal(lbMensaje, this);
            Libreria_Interna.CentrarLabel_Horizontal(lbMensaje2, this);
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.CentrarLabel_Horizontal(lbTitulo, this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Mensaje(string mensaje, string mensaje1, string mensaje2, bool estado)
        {
            lbMensaje.Text = mensaje;
            lbMensaje2.Text = mensaje1;
            lbTitulo.Text = mensaje2;
            Libreria_Interna.CentrarLabel_Horizontal(lbMensaje, this);
            Libreria_Interna.CentrarLabel_Horizontal(lbMensaje2, this);
            Libreria_Interna.CentrarLabel_Horizontal(lbTitulo, this);

            if (estado)
            {
                picImagenAccesoBienvenida.Image = Properties.Resources.EditarPersona;
            }
        }

        private void Panel_Acceso_Bienvenido_Paint(object sender, PaintEventArgs e)
        {

            var borderRadius = 20; // Radio del borde redondeado
            var borderColor = Color.White; // Color del borde
            var borderWidth = 1; // Grosor del borde

            // Obtiene las dimensiones del PictureBox, asegurándose de que no se solapen con el borde
            var rect = new Rectangle(0, 0, Panel_Acceso_Bienvenido.Width - 5, Panel_Acceso_Bienvenido.Height - 5);

            // Crea el camino de gráficos para el borde redondeado
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Añadir las esquinas redondeadas utilizando AddArc
                path.AddArc(rect.Left, rect.Top, borderRadius, borderRadius, 180, 90);  // Esquina superior izquierda
                path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top, borderRadius, borderRadius, 270, 90);  // Esquina superior derecha
                path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);  // Esquina inferior derecha
                path.AddArc(rect.Left, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);  // Esquina inferior izquierda
                path.CloseAllFigures();  // Cierra el contorno de la figura

                // Crea el pincel para dibujar el borde
                using (var pen = new Pen(borderColor, borderWidth))
                {
                    // Establece el suavizado para evitar bordes irregulares
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);  // Dibuja el borde redondeado
                }
            }
        }
    }
}
