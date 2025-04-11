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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 109);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "primer valor: ";
            // 
            // txtPrimerValor
            // 
            txtPrimerValor.Location = new Point(124, 106);
            txtPrimerValor.Name = "txtPrimerValor";
            txtPrimerValor.Size = new Size(186, 23);
            txtPrimerValor.TabIndex = 1;
            // 
            // txtSegundoValor
            // 
            txtSegundoValor.Location = new Point(124, 145);
            txtSegundoValor.Name = "txtSegundoValor";
            txtSegundoValor.Size = new Size(186, 23);
            txtSegundoValor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 148);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "segundo valor: ";
            // 
            // btnAccion
            // 
            btnAccion.Location = new Point(114, 191);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(75, 23);
            btnAccion.TabIndex = 4;
            btnAccion.Text = "Calcular";
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 72);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "tipo operacion: ";
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(123, 73);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(187, 23);
            cmbOperacion.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbOperacion);
            Controls.Add(label3);
            Controls.Add(btnAccion);
            Controls.Add(txtSegundoValor);
            Controls.Add(label2);
            Controls.Add(txtPrimerValor);
            Controls.Add(label1);
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
    }
}
