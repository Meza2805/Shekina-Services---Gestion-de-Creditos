namespace ControlCuentas_ShekinahServices
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            PanelMenu = new Panel();
            BtnAjustes = new FontAwesome.Sharp.IconButton();
            BtnReportes = new FontAwesome.Sharp.IconButton();
            BtnCreditos = new FontAwesome.Sharp.IconButton();
            BtnClientes = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            BtnAccionMenu = new FontAwesome.Sharp.IconPictureBox();
            btnInicio = new PictureBox();
            Lb_NombreUsuario = new Label();
            pb_Imagen_Usuario = new PictureBox();
            PanelSuperior = new Panel();
            panel3 = new Panel();
            IconoFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            TituloFormularioHijo = new Label();
            Panel_Botones_Ventana = new Panel();
            btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            PanelSombra = new Panel();
            PanelContenedor = new Panel();
            panel1 = new Panel();
            PanelContenedor_2 = new Panel();
            panel2 = new Panel();
            animationTimer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            PanelMenu.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnAccionMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Imagen_Usuario).BeginInit();
            PanelSuperior.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormularioActual).BeginInit();
            Panel_Botones_Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            PanelContenedor_2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(25, 55, 110);
            PanelMenu.Controls.Add(BtnAjustes);
            PanelMenu.Controls.Add(BtnReportes);
            PanelMenu.Controls.Add(BtnCreditos);
            PanelMenu.Controls.Add(BtnClientes);
            PanelMenu.Controls.Add(PanelLogo);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Margin = new Padding(3, 4, 3, 4);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(214, 600);
            PanelMenu.TabIndex = 0;
            PanelMenu.Paint += PanelMenu_Paint;
            // 
            // BtnAjustes
            // 
            BtnAjustes.BackColor = Color.FromArgb(25, 55, 110);
            BtnAjustes.Cursor = Cursors.Hand;
            BtnAjustes.Dock = DockStyle.Top;
            BtnAjustes.FlatAppearance.BorderSize = 0;
            BtnAjustes.FlatStyle = FlatStyle.Flat;
            BtnAjustes.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            BtnAjustes.ForeColor = Color.Gainsboro;
            BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            BtnAjustes.IconColor = Color.White;
            BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAjustes.IconSize = 40;
            BtnAjustes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAjustes.Location = new Point(0, 379);
            BtnAjustes.Margin = new Padding(3, 4, 3, 4);
            BtnAjustes.Name = "BtnAjustes";
            BtnAjustes.Size = new Size(214, 56);
            BtnAjustes.TabIndex = 4;
            BtnAjustes.Text = "Ajustes";
            BtnAjustes.TextAlign = ContentAlignment.MiddleLeft;
            BtnAjustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAjustes.UseVisualStyleBackColor = false;
            BtnAjustes.Click += BtnAjustes_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.Cursor = Cursors.Hand;
            BtnReportes.Dock = DockStyle.Top;
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            BtnReportes.ForeColor = Color.Gainsboro;
            BtnReportes.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            BtnReportes.IconColor = Color.White;
            BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnReportes.IconSize = 40;
            BtnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReportes.Location = new Point(0, 323);
            BtnReportes.Margin = new Padding(3, 4, 3, 4);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(214, 56);
            BtnReportes.TabIndex = 3;
            BtnReportes.Text = "Reportes";
            BtnReportes.TextAlign = ContentAlignment.MiddleLeft;
            BtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReportes.UseVisualStyleBackColor = true;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnCreditos
            // 
            BtnCreditos.Cursor = Cursors.Hand;
            BtnCreditos.Dock = DockStyle.Top;
            BtnCreditos.FlatAppearance.BorderSize = 0;
            BtnCreditos.FlatStyle = FlatStyle.Flat;
            BtnCreditos.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            BtnCreditos.ForeColor = Color.Gainsboro;
            BtnCreditos.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            BtnCreditos.IconColor = Color.White;
            BtnCreditos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCreditos.IconSize = 40;
            BtnCreditos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCreditos.Location = new Point(0, 267);
            BtnCreditos.Margin = new Padding(3, 4, 3, 4);
            BtnCreditos.Name = "BtnCreditos";
            BtnCreditos.Size = new Size(214, 56);
            BtnCreditos.TabIndex = 2;
            BtnCreditos.Text = "Creditos";
            BtnCreditos.TextAlign = ContentAlignment.MiddleLeft;
            BtnCreditos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCreditos.UseVisualStyleBackColor = true;
            BtnCreditos.Click += BtnCreditos_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.Cursor = Cursors.Hand;
            BtnClientes.Dock = DockStyle.Top;
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            BtnClientes.ForeColor = Color.Gainsboro;
            BtnClientes.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            BtnClientes.IconColor = Color.White;
            BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClientes.IconSize = 40;
            BtnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnClientes.Location = new Point(0, 211);
            BtnClientes.Margin = new Padding(3, 4, 3, 4);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(214, 56);
            BtnClientes.TabIndex = 1;
            BtnClientes.Text = "Clientes";
            BtnClientes.TextAlign = ContentAlignment.MiddleLeft;
            BtnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.Controls.Add(BtnAccionMenu);
            PanelLogo.Controls.Add(btnInicio);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(3, 4, 3, 4);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(214, 211);
            PanelLogo.TabIndex = 0;
            PanelLogo.Paint += PanelLogo_Paint;
            // 
            // BtnAccionMenu
            // 
            BtnAccionMenu.BackColor = Color.FromArgb(25, 55, 110);
            BtnAccionMenu.Cursor = Cursors.Hand;
            BtnAccionMenu.ForeColor = Color.GhostWhite;
            BtnAccionMenu.IconChar = FontAwesome.Sharp.IconChar.ArrowsLeftRightToLine;
            BtnAccionMenu.IconColor = Color.GhostWhite;
            BtnAccionMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAccionMenu.IconSize = 34;
            BtnAccionMenu.Location = new Point(9, 15);
            BtnAccionMenu.Margin = new Padding(3, 4, 3, 4);
            BtnAccionMenu.Name = "BtnAccionMenu";
            BtnAccionMenu.Size = new Size(34, 40);
            BtnAccionMenu.TabIndex = 1;
            BtnAccionMenu.TabStop = false;
            BtnAccionMenu.Click += iconPictureBox1_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(30, 23);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(160, 157);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // Lb_NombreUsuario
            // 
            Lb_NombreUsuario.AutoSize = true;
            Lb_NombreUsuario.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            Lb_NombreUsuario.Location = new Point(47, 24);
            Lb_NombreUsuario.Name = "Lb_NombreUsuario";
            Lb_NombreUsuario.Size = new Size(56, 23);
            Lb_NombreUsuario.TabIndex = 0;
            Lb_NombreUsuario.Text = "label1";
            // 
            // pb_Imagen_Usuario
            // 
            pb_Imagen_Usuario.Image = (Image)resources.GetObject("pb_Imagen_Usuario.Image");
            pb_Imagen_Usuario.Location = new Point(3, 15);
            pb_Imagen_Usuario.Margin = new Padding(3, 4, 3, 4);
            pb_Imagen_Usuario.Name = "pb_Imagen_Usuario";
            pb_Imagen_Usuario.Size = new Size(34, 32);
            pb_Imagen_Usuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Imagen_Usuario.TabIndex = 0;
            pb_Imagen_Usuario.TabStop = false;
            pb_Imagen_Usuario.Paint += pb_Imagen_Usuario_Paint;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(16, 40, 85);
            PanelSuperior.Controls.Add(panel3);
            PanelSuperior.Controls.Add(IconoFormularioActual);
            PanelSuperior.Controls.Add(TituloFormularioHijo);
            PanelSuperior.Controls.Add(Panel_Botones_Ventana);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Margin = new Padding(3, 4, 3, 4);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(812, 65);
            PanelSuperior.TabIndex = 1;
            PanelSuperior.MouseDown += PanelSuperior_MouseDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(pb_Imagen_Usuario);
            panel3.Controls.Add(Lb_NombreUsuario);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(471, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 65);
            panel3.TabIndex = 7;
            // 
            // IconoFormularioActual
            // 
            IconoFormularioActual.BackColor = Color.FromArgb(16, 40, 85);
            IconoFormularioActual.ForeColor = Color.GhostWhite;
            IconoFormularioActual.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoFormularioActual.IconColor = Color.GhostWhite;
            IconoFormularioActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoFormularioActual.IconSize = 34;
            IconoFormularioActual.Location = new Point(22, 16);
            IconoFormularioActual.Margin = new Padding(3, 4, 3, 4);
            IconoFormularioActual.Name = "IconoFormularioActual";
            IconoFormularioActual.Size = new Size(34, 40);
            IconoFormularioActual.TabIndex = 0;
            IconoFormularioActual.TabStop = false;
            // 
            // TituloFormularioHijo
            // 
            TituloFormularioHijo.AutoSize = true;
            TituloFormularioHijo.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            TituloFormularioHijo.ForeColor = Color.GhostWhite;
            TituloFormularioHijo.Location = new Point(62, 24);
            TituloFormularioHijo.Name = "TituloFormularioHijo";
            TituloFormularioHijo.Size = new Size(53, 23);
            TituloFormularioHijo.TabIndex = 1;
            TituloFormularioHijo.Text = "Inicio";
            // 
            // Panel_Botones_Ventana
            // 
            Panel_Botones_Ventana.Controls.Add(btnMinimizar);
            Panel_Botones_Ventana.Controls.Add(btnCerrar);
            Panel_Botones_Ventana.Controls.Add(btnMaximizar);
            Panel_Botones_Ventana.Dock = DockStyle.Right;
            Panel_Botones_Ventana.Location = new Point(700, 0);
            Panel_Botones_Ventana.Margin = new Padding(3, 4, 3, 4);
            Panel_Botones_Ventana.Name = "Panel_Botones_Ventana";
            Panel_Botones_Ventana.Size = new Size(112, 65);
            Panel_Botones_Ventana.TabIndex = 6;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(16, 40, 85);
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.ForeColor = Color.Gainsboro;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.Gainsboro;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 29;
            btnMinimizar.Location = new Point(7, 3);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(29, 33);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(16, 40, 85);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.ForeColor = Color.Gainsboro;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCerrar.IconColor = Color.Gainsboro;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 29;
            btnCerrar.Location = new Point(73, 3);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 33);
            btnCerrar.TabIndex = 2;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.FromArgb(16, 40, 85);
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.ForeColor = Color.Gainsboro;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximizar.IconColor = Color.Gainsboro;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.IconSize = 29;
            btnMaximizar.Location = new Point(41, 3);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(29, 33);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // PanelSombra
            // 
            PanelSombra.BackColor = Color.FromArgb(14, 35, 65);
            PanelSombra.Dock = DockStyle.Top;
            PanelSombra.Location = new Point(0, 0);
            PanelSombra.Margin = new Padding(3, 4, 3, 4);
            PanelSombra.Name = "PanelSombra";
            PanelSombra.Size = new Size(812, 7);
            PanelSombra.TabIndex = 2;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(60, 80, 100);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 0);
            PanelContenedor.Margin = new Padding(3, 4, 3, 4);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(812, 535);
            PanelContenedor.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 35, 65);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(214, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 600);
            panel1.TabIndex = 3;
            // 
            // PanelContenedor_2
            // 
            PanelContenedor_2.Controls.Add(panel2);
            PanelContenedor_2.Controls.Add(PanelSuperior);
            PanelContenedor_2.Dock = DockStyle.Fill;
            PanelContenedor_2.Location = new Point(220, 0);
            PanelContenedor_2.Margin = new Padding(3, 4, 3, 4);
            PanelContenedor_2.Name = "PanelContenedor_2";
            PanelContenedor_2.Size = new Size(812, 600);
            PanelContenedor_2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(PanelSombra);
            panel2.Controls.Add(PanelContenedor);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 535);
            panel2.TabIndex = 4;
            // 
            // animationTimer
            // 
            animationTimer.Tick += animationTimer_Tick;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 600);
            Controls.Add(PanelContenedor_2);
            Controls.Add(panel1);
            Controls.Add(PanelMenu);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Main";
            Text = "Sistema de Control de Cuentas";
            WindowState = FormWindowState.Maximized;
            PanelMenu.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnAccionMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Imagen_Usuario).EndInit();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormularioActual).EndInit();
            Panel_Botones_Ventana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            PanelContenedor_2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelLogo;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnCreditos;
        private FontAwesome.Sharp.IconButton BtnAjustes;
        private PictureBox btnInicio;
        private Panel PanelSuperior;
        private FontAwesome.Sharp.IconPictureBox IconoFormularioActual;
        private Label TituloFormularioHijo;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private Panel PanelSombra;
        private Panel PanelContenedor;
        private Panel panel1;
        private Panel PanelContenedor_2;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox BtnAccionMenu;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pb_Imagen_Usuario;
        private Label Lb_NombreUsuario;
        private Panel panel3;
        private Panel Panel_Botones_Ventana;
    }
}
