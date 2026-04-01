namespace ConversorUnidadesTecNM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCantidad = new TextBox();
            cmbOpcion = new ComboBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Tahoma", 9F);
            txtCantidad.ForeColor = SystemColors.ActiveCaptionText;
            txtCantidad.Location = new Point(12, 87);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 22);
            txtCantidad.TabIndex = 0;
            // 
            // cmbOpcion
            // 
            cmbOpcion.Font = new Font("Tahoma", 9F);
            cmbOpcion.ForeColor = SystemColors.ActiveCaptionText;
            cmbOpcion.FormattingEnabled = true;
            cmbOpcion.Items.AddRange(new object[] { "Pesos", "Dólar", "Euros" });
            cmbOpcion.Location = new Point(307, 87);
            cmbOpcion.Name = "cmbOpcion";
            cmbOpcion.Size = new Size(121, 22);
            cmbOpcion.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(12, 144);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Convertir";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.Control;
            lblResultado.Location = new Point(307, 144);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(102, 18);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(166, 14);
            label1.TabIndex = 4;
            label1.Text = "Cantidad en Pesos Mexicanos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(307, 61);
            label2.Name = "label2";
            label2.Size = new Size(174, 14);
            label2.TabIndex = 5;
            label2.Text = "Selecciona moneda de destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Dubai", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(245, 25);
            label3.TabIndex = 6;
            label3.Text = "Conversión de moneda internacional.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.wallpaperForm;
            ClientSize = new Size(728, 426);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(cmbOpcion);
            Controls.Add(txtCantidad);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversor de Divisas TecNM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private ComboBox cmbOpcion;
        private Button btnCalcular;
        private Label lblResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
