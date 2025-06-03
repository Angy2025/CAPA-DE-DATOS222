namespace CAPA_DE_PRESENTACION_A
{
    partial class FormDetalles
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
            lblDetalle = new Label();
            txtNombre = new TextBox();
            txtFecha = new TextBox();
            txtLugar = new TextBox();
            txtDescrip = new TextBox();
            lblTitulo = new Label();
            lblFecha = new Label();
            label4 = new Label();
            lblDescrip = new Label();
            SuspendLayout();
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.BackColor = Color.White;
            lblDetalle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.ForeColor = Color.Black;
            lblDetalle.Location = new Point(140, 39);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(246, 32);
            lblDetalle.TabIndex = 0;
            lblDetalle.Text = "Detalles Del Evento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(291, 109);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(227, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(291, 175);
            txtFecha.Multiline = true;
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(227, 34);
            txtFecha.TabIndex = 2;
            // 
            // txtLugar
            // 
            txtLugar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLugar.Location = new Point(291, 250);
            txtLugar.Multiline = true;
            txtLugar.Name = "txtLugar";
            txtLugar.ReadOnly = true;
            txtLugar.Size = new Size(227, 34);
            txtLugar.TabIndex = 3;
            // 
            // txtDescrip
            // 
            txtDescrip.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescrip.Location = new Point(291, 326);
            txtDescrip.Multiline = true;
            txtDescrip.Name = "txtDescrip";
            txtDescrip.ReadOnly = true;
            txtDescrip.Size = new Size(227, 36);
            txtDescrip.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(75, 123);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 20);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Nombre del Evento:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.White;
            lblFecha.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(75, 189);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(146, 20);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha del Evento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(75, 264);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 8;
            label4.Text = "Lugar del Evento:";
            // 
            // lblDescrip
            // 
            lblDescrip.AutoSize = true;
            lblDescrip.BackColor = SystemColors.Window;
            lblDescrip.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescrip.Location = new Point(75, 342);
            lblDescrip.Name = "lblDescrip";
            lblDescrip.Size = new Size(197, 20);
            lblDescrip.TabIndex = 9;
            lblDescrip.Text = "Descripcion del Evento: ";
            // 
            // FormDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(602, 423);
            Controls.Add(lblDescrip);
            Controls.Add(label4);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Controls.Add(txtDescrip);
            Controls.Add(txtLugar);
            Controls.Add(txtFecha);
            Controls.Add(txtNombre);
            Controls.Add(lblDetalle);
            Name = "FormDetalles";
            Text = "FormDetalles";
            Load += FormDetalles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetalle;
        private TextBox txtNombre;
        private TextBox txtFecha;
        private TextBox txtLugar;
        private TextBox txtDescrip;
        private Label label1;
        private Label lblTitulo;
        private Label lblFecha;
        private Label label4;
        private Label lblDescrip;
    }
}