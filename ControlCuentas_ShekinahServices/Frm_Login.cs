using Aplicacion;
using ControlCuentas_ShekinahServices.Message_Persl;
using ControlCuentas_ShekinahServices.MessageBox_Personalizados;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCuentas_ShekinahServices
{
    public partial class Acceso : Form
    {
        private IAcessoSistema<AccesoSistema> _repositorio;
        private readonly IServiceProvider _serviceProvider;
        private List<Perfil_Usuario> Listad = new List<Perfil_Usuario>();
        private AccesoSistema _accesoSistema = new AccesoSistema();
        bool bandera;
        int Id_Usuario = 0;


        /// Arrastrar Formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       

        public Acceso(IAcessoSistema<AccesoSistema> repositorio, IServiceProvider serviceProvider)
        {
            _repositorio = repositorio;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            Libreria_Interna.AplicarEsquinasRedondeadas(this, 20);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnAcceder, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(btnCancelar, 5);
            btnAcceder.BackColor = ColoresRGB.Gris_Claro;
            Libreria_Interna.CentrarPicture_Horizontal(PicPhotoCliente, this);
            Libreria_Interna.CentrarLabel_Horizontal(lbContrasenia, this);
            Libreria_Interna.CentrarLabel_Horizontal(lbUsuario, this);
            Libreria_Interna.CentrarLabel_Horizontal(lbTitutlo_Login, this);
            Libreria_Interna.AplicarBordesEsquinasBoton(txt_Usuario, 5);
            Libreria_Interna.AplicarBordesEsquinasBoton(txt_Contrasenia, 5);

            
        }

        private void Grp_Acceso_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void txt_Usuario_Leave(object sender, EventArgs e)
        {
            Id_Usuario = await _repositorio.Verificar_Usuario(txt_Usuario.Text);
            if (Id_Usuario > 0)
            {
                //MessageBox.Show("Usuario Encontrado");
                if (Id_Usuario == 1)
                {
                    PicPhotoCliente.Image = Properties.Resources.codificacion;
                }
                txt_Usuario.BackColor = Color.White;
                erP_Usuario.Clear();
                btnAcceder.Enabled = true;
                btnAcceder.BackColor = ColoresRGB.Verde_Menta_Boton;
                txt_Contrasenia.Focus();
            }
            else
            {
                // MessageBox.Show("Usuario No Encontrado");
                txt_Usuario.BackColor = ColoresRGB.Rojo_Vino;
                erP_Usuario.SetError(txt_Usuario, "Nombre de usario no registrado!");
                btnAcceder.Enabled = false;
                btnAcceder.BackColor = ColoresRGB.Gris_Claro;
                txt_Usuario.Focus();
            }
        }

        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            Acceder_Sistema();
        }

        private async void Acceder_Sistema()
        {
            if (txt_Usuario.Text == string.Empty || txt_Contrasenia.Text == string.Empty)
            {
                MessageBox.Show("Debe Completar todos los campos");
            }
            else
            {
                Id_Usuario = await _repositorio.Acceder_Sistema(txt_Usuario.Text, txt_Contrasenia.Text);
                Listad = await _repositorio.ObtenerUsuario_Especifico(Id_Usuario);
               
                if (Id_Usuario > 0)
                {
                    var Frm_Bienvenida = _serviceProvider.GetRequiredService<Frm_Acceso_Bienvenida>();
                    Frm_Bienvenida.Mensaje($"Usuario: {Listad[0].Nombre_Usuario}");
                    Frm_Bienvenida.ShowDialog();
                    Frm_Main frm_Main = new Frm_Main(_serviceProvider);
                    frm_Main.Recibir_Usuario(Listad);
                    this.Hide();
                    frm_Main.ShowDialog();
                }
            }
        }

        private void txt_Contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica si la tecla presionada es "Enter"
            {
                e.SuppressKeyPress = true; // Evita el sonido de "ding" en el TextBox
                Acceder_Sistema();
            }
        }

        private void chk_MostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = !chk_MostrarContra.Checked;
        }

        private void Grp_Acceso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_Acceso_Paint(object sender, PaintEventArgs e)
        {
            var borderRadius = 20; // Radio del borde redondeado
            var borderColor = Color.White; // Color del borde
            var borderWidth = 1; // Grosor del borde

            // Obtiene las dimensiones del PictureBox, asegurándose de que no se solapen con el borde
            var rect = new Rectangle(0, 0, Panel_Acceso.Width - 5, Panel_Acceso.Height - 5);

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

        private void Panel_Superior_Acceso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
