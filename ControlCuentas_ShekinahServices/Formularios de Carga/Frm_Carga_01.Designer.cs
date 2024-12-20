namespace ControlCuentas_ShekinahServices.Formularios_de_Carga
{
    partial class Frm_Carga_01
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
            PcCarga01 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PcCarga01).BeginInit();
            SuspendLayout();
            // 
            // PcCarga01
            // 
            PcCarga01.BackColor = Color.Transparent;
            PcCarga01.Dock = DockStyle.Fill;
            PcCarga01.Image = Properties.Resources.Carga01;
            PcCarga01.Location = new Point(0, 0);
            PcCarga01.Name = "PcCarga01";
            PcCarga01.Size = new Size(262, 183);
            PcCarga01.SizeMode = PictureBoxSizeMode.StretchImage;
            PcCarga01.TabIndex = 0;
            PcCarga01.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(48, 48, 53);
            label2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(81, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 4;
            label2.Text = "Cargando..";
            // 
            // Frm_Carga_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 183);
            Controls.Add(label2);
            Controls.Add(PcCarga01);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Carga_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Carga_01";
            ((System.ComponentModel.ISupportInitialize)PcCarga01).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PcCarga01;
        private Label label2;
    }
}