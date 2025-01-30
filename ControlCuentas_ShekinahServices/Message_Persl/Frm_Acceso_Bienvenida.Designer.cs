namespace ControlCuentas_ShekinahServices.Message_Persl
{
    partial class Frm_Acceso_Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Acceso_Bienvenida));
            Panel_Acceso_Bienvenido = new Panel();
            lbTitulo = new Label();
            lbMensaje2 = new Label();
            lbMensaje = new Label();
            picImagenAccesoBienvenida = new PictureBox();
            btnAceptar = new Button();
            Panel_Acceso_Bienvenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenAccesoBienvenida).BeginInit();
            SuspendLayout();
            // 
            // Panel_Acceso_Bienvenido
            // 
            Panel_Acceso_Bienvenido.BackColor = Color.FromArgb(25, 55, 110);
            Panel_Acceso_Bienvenido.Controls.Add(lbTitulo);
            Panel_Acceso_Bienvenido.Controls.Add(lbMensaje2);
            Panel_Acceso_Bienvenido.Controls.Add(lbMensaje);
            Panel_Acceso_Bienvenido.Controls.Add(picImagenAccesoBienvenida);
            Panel_Acceso_Bienvenido.Controls.Add(btnAceptar);
            Panel_Acceso_Bienvenido.Dock = DockStyle.Fill;
            Panel_Acceso_Bienvenido.Location = new Point(0, 0);
            Panel_Acceso_Bienvenido.Margin = new Padding(3, 4, 3, 4);
            Panel_Acceso_Bienvenido.Name = "Panel_Acceso_Bienvenido";
            Panel_Acceso_Bienvenido.Size = new Size(586, 352);
            Panel_Acceso_Bienvenido.TabIndex = 0;
            Panel_Acceso_Bienvenido.Paint += Panel_Acceso_Bienvenido_Paint;
            // 
            // lbTitulo
            // 
            lbTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Location = new Point(152, 16);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(250, 38);
            lbTitulo.TabIndex = 17;
            lbTitulo.Text = "Acceso Concedido";
            // 
            // lbMensaje2
            // 
            lbMensaje2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbMensaje2.AutoSize = true;
            lbMensaje2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMensaje2.ForeColor = Color.White;
            lbMensaje2.Location = new Point(217, 239);
            lbMensaje2.Name = "lbMensaje2";
            lbMensaje2.Size = new Size(107, 32);
            lbMensaje2.TabIndex = 16;
            lbMensaje2.Text = "Mensaje";
            // 
            // lbMensaje
            // 
            lbMensaje.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMensaje.ForeColor = Color.White;
            lbMensaje.Location = new Point(217, 196);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(107, 32);
            lbMensaje.TabIndex = 15;
            lbMensaje.Text = "Mensaje";
            // 
            // picImagenAccesoBienvenida
            // 
            picImagenAccesoBienvenida.Image = (Image)resources.GetObject("picImagenAccesoBienvenida.Image");
            picImagenAccesoBienvenida.Location = new Point(237, 67);
            picImagenAccesoBienvenida.Margin = new Padding(3, 4, 3, 4);
            picImagenAccesoBienvenida.Name = "picImagenAccesoBienvenida";
            picImagenAccesoBienvenida.Size = new Size(115, 115);
            picImagenAccesoBienvenida.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagenAccesoBienvenida.TabIndex = 14;
            picImagenAccesoBienvenida.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(45, 180, 50);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(217, 299);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(135, 40);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Frm_Acceso_Bienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 352);
            Controls.Add(Panel_Acceso_Bienvenido);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Acceso_Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Acceso_Bienvenida";
            Panel_Acceso_Bienvenido.ResumeLayout(false);
            Panel_Acceso_Bienvenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenAccesoBienvenida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Acceso_Bienvenido;
        private Label lbMensaje;
        private PictureBox picImagenAccesoBienvenida;
        private Button btnAceptar;
        private Label lbMensaje2;
        private Label lbTitulo;
    }
}