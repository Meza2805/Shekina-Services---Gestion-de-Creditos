using ControlCuentas_ShekinahServices.FormulariosHijos;
using ControlCuentas_ShekinahServices.Message_Persl;
using ControlCuentas_ShekinahServices.MessageBox_Personalizados;
using Entidades;
using FontAwesome.Sharp;
using Microsoft.Extensions.DependencyInjection;
using Modelos;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ControlCuentas_ShekinahServices
{
    public partial class Frm_Main : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private List<Perfil_UsuarioModel> _Usuarios; //Declaro una lista para recibir los usarios, no uso inyeccion de dependecias, simplemente los pasos desde un metodo manipulado desde el formulario Login
        // Crear un reproductor de sonido
        SoundPlayer player = new SoundPlayer(Properties.Resources.MouseClickPunchy);
        SoundPlayer OpenClose = new SoundPlayer(Properties.Resources.space_ship_door_open_47688);

        /// Campos 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormularioHijoActual;
        private bool isCollapsing; // Indica si el panel se está reduciendo
        private int targetWidth;   // Almacena el ancho objetivo del panel
        private const int animationSpeed = 50; // Velocidad de la animación
        private int Id_Usuario = 0;

        /// Arrastrar Formulario
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ///Construtor
        public Frm_Main(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 42);
            PanelMenu.Controls.Add(leftBorderBtn);
            AbrirFormularioHijo(new Frm_Principal());

            //Esto sirve para quitar la caja de herramientas y reducir el parpade del formulario al moverlo
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this._serviceProvider = serviceProvider;
        }


        public void Recibir_Usuario(List<Perfil_UsuarioModel> Usuarios)
        {
           // _Usuarios = new List<Perfil_Usuario>();
            _Usuarios = Usuarios;
            Lb_NombreUsuario.Text = $"{Convert.ToString(Usuarios[0].Nombre_Usuario)} /  {Convert.ToString(Usuarios[0].Nombre_Permiso)}";
            Id_Usuario = Usuarios[0].Id_Usuario;
        }
        ///Metodos
        private void ActivarBoton(object senderBtn, Color color, string Opcion)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(30, 50, 70);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Panel de borde Izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                IconoFormularioActual.IconChar = currentBtn.IconChar;
                IconoFormularioActual.IconColor = color;

                TituloFormularioHijo.Text = Opcion;
                TituloFormularioHijo.ForeColor = color;
            }
        }

        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 55, 110);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void Resetear()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            IconoFormularioActual.IconChar = IconChar.Home;
            IconoFormularioActual.IconColor = Color.White;
            TituloFormularioHijo.Text = "Inicio";
            TituloFormularioHijo.ForeColor = Color.White;

            var Formulario = _serviceProvider.GetRequiredService<Frm_Principal>();
            AbrirFormularioHijo(Formulario);
        }

        public void AbrirFormularioHijo(Form FormularioHijo)
        {
            if (FormularioHijoActual != null)
            {
                FormularioHijoActual.Close();
            }
            FormularioHijoActual = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(FormularioHijoActual);
            PanelContenedor.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void ReducirPaneles_Botones()
        {
            List<Button> botones = new List<Button> { BtnClientes, BtnCreditos, BtnReportes, BtnAjustes };


            // Diccionario de textos iniciales (definidos manualmente)
            Dictionary<Button, string> textosOriginales = new Dictionary<Button, string>
            {
                { BtnClientes, "Clientes" },
                { BtnCreditos, "Créditos" },
                { BtnReportes, "Reportes" },
                { BtnAjustes, "Ajustes" }
            };

            // Iterar sobre los botones para aplicar la lógica
            foreach (var boton in botones)
            {
                if (string.IsNullOrEmpty(boton.Text))
                {
                    boton.Text = textosOriginales[boton];
                }
                else
                {
                    boton.Text = null;
                }
            }


            if (btnInicio.Location == new Point(26, 17))
            {
                btnInicio.Location = new Point(26, 17);
                btnInicio.Size = new Size(140, 118);
                btnInicio.Image = Properties.Resources.Lion;
            }
            else
            {

                btnInicio.Location = new Point(3, 58);
                btnInicio.Size = new Size(40, 40);
                btnInicio.Image = Properties.Resources.Logo_Ajustado_Blanco___copia;

            }
        }  //Funcion para quitar el texto de los botones y solo se apreceie el icono

        /// Eventos
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            ActivarBoton(sender, ColoresRGB.Rosa_Coral_Suave, "Clientes");
            var Formulario = _serviceProvider.GetRequiredService<Frm_Persona>();
            Formulario.Recibir_Id_Usuario(Id_Usuario); //No es la forma mas efeciente, pero asi recibo el Id_Usuario Loggeado
            AbrirFormularioHijo(Formulario);
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            ActivarBoton(sender, ColoresRGB.Amarrillo_Mostaza, "Creditos");
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            ActivarBoton(sender, ColoresRGB.Malva_Claro, "Reportes");
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            ActivarBoton(sender, ColoresRGB.Amarillo_Dorado_Suave, "Ajustes");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            Resetear();
            //En este caso hago uso de los formularios que he implementado en el archivo Main.cs en lugar de Instanciarlos
            //var Formulario = _serviceProvider.GetRequiredService<Frm_Principal>();
            //AbrirFormularioHijo(Formulario);
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            /// player.Play();
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e, Frm_Message_SI_NO formulario)
        {
            /// player.Play(); // Reproduce el sonido

            var Formulario = _serviceProvider.GetRequiredService<Frm_Message_SI_NO>();

            Formulario.ConfigurarMensaje("¿Está seguro que desea salir?");
            Formulario.ShowDialog();
            Application.Exit();

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido

            //OpenClose.Play();


            ReducirPaneles_Botones();
            if (BtnAccionMenu.IconChar == IconChar.ArrowsLeftRightToLine)
            {
                BtnAccionMenu.IconChar = IconChar.ArrowsLeftRight;
                targetWidth = 50; // Ancho reducido
                isCollapsing = true;
            }
            else
            {
                BtnAccionMenu.IconChar = IconChar.ArrowsLeftRightToLine;
                targetWidth = 187; // Ancho expandido
                isCollapsing = false;
            }

            animationTimer.Start(); // Inicia el Timer para animar
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            int initialWidth = PanelMenu.Width;
            if (isCollapsing)
            {
                // Reducir el ancho gradualmente
                if (PanelMenu.Width > targetWidth)
                {
                    PanelMenu.Width -= animationSpeed;
                    if (PanelMenu.Width <= targetWidth)
                    {
                        PanelMenu.Width = targetWidth;

                        animationTimer.Stop(); // Detiene el Timer cuando llega al ancho objetivo
                    }
                }
            }
            else
            {
                initialWidth = PanelMenu.Width;
                // Expandir el ancho gradualmente
                if (PanelMenu.Width < targetWidth)
                {
                    PanelMenu.Width += animationSpeed;
                    if (PanelMenu.Width >= targetWidth)
                    {
                        PanelMenu.Width = targetWidth;
                        animationTimer.Stop(); // Detiene el Timer cuando llega al ancho objetivo
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            /// player.Play(); // Reproduce el sonido
            var MessageBox = _serviceProvider.GetService<Frm_Message_SI_NO>();
            MessageBox.ConfigurarMensaje("¿Está seguro que desea salir?");
            MessageBox.ShowDialog();
            if (MessageBox.Resultado)
            {
                var Formulario = _serviceProvider.GetRequiredService<Frm_Despedida>();
                Formulario.Show();
            }

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
            //var borderRadius = 15; // Radio del borde redondeado
            //var borderColor = Color.White; // Color del borde
            //var borderWidth = 1; // Grosor del borde

            //// Obtiene las dimensiones del PictureBox, asegurándose de que no se solapen con el borde
            //var rect = new Rectangle(0, 0, PanelMenu.Width - 1, PanelMenu.Height - 1);

            //// Crea el camino de gráficos para el borde redondeado
            //using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            //{
            //    // Añadir las esquinas redondeadas utilizando AddArc
            //    path.AddArc(rect.Left, rect.Top, borderRadius, borderRadius, 180, 90);  // Esquina superior izquierda
            //    path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top, borderRadius, borderRadius, 270, 90);  // Esquina superior derecha
            //    path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);  // Esquina inferior derecha
            //    path.AddArc(rect.Left, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);  // Esquina inferior izquierda
            //    path.CloseAllFigures();  // Cierra el contorno de la figura

            //    // Crea el pincel para dibujar el borde
            //    using (var pen = new Pen(borderColor, borderWidth))
            //    {
            //        // Establece el suavizado para evitar bordes irregulares
            //        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //        e.Graphics.DrawPath(pen, path);  // Dibuja el borde redondeado
            //    }
            //}
        }

        private void pb_Imagen_Usuario_Paint(object sender, PaintEventArgs e)
        {
            //var borderRadius = 20; // Radio del borde redondeado
            //var borderColor = Color.White; // Color del borde
            //var borderWidth = 1; // Grosor del borde

            //// Obtiene las dimensiones del PictureBox, asegurándose de que no se solapen con el borde
            //var rect = new Rectangle(0, 0, pb_Imagen_Usuario.Width - 5, pb_Imagen_Usuario.Height - 5);

            //// Crea el camino de gráficos para el borde redondeado
            //using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            //{
            //    // Añadir las esquinas redondeadas utilizando AddArc
            //    path.AddArc(rect.Left, rect.Top, borderRadius, borderRadius, 180, 90);  // Esquina superior izquierda
            //    path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top, borderRadius, borderRadius, 270, 90);  // Esquina superior derecha
            //    path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);  // Esquina inferior derecha
            //    path.AddArc(rect.Left, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);  // Esquina inferior izquierda
            //    path.CloseAllFigures();  // Cierra el contorno de la figura

            //    // Crea el pincel para dibujar el borde
            //    using (var pen = new Pen(borderColor, borderWidth))
            //    {
            //        // Establece el suavizado para evitar bordes irregulares
            //        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //        e.Graphics.DrawPath(pen, path);  // Dibuja el borde redondeado
            //    }
            //}
        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {
            //var borderRadius = 15; // Radio del borde redondeado
            //var borderColor = Color.White; // Color del borde
            //var borderWidth = 1; // Grosor del borde

            //// Obtiene las dimensiones del PictureBox, asegurándose de que no se solapen con el borde
            //var rect = new Rectangle(0, 0, PanelLogo.Width - 1, PanelLogo.Height - 1);

            //// Crea el camino de gráficos para el borde redondeado
            //using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            //{
            //    // Añadir las esquinas redondeadas utilizando AddArc
            //    path.AddArc(rect.Left, rect.Top, borderRadius, borderRadius, 180, 90);  // Esquina superior izquierda
            //    path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top, borderRadius, borderRadius, 270, 90);  // Esquina superior derecha
            //    path.AddArc(rect.Left + rect.Width - borderRadius, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);  // Esquina inferior derecha
            //    path.AddArc(rect.Left, rect.Top + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);  // Esquina inferior izquierda
            //    path.CloseAllFigures();  // Cierra el contorno de la figura

            //    // Crea el pincel para dibujar el borde
            //    using (var pen = new Pen(borderColor, borderWidth))
            //    {
            //        // Establece el suavizado para evitar bordes irregulares
            //        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //        e.Graphics.DrawPath(pen, path);  // Dibuja el borde redondeado
            //    }
            //}
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Verde_Oliva_Suave, "Productos");
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Azul_Petroleo_Suave, "Facturación");
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Rosa_Palo_Suave, "Proveedores");
        }
    }


}
