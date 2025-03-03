namespace ControlCuentas_ShekinahServices.FormulariosHijos
{
    partial class Frm_AgregarPersona
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
            label2 = new Label();
            txtNoCedulaCliente = new TextBox();
            label1 = new Label();
            txtPrimerNombreCliente = new TextBox();
            label3 = new Label();
            txtSegundoNombreCliente = new TextBox();
            label4 = new Label();
            txtPrimerApellidoCliente = new TextBox();
            label5 = new Label();
            txtSegundoApellidoCliente = new TextBox();
            PicPhotoCliente = new PictureBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dtFechaNacCliente = new DateTimePicker();
            label7 = new Label();
            txtTelefonoCliente = new TextBox();
            label8 = new Label();
            txtDireccionCliente = new TextBox();
            label9 = new Label();
            PanelSuperior = new Panel();
            Panel_Inferior = new Panel();
            Panel_Derecho = new Panel();
            Panel_Izquierdo = new Panel();
            PanelCentral = new Panel();
            GrpAgregarCliente = new GroupBox();
            EpCedula = new ErrorProvider(components);
            EpTelefono = new ErrorProvider(components);
            EpPrimerNombre = new ErrorProvider(components);
            EpPrimerApellido = new ErrorProvider(components);
            EpFechaNacimiento = new ErrorProvider(components);
            EpDireccion = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)PicPhotoCliente).BeginInit();
            PanelCentral.SuspendLayout();
            GrpAgregarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EpCedula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpPrimerNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpPrimerApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpFechaNacimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpDireccion).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 67);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 5;
            label2.Text = "No. Cedula";
            // 
            // txtNoCedulaCliente
            // 
            txtNoCedulaCliente.BackColor = Color.Gainsboro;
            txtNoCedulaCliente.BorderStyle = BorderStyle.None;
            txtNoCedulaCliente.CharacterCasing = CharacterCasing.Upper;
            txtNoCedulaCliente.Font = new Font("Palatino Linotype", 12F);
            txtNoCedulaCliente.Location = new Point(187, 67);
            txtNoCedulaCliente.Margin = new Padding(3, 4, 3, 4);
            txtNoCedulaCliente.Name = "txtNoCedulaCliente";
            txtNoCedulaCliente.Size = new Size(225, 27);
            txtNoCedulaCliente.TabIndex = 0;
            txtNoCedulaCliente.TextAlign = HorizontalAlignment.Center;
            txtNoCedulaCliente.Leave += txtNoCedulaCliente_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 119);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 7;
            label1.Text = "Primer Nombre";
            // 
            // txtPrimerNombreCliente
            // 
            txtPrimerNombreCliente.BackColor = Color.Gainsboro;
            txtPrimerNombreCliente.BorderStyle = BorderStyle.None;
            txtPrimerNombreCliente.CharacterCasing = CharacterCasing.Upper;
            txtPrimerNombreCliente.Font = new Font("Palatino Linotype", 12F);
            txtPrimerNombreCliente.Location = new Point(187, 119);
            txtPrimerNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtPrimerNombreCliente.Name = "txtPrimerNombreCliente";
            txtPrimerNombreCliente.Size = new Size(228, 27);
            txtPrimerNombreCliente.TabIndex = 1;
            txtPrimerNombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(426, 119);
            label3.Name = "label3";
            label3.Size = new Size(172, 27);
            label3.TabIndex = 9;
            label3.Text = "Segundo Nombre";
            // 
            // txtSegundoNombreCliente
            // 
            txtSegundoNombreCliente.BackColor = Color.Gainsboro;
            txtSegundoNombreCliente.BorderStyle = BorderStyle.None;
            txtSegundoNombreCliente.CharacterCasing = CharacterCasing.Upper;
            txtSegundoNombreCliente.Font = new Font("Palatino Linotype", 12F);
            txtSegundoNombreCliente.Location = new Point(600, 119);
            txtSegundoNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtSegundoNombreCliente.Name = "txtSegundoNombreCliente";
            txtSegundoNombreCliente.Size = new Size(217, 27);
            txtSegundoNombreCliente.TabIndex = 2;
            txtSegundoNombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 170);
            label4.Name = "label4";
            label4.Size = new Size(157, 27);
            label4.TabIndex = 11;
            label4.Text = "Primer Apellido";
            // 
            // txtPrimerApellidoCliente
            // 
            txtPrimerApellidoCliente.BackColor = Color.Gainsboro;
            txtPrimerApellidoCliente.BorderStyle = BorderStyle.None;
            txtPrimerApellidoCliente.CharacterCasing = CharacterCasing.Upper;
            txtPrimerApellidoCliente.Font = new Font("Palatino Linotype", 12F);
            txtPrimerApellidoCliente.Location = new Point(187, 170);
            txtPrimerApellidoCliente.Margin = new Padding(3, 4, 3, 4);
            txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            txtPrimerApellidoCliente.Size = new Size(228, 27);
            txtPrimerApellidoCliente.TabIndex = 3;
            txtPrimerApellidoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(429, 170);
            label5.Name = "label5";
            label5.Size = new Size(174, 27);
            label5.TabIndex = 13;
            label5.Text = "Segundo Apellido";
            // 
            // txtSegundoApellidoCliente
            // 
            txtSegundoApellidoCliente.BackColor = Color.Gainsboro;
            txtSegundoApellidoCliente.BorderStyle = BorderStyle.None;
            txtSegundoApellidoCliente.CharacterCasing = CharacterCasing.Upper;
            txtSegundoApellidoCliente.Font = new Font("Palatino Linotype", 12F);
            txtSegundoApellidoCliente.Location = new Point(600, 170);
            txtSegundoApellidoCliente.Margin = new Padding(3, 4, 3, 4);
            txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            txtSegundoApellidoCliente.Size = new Size(217, 27);
            txtSegundoApellidoCliente.TabIndex = 4;
            txtSegundoApellidoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // PicPhotoCliente
            // 
            PicPhotoCliente.Cursor = Cursors.Hand;
            PicPhotoCliente.Image = Properties.Resources.AgregarPersona;
            PicPhotoCliente.Location = new Point(17, 366);
            PicPhotoCliente.Margin = new Padding(3, 4, 3, 4);
            PicPhotoCliente.Name = "PicPhotoCliente";
            PicPhotoCliente.Size = new Size(104, 117);
            PicPhotoCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            PicPhotoCliente.TabIndex = 14;
            PicPhotoCliente.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(45, 180, 50);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(650, 431);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 40);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(244, 34, 67);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(775, 431);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtFechaNacCliente
            // 
            dtFechaNacCliente.Cursor = Cursors.Hand;
            dtFechaNacCliente.Font = new Font("Palatino Linotype", 12F);
            dtFechaNacCliente.Format = DateTimePickerFormat.Short;
            dtFechaNacCliente.Location = new Point(187, 220);
            dtFechaNacCliente.Margin = new Padding(3, 4, 3, 4);
            dtFechaNacCliente.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtFechaNacCliente.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dtFechaNacCliente.Name = "dtFechaNacCliente";
            dtFechaNacCliente.Size = new Size(225, 34);
            dtFechaNacCliente.TabIndex = 5;
            dtFechaNacCliente.Value = new DateTime(2002, 12, 31, 0, 0, 0, 0);
            dtFechaNacCliente.Leave += dtFechaNacCliente_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 220);
            label7.Name = "label7";
            label7.Size = new Size(158, 27);
            label7.TabIndex = 19;
            label7.Text = "Fec. Nacimiento";
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.BackColor = Color.Gainsboro;
            txtTelefonoCliente.BorderStyle = BorderStyle.None;
            txtTelefonoCliente.Font = new Font("Palatino Linotype", 12F);
            txtTelefonoCliente.Location = new Point(600, 220);
            txtTelefonoCliente.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoCliente.MaxLength = 8;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(217, 27);
            txtTelefonoCliente.TabIndex = 6;
            txtTelefonoCliente.TextAlign = HorizontalAlignment.Center;
            txtTelefonoCliente.KeyPress += txtTelefonoCliente_KeyPress;
            txtTelefonoCliente.Leave += txtTelefonoCliente_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(429, 220);
            label8.Name = "label8";
            label8.Size = new Size(90, 27);
            label8.TabIndex = 21;
            label8.Text = "Teléfono";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = Color.Gainsboro;
            txtDireccionCliente.BorderStyle = BorderStyle.None;
            txtDireccionCliente.CharacterCasing = CharacterCasing.Upper;
            txtDireccionCliente.Font = new Font("Palatino Linotype", 12F);
            txtDireccionCliente.Location = new Point(187, 275);
            txtDireccionCliente.Margin = new Padding(3, 4, 3, 4);
            txtDireccionCliente.Multiline = true;
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(630, 60);
            txtDireccionCliente.TabIndex = 7;
            txtDireccionCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(79, 275);
            label9.Name = "label9";
            label9.Size = new Size(99, 27);
            label9.TabIndex = 23;
            label9.Text = "Dirección";
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(16, 40, 85);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Margin = new Padding(3, 4, 3, 4);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(919, 13);
            PanelSuperior.TabIndex = 24;
            // 
            // Panel_Inferior
            // 
            Panel_Inferior.BackColor = Color.FromArgb(16, 40, 85);
            Panel_Inferior.Dock = DockStyle.Bottom;
            Panel_Inferior.Location = new Point(0, 504);
            Panel_Inferior.Margin = new Padding(3, 4, 3, 4);
            Panel_Inferior.Name = "Panel_Inferior";
            Panel_Inferior.Size = new Size(919, 13);
            Panel_Inferior.TabIndex = 25;
            // 
            // Panel_Derecho
            // 
            Panel_Derecho.BackColor = Color.FromArgb(16, 40, 85);
            Panel_Derecho.Dock = DockStyle.Right;
            Panel_Derecho.Location = new Point(908, 13);
            Panel_Derecho.Margin = new Padding(3, 4, 3, 4);
            Panel_Derecho.Name = "Panel_Derecho";
            Panel_Derecho.Size = new Size(11, 491);
            Panel_Derecho.TabIndex = 25;
            // 
            // Panel_Izquierdo
            // 
            Panel_Izquierdo.BackColor = Color.FromArgb(16, 40, 85);
            Panel_Izquierdo.Dock = DockStyle.Left;
            Panel_Izquierdo.Location = new Point(0, 13);
            Panel_Izquierdo.Margin = new Padding(3, 4, 3, 4);
            Panel_Izquierdo.Name = "Panel_Izquierdo";
            Panel_Izquierdo.Size = new Size(11, 491);
            Panel_Izquierdo.TabIndex = 25;
            // 
            // PanelCentral
            // 
            PanelCentral.Controls.Add(GrpAgregarCliente);
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(11, 13);
            PanelCentral.Margin = new Padding(3, 4, 3, 4);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(897, 491);
            PanelCentral.TabIndex = 26;
            // 
            // GrpAgregarCliente
            // 
            GrpAgregarCliente.BackColor = Color.FromArgb(25, 55, 110);
            GrpAgregarCliente.Controls.Add(PicPhotoCliente);
            GrpAgregarCliente.Controls.Add(btnCancelar);
            GrpAgregarCliente.Controls.Add(label5);
            GrpAgregarCliente.Controls.Add(btnGuardar);
            GrpAgregarCliente.Controls.Add(txtNoCedulaCliente);
            GrpAgregarCliente.Controls.Add(dtFechaNacCliente);
            GrpAgregarCliente.Controls.Add(label2);
            GrpAgregarCliente.Controls.Add(txtSegundoApellidoCliente);
            GrpAgregarCliente.Controls.Add(txtPrimerNombreCliente);
            GrpAgregarCliente.Controls.Add(label7);
            GrpAgregarCliente.Controls.Add(label1);
            GrpAgregarCliente.Controls.Add(label4);
            GrpAgregarCliente.Controls.Add(label9);
            GrpAgregarCliente.Controls.Add(txtTelefonoCliente);
            GrpAgregarCliente.Controls.Add(txtSegundoNombreCliente);
            GrpAgregarCliente.Controls.Add(txtPrimerApellidoCliente);
            GrpAgregarCliente.Controls.Add(txtDireccionCliente);
            GrpAgregarCliente.Controls.Add(label8);
            GrpAgregarCliente.Controls.Add(label3);
            GrpAgregarCliente.Dock = DockStyle.Fill;
            GrpAgregarCliente.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold);
            GrpAgregarCliente.ForeColor = Color.FromArgb(220, 110, 130);
            GrpAgregarCliente.Location = new Point(0, 0);
            GrpAgregarCliente.Margin = new Padding(3, 4, 3, 4);
            GrpAgregarCliente.Name = "GrpAgregarCliente";
            GrpAgregarCliente.Padding = new Padding(3, 4, 3, 4);
            GrpAgregarCliente.Size = new Size(897, 491);
            GrpAgregarCliente.TabIndex = 24;
            GrpAgregarCliente.TabStop = false;
            GrpAgregarCliente.Text = "Agregar Nuevo Cliente";
            // 
            // EpCedula
            // 
            EpCedula.ContainerControl = this;
            // 
            // EpTelefono
            // 
            EpTelefono.ContainerControl = this;
            // 
            // EpPrimerNombre
            // 
            EpPrimerNombre.ContainerControl = this;
            // 
            // EpPrimerApellido
            // 
            EpPrimerApellido.ContainerControl = this;
            // 
            // EpFechaNacimiento
            // 
            EpFechaNacimiento.ContainerControl = this;
            // 
            // EpDireccion
            // 
            EpDireccion.ContainerControl = this;
            // 
            // Frm_AgregarPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 110);
            ClientSize = new Size(919, 517);
            Controls.Add(PanelCentral);
            Controls.Add(Panel_Izquierdo);
            Controls.Add(Panel_Derecho);
            Controls.Add(Panel_Inferior);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_AgregarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_AgregarPersona";
            KeyDown += Frm_AgregarPersona_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PicPhotoCliente).EndInit();
            PanelCentral.ResumeLayout(false);
            GrpAgregarCliente.ResumeLayout(false);
            GrpAgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EpCedula).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpPrimerNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpPrimerApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpFechaNacimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpDireccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox txtNoCedulaCliente;
        private Label label1;
        private TextBox txtPrimerNombreCliente;
        private Label label3;
        private TextBox txtSegundoNombreCliente;
        private Label label4;
        private TextBox txtPrimerApellidoCliente;
        private Label label5;
        private TextBox txtSegundoApellidoCliente;
        private PictureBox PicPhotoCliente;
        private Button btnGuardar;
        private Button btnCancelar;
        private DateTimePicker dtFechaNacCliente;
        private Label label7;
        private TextBox txtTelefonoCliente;
        private Label label8;
        private TextBox txtDireccionCliente;
        private Label label9;
        private Panel PanelSuperior;
        private Panel Panel_Inferior;
        private Panel Panel_Derecho;
        private Panel Panel_Izquierdo;
        private Panel PanelCentral;
        private GroupBox GrpAgregarCliente;
        private ErrorProvider EpCedula;
        private ErrorProvider EpTelefono;
        private ErrorProvider EpPrimerNombre;
        private ErrorProvider EpPrimerApellido;
        private ErrorProvider EpFechaNacimiento;
        private ErrorProvider EpDireccion;
    }
}