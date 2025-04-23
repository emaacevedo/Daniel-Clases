namespace PRUEBA
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
            label1 = new Label();
            txtPrimerValor = new TextBox();
            txtSegundoValor = new TextBox();
            label2 = new Label();
            btnAccion = new Button();
            label3 = new Label();
            cmbOperacion = new ComboBox();
            btnMensaje = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 145);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "primer valor: ";
            // 
            // txtPrimerValor
            // 
            txtPrimerValor.Location = new Point(142, 141);
            txtPrimerValor.Margin = new Padding(3, 4, 3, 4);
            txtPrimerValor.Name = "txtPrimerValor";
            txtPrimerValor.Size = new Size(212, 27);
            txtPrimerValor.TabIndex = 1;
            // 
            // txtSegundoValor
            // 
            txtSegundoValor.Location = new Point(142, 193);
            txtSegundoValor.Margin = new Padding(3, 4, 3, 4);
            txtSegundoValor.Name = "txtSegundoValor";
            txtSegundoValor.Size = new Size(212, 27);
            txtSegundoValor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 197);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 2;
            label2.Text = "segundo valor: ";
            // 
            // btnAccion
            // 
            btnAccion.Location = new Point(130, 255);
            btnAccion.Margin = new Padding(3, 4, 3, 4);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(86, 31);
            btnAccion.TabIndex = 4;
            btnAccion.Text = "Calcular";
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 96);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 5;
            label3.Text = "tipo operacion: ";
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(141, 97);
            cmbOperacion.Margin = new Padding(3, 4, 3, 4);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(213, 28);
            cmbOperacion.TabIndex = 6;
            // 
            // btnMensaje
            // 
            btnMensaje.Location = new Point(590, 134);
            btnMensaje.Margin = new Padding(3, 4, 3, 4);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(86, 31);
            btnMensaje.TabIndex = 7;
            btnMensaje.Text = "Saludar";
            btnMensaje.UseVisualStyleBackColor = true;
            btnMensaje.Click += btnMensaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnMensaje);
            Controls.Add(cmbOperacion);
            Controls.Add(label3);
            Controls.Add(btnAccion);
            Controls.Add(txtSegundoValor);
            Controls.Add(label2);
            Controls.Add(txtPrimerValor);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrimerValor;
        private TextBox txtSegundoValor;
        private Label label2;
        private Button btnAccion;
        private Label label3;
        private ComboBox cmbOperacion;
        private Button btnMensaje;
    }
}
