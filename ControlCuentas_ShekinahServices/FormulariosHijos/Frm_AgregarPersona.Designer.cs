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
            BtnFotografia = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            CbSexo = new ComboBox();
            EpCedula = new ErrorProvider(components);
            EpTelefono = new ErrorProvider(components);
            EpPrimerNombre = new ErrorProvider(components);
            EpPrimerApellido = new ErrorProvider(components);
            EpFechaNacimiento = new ErrorProvider(components);
            EpDireccion = new ErrorProvider(components);
            OpenFile_Foto_Persona = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PicPhotoCliente).BeginInit();
            PanelCentral.SuspendLayout();
            GrpAgregarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label2.Location = new Point(42, 50);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 5;
            label2.Text = "No. Cedula";
            // 
            // txtNoCedulaCliente
            // 
            txtNoCedulaCliente.BackColor = Color.Gainsboro;
            txtNoCedulaCliente.BorderStyle = BorderStyle.None;
            txtNoCedulaCliente.CharacterCasing = CharacterCasing.Upper;
            txtNoCedulaCliente.Font = new Font("Palatino Linotype", 12F);
            txtNoCedulaCliente.Location = new Point(164, 50);
            txtNoCedulaCliente.Name = "txtNoCedulaCliente";
            txtNoCedulaCliente.Size = new Size(197, 22);
            txtNoCedulaCliente.TabIndex = 0;
            txtNoCedulaCliente.TextAlign = HorizontalAlignment.Center;
            txtNoCedulaCliente.Leave += txtNoCedulaCliente_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 89);
            label1.Name = "label1";
            label1.Size = new Size(118, 22);
            label1.TabIndex = 7;
            label1.Text = "Primer Nombre";
            // 
            // txtPrimerNombreCliente
            // 
            txtPrimerNombreCliente.BackColor = Color.Gainsboro;
            txtPrimerNombreCliente.BorderStyle = BorderStyle.None;
            txtPrimerNombreCliente.CharacterCasing = CharacterCasing.Upper;
            txtPrimerNombreCliente.Font = new Font("Palatino Linotype", 12F);
            txtPrimerNombreCliente.Location = new Point(164, 89);
            txtPrimerNombreCliente.Name = "txtPrimerNombreCliente";
            txtPrimerNombreCliente.Size = new Size(200, 22);
            txtPrimerNombreCliente.TabIndex = 1;
            txtPrimerNombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(373, 89);
            label3.Name = "label3";
            label3.Size = new Size(131, 22);
            label3.TabIndex = 9;
            label3.Text = "Segundo Nombre";
            // 
            // txtSegundoNombreCliente
            // 
            txtSegundoNombreCliente.BackColor = Color.Gainsboro;
            txtSegundoNombreCliente.BorderStyle = BorderStyle.None;
            txtSegundoNombreCliente.CharacterCasing = CharacterCasing.Upper;
            txtSegundoNombreCliente.Font = new Font("Palatino Linotype", 12F);
            txtSegundoNombreCliente.Location = new Point(525, 89);
            txtSegundoNombreCliente.Name = "txtSegundoNombreCliente";
            txtSegundoNombreCliente.Size = new Size(190, 22);
            txtSegundoNombreCliente.TabIndex = 2;
            txtSegundoNombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(116, 22);
            label4.TabIndex = 11;
            label4.Text = "Primer Apellido";
            // 
            // txtPrimerApellidoCliente
            // 
            txtPrimerApellidoCliente.BackColor = Color.Gainsboro;
            txtPrimerApellidoCliente.BorderStyle = BorderStyle.None;
            txtPrimerApellidoCliente.CharacterCasing = CharacterCasing.Upper;
            txtPrimerApellidoCliente.Font = new Font("Palatino Linotype", 12F);
            txtPrimerApellidoCliente.Location = new Point(164, 128);
            txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            txtPrimerApellidoCliente.Size = new Size(200, 22);
            txtPrimerApellidoCliente.TabIndex = 3;
            txtPrimerApellidoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(375, 128);
            label5.Name = "label5";
            label5.Size = new Size(129, 22);
            label5.TabIndex = 13;
            label5.Text = "Segundo Apellido";
            // 
            // txtSegundoApellidoCliente
            // 
            txtSegundoApellidoCliente.BackColor = Color.Gainsboro;
            txtSegundoApellidoCliente.BorderStyle = BorderStyle.None;
            txtSegundoApellidoCliente.CharacterCasing = CharacterCasing.Upper;
            txtSegundoApellidoCliente.Font = new Font("Palatino Linotype", 12F);
            txtSegundoApellidoCliente.Location = new Point(525, 128);
            txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            txtSegundoApellidoCliente.Size = new Size(190, 22);
            txtSegundoApellidoCliente.TabIndex = 4;
            txtSegundoApellidoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // PicPhotoCliente
            // 
            PicPhotoCliente.Cursor = Cursors.Hand;
            PicPhotoCliente.Image = Properties.Resources.AgregarPersona;
            PicPhotoCliente.Location = new Point(15, 306);
            PicPhotoCliente.Name = "PicPhotoCliente";
            PicPhotoCliente.Size = new Size(49, 56);
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
            btnGuardar.Location = new Point(569, 323);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 30);
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
            btnCancelar.Location = new Point(678, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 30);
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
            dtFechaNacCliente.Location = new Point(164, 165);
            dtFechaNacCliente.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtFechaNacCliente.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dtFechaNacCliente.Name = "dtFechaNacCliente";
            dtFechaNacCliente.Size = new Size(197, 29);
            dtFechaNacCliente.TabIndex = 5;
            dtFechaNacCliente.Value = new DateTime(2002, 12, 31, 0, 0, 0, 0);
            dtFechaNacCliente.Leave += dtFechaNacCliente_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 165);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 19;
            label7.Text = "Fec. Nacimiento";
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.BackColor = Color.Gainsboro;
            txtTelefonoCliente.BorderStyle = BorderStyle.None;
            txtTelefonoCliente.Font = new Font("Palatino Linotype", 12F);
            txtTelefonoCliente.Location = new Point(568, 265);
            txtTelefonoCliente.MaxLength = 8;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(190, 22);
            txtTelefonoCliente.TabIndex = 6;
            txtTelefonoCliente.TextAlign = HorizontalAlignment.Center;
            txtTelefonoCliente.Visible = false;
            txtTelefonoCliente.KeyPress += txtTelefonoCliente_KeyPress;
            txtTelefonoCliente.Leave += txtTelefonoCliente_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(496, 265);
            label8.Name = "label8";
            label8.Size = new Size(66, 22);
            label8.TabIndex = 21;
            label8.Text = "Teléfono";
            label8.Visible = false;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.BackColor = Color.Gainsboro;
            txtDireccionCliente.BorderStyle = BorderStyle.None;
            txtDireccionCliente.CharacterCasing = CharacterCasing.Upper;
            txtDireccionCliente.Font = new Font("Palatino Linotype", 12F);
            txtDireccionCliente.Location = new Point(207, 306);
            txtDireccionCliente.Multiline = true;
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(551, 45);
            txtDireccionCliente.TabIndex = 7;
            txtDireccionCliente.TextAlign = HorizontalAlignment.Center;
            txtDireccionCliente.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(112, 306);
            label9.Name = "label9";
            label9.Size = new Size(74, 22);
            label9.TabIndex = 23;
            label9.Text = "Dirección";
            label9.Visible = false;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(16, 40, 85);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(804, 10);
            PanelSuperior.TabIndex = 24;
            // 
            // Panel_Inferior
            // 
            Panel_Inferior.BackColor = Color.FromArgb(16, 40, 85);
            Panel_Inferior.Dock = DockStyle.Bottom;
            Panel_Inferior.Location = new Point(0, 378);
            Panel_Inferior.Name = "Panel_Inferior";
            Panel_Inferior.Size = new Size(804, 10);
            Panel_Inferior.TabIndex = 25;
            // 
            // Panel_Derecho
            // 
            Panel_Derecho.BackColor = Color.FromArgb(16, 40, 85);
            Panel_Derecho.Dock = DockStyle.Right;
            Panel_Derecho.Location = new Point(794, 10);
            Panel_Derecho.Name = "Panel_Derecho";
            Panel_Derecho.Size = new Size(10, 368);
            Panel_Derecho.TabIndex = 25;
            // 
            // Panel_Izquierdo
            // 
            Panel_Izquierdo.BackColor = Color.FromArgb(16, 40, 85);
            Panel_Izquierdo.Dock = DockStyle.Left;
            Panel_Izquierdo.Location = new Point(0, 10);
            Panel_Izquierdo.Name = "Panel_Izquierdo";
            Panel_Izquierdo.Size = new Size(10, 368);
            Panel_Izquierdo.TabIndex = 25;
            // 
            // PanelCentral
            // 
            PanelCentral.Controls.Add(GrpAgregarCliente);
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(10, 10);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(784, 368);
            PanelCentral.TabIndex = 26;
            // 
            // GrpAgregarCliente
            // 
            GrpAgregarCliente.BackColor = Color.FromArgb(25, 55, 110);
            GrpAgregarCliente.Controls.Add(BtnFotografia);
            GrpAgregarCliente.Controls.Add(pictureBox1);
            GrpAgregarCliente.Controls.Add(label6);
            GrpAgregarCliente.Controls.Add(CbSexo);
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
            GrpAgregarCliente.Name = "GrpAgregarCliente";
            GrpAgregarCliente.Size = new Size(784, 368);
            GrpAgregarCliente.TabIndex = 24;
            GrpAgregarCliente.TabStop = false;
            GrpAgregarCliente.Text = "Agregar Nueva Persona";
            // 
            // BtnFotografia
            // 
            BtnFotografia.BackColor = Color.FromArgb(45, 180, 50);
            BtnFotografia.Cursor = Cursors.Hand;
            BtnFotografia.FlatAppearance.BorderSize = 0;
            BtnFotografia.FlatStyle = FlatStyle.Flat;
            BtnFotografia.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            BtnFotografia.ForeColor = Color.White;
            BtnFotografia.Location = new Point(52, 211);
            BtnFotografia.Name = "BtnFotografia";
            BtnFotografia.Size = new Size(91, 30);
            BtnFotografia.TabIndex = 27;
            BtnFotografia.Text = "Foto";
            BtnFotografia.UseVisualStyleBackColor = false;
            BtnFotografia.Click += BtnFotografia_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(164, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 28);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(385, 172);
            label6.Name = "label6";
            label6.Size = new Size(42, 22);
            label6.TabIndex = 25;
            label6.Text = "Sexo";
            label6.Visible = false;
            // 
            // CbSexo
            // 
            CbSexo.Font = new Font("Palatino Linotype", 12F);
            CbSexo.FormattingEnabled = true;
            CbSexo.Location = new Point(525, 162);
            CbSexo.Name = "CbSexo";
            CbSexo.Size = new Size(190, 30);
            CbSexo.TabIndex = 24;
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
            // OpenFile_Foto_Persona
            // 
            OpenFile_Foto_Persona.FileName = "Foto_Persona";
            OpenFile_Foto_Persona.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // Frm_AgregarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 110);
            ClientSize = new Size(804, 388);
            Controls.Add(PanelCentral);
            Controls.Add(Panel_Izquierdo);
            Controls.Add(Panel_Derecho);
            Controls.Add(Panel_Inferior);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_AgregarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_AgregarPersona";
            KeyDown += Frm_AgregarPersona_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PicPhotoCliente).EndInit();
            PanelCentral.ResumeLayout(false);
            GrpAgregarCliente.ResumeLayout(false);
            GrpAgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ComboBox CbSexo;
        private Label label6;
        private Button BtnFotografia;
        private PictureBox pictureBox1;
        private OpenFileDialog OpenFile_Foto_Persona;
    }
}