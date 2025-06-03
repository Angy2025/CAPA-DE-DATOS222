namespace CAPA_DE_PRESENTACION_A
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnDep = new Button();
            btnCul = new Button();
            btnBuscar = new Button();
            btnResumen = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(165, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(331, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nexus Event Managment";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.descargar__6_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(370, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 171);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.descargar__2_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(62, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 171);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnDep
            // 
            btnDep.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDep.Location = new Point(397, 317);
            btnDep.Name = "btnDep";
            btnDep.Size = new Size(172, 29);
            btnDep.TabIndex = 3;
            btnDep.Text = "Eventos Deportivos";
            btnDep.UseVisualStyleBackColor = true;
            // 
            // btnCul
            // 
            btnCul.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCul.Location = new Point(81, 317);
            btnCul.Name = "btnCul";
            btnCul.Size = new Size(169, 29);
            btnCul.TabIndex = 4;
            btnCul.Text = "Eventos Culturales";
            btnCul.UseVisualStyleBackColor = true;
            btnCul.Click += this.btnCul_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(279, 376);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar Evento";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            btnResumen.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.Location = new Point(211, 627);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(228, 29);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Ver Resumen del Evento";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.BackgroundColor = Color.PeachPuff;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(104, 427);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(430, 172);
            dgvDatos.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(680, 720);
            Controls.Add(dgvDatos);
            Controls.Add(btnResumen);
            Controls.Add(btnBuscar);
            Controls.Add(btnCul);
            Controls.Add(btnDep);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnDep;
        private Button btnCul;
        private Button btnBuscar;
        private Button btnResumen;
        private DataGridView dgvDatos;
    }
}
