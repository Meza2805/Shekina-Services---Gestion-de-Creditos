namespace ControlCuentas_ShekinahServices
{
    partial class Acceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            chk_MostrarContra = new CheckBox();
            lbTitutlo_Login = new Label();
            PicPhotoCliente = new PictureBox();
            btnCancelar = new Button();
            btnAcceder = new Button();
            txt_Usuario = new TextBox();
            lbUsuario = new Label();
            txt_Contrasenia = new TextBox();
            lbContrasenia = new Label();
            erP_Usuario = new ErrorProvider(components);
            Panel_Acceso = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PicPhotoCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erP_Usuario).BeginInit();
            Panel_Acceso.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chk_MostrarContra
            // 
            chk_MostrarContra.AutoSize = true;
            chk_MostrarContra.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_MostrarContra.ForeColor = Color.White;
            chk_MostrarContra.Location = new Point(64, 363);
            chk_MostrarContra.Name = "chk_MostrarContra";
            chk_MostrarContra.Size = new Size(164, 26);
            chk_MostrarContra.TabIndex = 16;
            chk_MostrarContra.Text = "Mostrar Contraseña";
            chk_MostrarContra.UseVisualStyleBackColor = true;
            chk_MostrarContra.CheckedChanged += chk_MostrarContra_CheckedChanged;
            // 
            // lbTitutlo_Login
            // 
            lbTitutlo_Login.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold);
            lbTitutlo_Login.ForeColor = Color.White;
            lbTitutlo_Login.Location = new Point(12, 19);
            lbTitutlo_Login.Name = "lbTitutlo_Login";
            lbTitutlo_Login.Size = new Size(267, 56);
            lbTitutlo_Login.TabIndex = 15;
            lbTitutlo_Login.Text = "Sistema de Control de Créditos";
            lbTitutlo_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PicPhotoCliente
            // 
            PicPhotoCliente.Cursor = Cursors.Hand;
            PicPhotoCliente.Image = Properties.Resources.security_protection_protect_key_password_login_108554;
            PicPhotoCliente.Location = new Point(96, 107);
            PicPhotoCliente.Name = "PicPhotoCliente";
            PicPhotoCliente.Size = new Size(111, 108);
            PicPhotoCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            PicPhotoCliente.TabIndex = 14;
            PicPhotoCliente.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 34, 67);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(149, 424);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 38);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(45, 180, 50);
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.Enabled = false;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(37, 424);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(103, 38);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.Gainsboro;
            txt_Usuario.BorderStyle = BorderStyle.None;
            txt_Usuario.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Usuario.Location = new Point(37, 261);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(215, 29);
            txt_Usuario.TabIndex = 0;
            txt_Usuario.TextAlign = HorizontalAlignment.Center;
            txt_Usuario.Leave += txt_Usuario_Leave;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Palatino Linotype", 14.25F);
            lbUsuario.ForeColor = Color.White;
            lbUsuario.Location = new Point(106, 227);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(77, 26);
            lbUsuario.TabIndex = 5;
            lbUsuario.Text = "Usuario";
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.BackColor = Color.White;
            txt_Contrasenia.BorderStyle = BorderStyle.None;
            txt_Contrasenia.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Contrasenia.Location = new Point(37, 331);
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.Size = new Size(215, 29);
            txt_Contrasenia.TabIndex = 1;
            txt_Contrasenia.TextAlign = HorizontalAlignment.Center;
            txt_Contrasenia.UseSystemPasswordChar = true;
            txt_Contrasenia.KeyDown += txt_Contrasenia_KeyDown;
            // 
            // lbContrasenia
            // 
            lbContrasenia.AutoSize = true;
            lbContrasenia.Font = new Font("Palatino Linotype", 14.25F);
            lbContrasenia.ForeColor = Color.White;
            lbContrasenia.Location = new Point(96, 298);
            lbContrasenia.Name = "lbContrasenia";
            lbContrasenia.Size = new Size(104, 26);
            lbContrasenia.TabIndex = 7;
            lbContrasenia.Text = "Contraseña";
            // 
            // erP_Usuario
            // 
            erP_Usuario.ContainerControl = this;
            erP_Usuario.Icon = (Icon)resources.GetObject("erP_Usuario.Icon");
            // 
            // Panel_Acceso
            // 
            Panel_Acceso.BackColor = Color.FromArgb(25, 55, 110);
            Panel_Acceso.Controls.Add(lbTitutlo_Login);
            Panel_Acceso.Controls.Add(chk_MostrarContra);
            Panel_Acceso.Controls.Add(lbContrasenia);
            Panel_Acceso.Controls.Add(PicPhotoCliente);
            Panel_Acceso.Controls.Add(txt_Contrasenia);
            Panel_Acceso.Controls.Add(btnCancelar);
            Panel_Acceso.Controls.Add(lbUsuario);
            Panel_Acceso.Controls.Add(btnAcceder);
            Panel_Acceso.Controls.Add(txt_Usuario);
            Panel_Acceso.Dock = DockStyle.Fill;
            Panel_Acceso.Location = new Point(0, 0);
            Panel_Acceso.Name = "Panel_Acceso";
            Panel_Acceso.Size = new Size(291, 510);
            Panel_Acceso.TabIndex = 26;
            Panel_Acceso.Paint += Panel_Acceso_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(Panel_Acceso);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 510);
            panel1.TabIndex = 28;
            // 
            // Acceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 510);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Acceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso";
            ((System.ComponentModel.ISupportInitialize)PicPhotoCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)erP_Usuario).EndInit();
            Panel_Acceso.ResumeLayout(false);
            Panel_Acceso.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Grp_Acceso;
        private PictureBox PicPhotoCliente;
        private Button btnCancelar;
        private Button btnAcceder;
        private TextBox txt_Usuario;
        private Label lbUsuario;
        private TextBox txt_Contrasenia;
        private Label lbContrasenia;
        private Label lbTitutlo_Login;
        private ErrorProvider erP_Usuario;
        private CheckBox chk_MostrarContra;
        private Panel Panel_Acceso;
        private Panel panel1;
    }
}