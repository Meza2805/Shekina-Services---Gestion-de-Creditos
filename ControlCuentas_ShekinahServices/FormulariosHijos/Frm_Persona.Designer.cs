﻿namespace ControlCuentas_ShekinahServices.FormulariosHijos
{
    partial class Frm_Persona
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvPersona = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            txtBusqueda = new TextBox();
            panel2 = new Panel();
            PanelContenedorDgvClientes = new Panel();
            PanelIzquierdoClientes = new Panel();
            PanelDerechoBotonesClientes = new Panel();
            btnAgregarCliente = new Button();
            btnEliminarCliente = new Button();
            btnEditarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel2.SuspendLayout();
            PanelContenedorDgvClientes.SuspendLayout();
            PanelDerechoBotonesClientes.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersona
            // 
            dgvPersona.AllowUserToDeleteRows = false;
            dgvPersona.AllowUserToResizeColumns = false;
            dgvPersona.AllowUserToResizeRows = false;
            dgvPersona.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvPersona.BackgroundColor = Color.FromArgb(60, 80, 100);
            dgvPersona.BorderStyle = BorderStyle.None;
            dgvPersona.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersona.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(220, 110, 130);
            dataGridViewCellStyle5.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 110, 130);
            dataGridViewCellStyle5.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPersona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPersona.ColumnHeadersHeight = 30;
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPersona.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPersona.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPersona.EnableHeadersVisualStyles = false;
            dgvPersona.GridColor = Color.Gainsboro;
            dgvPersona.Location = new Point(0, 0);
            dgvPersona.MultiSelect = false;
            dgvPersona.Name = "dgvPersona";
            dgvPersona.ReadOnly = true;
            dgvPersona.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle7.Font = new Font("Palatino Linotype", 9.75F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPersona.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPersona.RowHeadersVisible = false;
            dgvPersona.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle8.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(227, 166, 177);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgvPersona.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersona.Size = new Size(657, 342);
            dgvPersona.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 80, 100);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBusqueda);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 108);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(220, 110, 130);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 26);
            label1.TabIndex = 4;
            label1.Text = "Listado de Clientes Registrados";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(60, 80, 100);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.ForeColor = Color.Gainsboro;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCerrar.IconColor = Color.Gainsboro;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 23;
            btnCerrar.Location = new Point(774, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 25);
            btnCerrar.TabIndex = 3;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 74);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 3;
            label2.Text = "Buscar Cliente";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Left;
            txtBusqueda.BackColor = Color.White;
            txtBusqueda.BorderStyle = BorderStyle.None;
            txtBusqueda.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(124, 74);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(396, 18);
            txtBusqueda.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 80, 100);
            panel2.Controls.Add(PanelContenedorDgvClientes);
            panel2.Controls.Add(PanelIzquierdoClientes);
            panel2.Controls.Add(PanelDerechoBotonesClientes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 342);
            panel2.TabIndex = 2;
            // 
            // PanelContenedorDgvClientes
            // 
            PanelContenedorDgvClientes.Controls.Add(dgvPersona);
            PanelContenedorDgvClientes.Dock = DockStyle.Fill;
            PanelContenedorDgvClientes.Location = new Point(23, 0);
            PanelContenedorDgvClientes.Name = "PanelContenedorDgvClientes";
            PanelContenedorDgvClientes.Size = new Size(657, 342);
            PanelContenedorDgvClientes.TabIndex = 10;
            // 
            // PanelIzquierdoClientes
            // 
            PanelIzquierdoClientes.Dock = DockStyle.Left;
            PanelIzquierdoClientes.Location = new Point(0, 0);
            PanelIzquierdoClientes.Name = "PanelIzquierdoClientes";
            PanelIzquierdoClientes.Size = new Size(23, 342);
            PanelIzquierdoClientes.TabIndex = 9;
            // 
            // PanelDerechoBotonesClientes
            // 
            PanelDerechoBotonesClientes.Controls.Add(btnAgregarCliente);
            PanelDerechoBotonesClientes.Controls.Add(btnEliminarCliente);
            PanelDerechoBotonesClientes.Controls.Add(btnEditarCliente);
            PanelDerechoBotonesClientes.Dock = DockStyle.Right;
            PanelDerechoBotonesClientes.Location = new Point(680, 0);
            PanelDerechoBotonesClientes.Name = "PanelDerechoBotonesClientes";
            PanelDerechoBotonesClientes.Size = new Size(120, 342);
            PanelDerechoBotonesClientes.TabIndex = 8;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(45, 180, 50);
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(17, 6);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(91, 30);
            btnAgregarCliente.TabIndex = 5;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.FromArgb(244, 34, 67);
            btnEliminarCliente.Cursor = Cursors.Hand;
            btnEliminarCliente.FlatAppearance.BorderSize = 0;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            btnEliminarCliente.ForeColor = Color.White;
            btnEliminarCliente.Location = new Point(17, 78);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(91, 30);
            btnEliminarCliente.TabIndex = 7;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.FromArgb(43, 123, 231);
            btnEditarCliente.Cursor = Cursors.Hand;
            btnEditarCliente.FlatAppearance.BorderSize = 0;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(17, 42);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(91, 30);
            btnEditarCliente.TabIndex = 6;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // Frm_Persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Frm_Persona";
            Text = "Frm_Persona";
            Load += Frm_Persona_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel2.ResumeLayout(false);
            PanelContenedorDgvClientes.ResumeLayout(false);
            PanelDerechoBotonesClientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersona;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private Label label1;
        private Label label2;
        private Panel PanelDerechoBotonesClientes;
        private Button btnEliminarCliente;
        private Button btnEditarCliente;
        private Button btnAgregarCliente;
        private Panel PanelIzquierdoClientes;
        private Panel PanelContenedorDgvClientes;
    }
}