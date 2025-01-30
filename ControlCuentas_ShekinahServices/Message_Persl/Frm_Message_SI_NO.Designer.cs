namespace ControlCuentas_ShekinahServices.MessageBox_Personalizados
{
    partial class Frm_Message_SI_NO
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
            pictureBox1 = new PictureBox();
            lbMensaje = new Label();
            PanelSombra = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnNo = new Button();
            btnSi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Question02;
            pictureBox1.Location = new Point(164, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lbMensaje
            // 
            lbMensaje.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMensaje.ForeColor = Color.White;
            lbMensaje.Location = new Point(164, 123);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(87, 26);
            lbMensaje.TabIndex = 11;
            lbMensaje.Text = "Mensaje";
            lbMensaje.Click += lbMensaje_Click;
            // 
            // PanelSombra
            // 
            PanelSombra.BackColor = Color.FromArgb(14, 35, 65);
            PanelSombra.Dock = DockStyle.Bottom;
            PanelSombra.Location = new Point(0, 203);
            PanelSombra.Name = "PanelSombra";
            PanelSombra.Size = new Size(405, 5);
            PanelSombra.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 35, 65);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 5);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 35, 65);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(400, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 203);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 35, 65);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 203);
            panel3.TabIndex = 14;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(244, 34, 67);
            btnNo.Cursor = Cursors.Hand;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(224, 166);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(91, 30);
            btnNo.TabIndex = 15;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click_1;
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.FromArgb(43, 123, 231);
            btnSi.Cursor = Cursors.Hand;
            btnSi.FlatAppearance.BorderSize = 0;
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnSi.ForeColor = Color.White;
            btnSi.Location = new Point(86, 166);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(91, 30);
            btnSi.TabIndex = 14;
            btnSi.Text = "Si";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click_1;
            // 
            // Frm_Message_SI_NO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(25, 55, 110);
            ClientSize = new Size(405, 208);
            Controls.Add(btnNo);
            Controls.Add(panel1);
            Controls.Add(btnSi);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PanelSombra);
            Controls.Add(lbMensaje);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Message_SI_NO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_MessageBox_SI_NO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lbMensaje;
        private Panel PanelSombra;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnNo;
        private Button btnSi;
    }
}