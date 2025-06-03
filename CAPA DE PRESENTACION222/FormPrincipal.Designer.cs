namespace CAPA_DE_PRESENTACION222
{
    partial class FormPrincipal
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
            lblTitulo = new Label();
            btnResumen = new Button();
            dgvDatos = new DataGridView();
            lblSeleccion = new Label();
            comboBoxTipo = new ComboBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Black;
            lblTitulo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(96, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(345, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NEXUS EVENT MANAGMENT \r\n";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.Click += label1_Click;
            // 
            // btnResumen
            // 
            btnResumen.BackColor = Color.Black;
            btnResumen.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.ForeColor = SystemColors.ControlLightLight;
            btnResumen.Location = new Point(151, 286);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(214, 29);
            btnResumen.TabIndex = 4;
            btnResumen.Text = "Ver Resumen del Evento";
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += btnResumen_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = SystemColors.HighlightText;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(108, 82);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(300, 188);
            dgvDatos.TabIndex = 5;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.BackColor = Color.White;
            lblSeleccion.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccion.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccion.Location = new Point(49, 387);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(134, 20);
            lblSeleccion.TabIndex = 6;
            lblSeleccion.Text = "Tipo de Eventos";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Eventos Culturales", "Eventos Deportivos" });
            comboBoxTipo.Location = new Point(277, 381);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(151, 29);
            comboBoxTipo.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(165, 434);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 29);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar Evento";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(526, 596);
            Controls.Add(btnBuscar);
            Controls.Add(comboBoxTipo);
            Controls.Add(lblSeleccion);
            Controls.Add(dgvDatos);
            Controls.Add(btnResumen);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label2;
        private Button btnCul;
        private Button btnResumen;
        private DataGridView dgvDatos;
        private Label lblSeleccion;
        private ComboBox comboBoxTipo;
        private Button btnBuscar;
    }
}
