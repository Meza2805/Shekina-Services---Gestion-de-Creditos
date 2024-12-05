namespace ControlCuentas_ShekinahServices.FormulariosHijos
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            pictureBox1 = new PictureBox();
            LbHoraActual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LbHoraActual
            // 
            LbHoraActual.Anchor = AnchorStyles.None;
            LbHoraActual.AutoSize = true;
            LbHoraActual.BackColor = Color.Transparent;
            LbHoraActual.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHoraActual.ForeColor = Color.White;
            LbHoraActual.Location = new Point(218, 275);
            LbHoraActual.Name = "LbHoraActual";
            LbHoraActual.Size = new Size(84, 25);
            LbHoraActual.TabIndex = 1;
            LbHoraActual.Text = "label1";
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 80, 100);
            ClientSize = new Size(876, 450);
            Controls.Add(LbHoraActual);
            Controls.Add(pictureBox1);
            Name = "Frm_Principal";
            Text = "Frm_Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LbHoraActual;
        private System.Windows.Forms.Timer timer1;
    }
}