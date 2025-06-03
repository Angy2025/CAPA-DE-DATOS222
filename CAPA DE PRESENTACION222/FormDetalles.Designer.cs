namespace CAPA_DE_PRESENTACION222
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
            lblDetalles = new Label();
            textBoxResumen = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblDetalles
            // 
            lblDetalles.AutoSize = true;
            lblDetalles.BackColor = SystemColors.ActiveCaptionText;
            lblDetalles.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalles.ForeColor = SystemColors.ControlLightLight;
            lblDetalles.Location = new Point(124, 31);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(245, 23);
            lblDetalles.TabIndex = 0;
            lblDetalles.Text = "DETALLES DEL EVENTO";
            // 
            // textBoxResumen
            // 
            textBoxResumen.BackColor = Color.White;
            textBoxResumen.Location = new Point(149, 89);
            textBoxResumen.Multiline = true;
            textBoxResumen.Name = "textBoxResumen";
            textBoxResumen.ReadOnly = true;
            textBoxResumen.Size = new Size(211, 184);
            textBoxResumen.TabIndex = 5;
            textBoxResumen.TextChanged += textBoxResumen_TextChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaptionText;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(190, 292);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // FormDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(483, 384);
            Controls.Add(btnClose);
            Controls.Add(textBoxResumen);
            Controls.Add(lblDetalles);
            Name = "FormDetalles";
            Text = "FormDetalles";
            Load += FormDetalles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDetalles;
        private Label lblName;
        private Label lblPlace;
        private Label lblDate;
        private Label lblTipo;
        private TextBox textBoxResumen;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnClose;
    }
}