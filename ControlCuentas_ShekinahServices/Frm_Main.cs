using ControlCuentas_ShekinahServices.FormulariosHijos;
using FontAwesome.Sharp;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;


namespace ControlCuentas_ShekinahServices
{
    public partial class Frm_Main : Form
    {
        private readonly IServiceProvider _serviceProvider;


        /// Campos 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormularioHijoActual;
        private bool isCollapsing; // Indica si el panel se está reduciendo
        private int targetWidth;   // Almacena el ancho objetivo del panel
        private const int animationSpeed = 50; // Velocidad de la animación

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

        private void Resetear()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            IconoFormularioActual.IconChar = IconChar.Home;
            IconoFormularioActual.IconColor = Color.White;
            TituloFormularioHijo.Text = "Inicio";
            TituloFormularioHijo.ForeColor = Color.White;
        }

        private void AbrirFormularioHijo(Form FormularioHijo)
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
                btnInicio.Location = new Point(3,58);
                btnInicio.Size = new Size(40,40);
                btnInicio.Image = Properties.Resources.Lion;
            }
            else
            {
                btnInicio.Location = new Point(26, 17);
                btnInicio.Size = new Size(140, 118);
                btnInicio.Image = Properties.Resources.Logo_Ajustado_Blanco___copia;
            }
        }  //Funcion para quitar el texto de los botones y solo se apreceie el icono

        /// Eventos
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Rosa_Coral_Suave, "Clientes");
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Amarrillo_Mostaza, "Creditos");
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Malva_Claro, "Reportes");
        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRGB.Amarillo_Dorado_Suave, "Ajustes");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Resetear();
            //En este caso hago uso de los formularios que he implementado en el archivo Main.cs en lugar de Instanciarlos
            var Formulario = _serviceProvider.GetRequiredService<Frm_Principal>();
            AbrirFormularioHijo(Formulario);
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
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
    }


}
