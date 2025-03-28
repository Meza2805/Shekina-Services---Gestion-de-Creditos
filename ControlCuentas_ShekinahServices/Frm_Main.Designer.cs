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
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnFacturacion = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
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
            PanelMenu.Controls.Add(btnProveedores);
            PanelMenu.Controls.Add(btnFacturacion);
            PanelMenu.Controls.Add(btnProductos);
            PanelMenu.Controls.Add(BtnAjustes);
            PanelMenu.Controls.Add(BtnReportes);
            PanelMenu.Controls.Add(BtnCreditos);
            PanelMenu.Controls.Add(BtnClientes);
            PanelMenu.Controls.Add(PanelLogo);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(187, 531);
            PanelMenu.TabIndex = 0;
            PanelMenu.Paint += PanelMenu_Paint;
            // 
            // btnProveedores
            // 
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.Gainsboro;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btnProveedores.IconColor = Color.White;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 40;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(0, 410);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(187, 42);
            btnProveedores.TabIndex = 7;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Cursor = Cursors.Hand;
            btnFacturacion.Dock = DockStyle.Top;
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            btnFacturacion.ForeColor = Color.Gainsboro;
            btnFacturacion.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnFacturacion.IconColor = Color.White;
            btnFacturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturacion.IconSize = 40;
            btnFacturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new Point(0, 368);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(187, 42);
            btnFacturacion.TabIndex = 6;
            btnFacturacion.Text = "Facturacion";
            btnFacturacion.TextAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            btnProductos.ForeColor = Color.Gainsboro;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnProductos.IconColor = Color.White;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.IconSize = 40;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 326);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(187, 42);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
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
            BtnAjustes.Location = new Point(0, 284);
            BtnAjustes.Name = "BtnAjustes";
            BtnAjustes.Size = new Size(187, 42);
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
            BtnReportes.Location = new Point(0, 242);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(187, 42);
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
            BtnCreditos.Location = new Point(0, 200);
            BtnCreditos.Name = "BtnCreditos";
            BtnCreditos.Size = new Size(187, 42);
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
            BtnClientes.Location = new Point(0, 158);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(187, 42);
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
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(187, 158);
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
            BtnAccionMenu.IconSize = 30;
            BtnAccionMenu.Location = new Point(8, 11);
            BtnAccionMenu.Name = "BtnAccionMenu";
            BtnAccionMenu.Size = new Size(30, 30);
            BtnAccionMenu.TabIndex = 1;
            BtnAccionMenu.TabStop = false;
            BtnAccionMenu.Click += iconPictureBox1_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(26, 17);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(140, 118);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // Lb_NombreUsuario
            // 
            Lb_NombreUsuario.AutoSize = true;
            Lb_NombreUsuario.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            Lb_NombreUsuario.Location = new Point(41, 18);
            Lb_NombreUsuario.Name = "Lb_NombreUsuario";
            Lb_NombreUsuario.Size = new Size(45, 18);
            Lb_NombreUsuario.TabIndex = 0;
            Lb_NombreUsuario.Text = "label1";
            // 
            // pb_Imagen_Usuario
            // 
            pb_Imagen_Usuario.Image = (Image)resources.GetObject("pb_Imagen_Usuario.Image");
            pb_Imagen_Usuario.Location = new Point(3, 11);
            pb_Imagen_Usuario.Name = "pb_Imagen_Usuario";
            pb_Imagen_Usuario.Size = new Size(30, 24);
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
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(711, 49);
            PanelSuperior.TabIndex = 1;
            PanelSuperior.MouseDown += PanelSuperior_MouseDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(pb_Imagen_Usuario);
            panel3.Controls.Add(Lb_NombreUsuario);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(413, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 49);
            panel3.TabIndex = 7;
            // 
            // IconoFormularioActual
            // 
            IconoFormularioActual.BackColor = Color.FromArgb(16, 40, 85);
            IconoFormularioActual.ForeColor = Color.GhostWhite;
            IconoFormularioActual.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoFormularioActual.IconColor = Color.GhostWhite;
            IconoFormularioActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoFormularioActual.IconSize = 30;
            IconoFormularioActual.Location = new Point(19, 12);
            IconoFormularioActual.Name = "IconoFormularioActual";
            IconoFormularioActual.Size = new Size(30, 30);
            IconoFormularioActual.TabIndex = 0;
            IconoFormularioActual.TabStop = false;
            // 
            // TituloFormularioHijo
            // 
            TituloFormularioHijo.AutoSize = true;
            TituloFormularioHijo.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            TituloFormularioHijo.ForeColor = Color.GhostWhite;
            TituloFormularioHijo.Location = new Point(54, 18);
            TituloFormularioHijo.Name = "TituloFormularioHijo";
            TituloFormularioHijo.Size = new Size(43, 18);
            TituloFormularioHijo.TabIndex = 1;
            TituloFormularioHijo.Text = "Inicio";
            // 
            // Panel_Botones_Ventana
            // 
            Panel_Botones_Ventana.Controls.Add(btnMinimizar);
            Panel_Botones_Ventana.Controls.Add(btnCerrar);
            Panel_Botones_Ventana.Controls.Add(btnMaximizar);
            Panel_Botones_Ventana.Dock = DockStyle.Right;
            Panel_Botones_Ventana.Location = new Point(613, 0);
            Panel_Botones_Ventana.Name = "Panel_Botones_Ventana";
            Panel_Botones_Ventana.Size = new Size(98, 49);
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
            btnMinimizar.IconSize = 25;
            btnMinimizar.Location = new Point(6, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
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
            btnCerrar.IconSize = 25;
            btnCerrar.Location = new Point(64, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
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
            btnMaximizar.IconSize = 25;
            btnMaximizar.Location = new Point(36, 2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // PanelSombra
            // 
            PanelSombra.BackColor = Color.FromArgb(14, 35, 65);
            PanelSombra.Dock = DockStyle.Top;
            PanelSombra.Location = new Point(0, 0);
            PanelSombra.Name = "PanelSombra";
            PanelSombra.Size = new Size(711, 5);
            PanelSombra.TabIndex = 2;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(60, 80, 100);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(711, 482);
            PanelContenedor.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 35, 65);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(187, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 531);
            panel1.TabIndex = 3;
            // 
            // PanelContenedor_2
            // 
            PanelContenedor_2.Controls.Add(panel2);
            PanelContenedor_2.Controls.Add(PanelSuperior);
            PanelContenedor_2.Dock = DockStyle.Fill;
            PanelContenedor_2.Location = new Point(192, 0);
            PanelContenedor_2.Name = "PanelContenedor_2";
            PanelContenedor_2.Size = new Size(711, 531);
            PanelContenedor_2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(PanelSombra);
            panel2.Controls.Add(PanelContenedor);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 482);
            panel2.TabIndex = 4;
            // 
            // animationTimer
            // 
            animationTimer.Tick += animationTimer_Tick;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 531);
            Controls.Add(PanelContenedor_2);
            Controls.Add(panel1);
            Controls.Add(PanelMenu);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnFacturacion;
        private FontAwesome.Sharp.IconButton btnProveedores;
    }
}
