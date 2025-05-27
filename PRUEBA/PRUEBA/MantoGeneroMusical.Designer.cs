namespace PRUEBA
{
    partial class MantoGeneroMusical
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            dgGeneroMusical = new DataGridView();
            btnLimpiarFormulario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgGeneroMusical).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 15);
            label1.TabIndex = 0;
            label1.Text = "MANTENIMIENTO DE GENEROS MUSICALES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 266);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 298);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "NOMBRE";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(106, 263);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 290);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(173, 336);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar Datos";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgGeneroMusical
            // 
            dgGeneroMusical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGeneroMusical.Location = new Point(12, 92);
            dgGeneroMusical.Name = "dgGeneroMusical";
            dgGeneroMusical.Size = new Size(617, 132);
            dgGeneroMusical.TabIndex = 1;
            dgGeneroMusical.CellDoubleClick += dgGeneroMusical_CellDoubleClick;
            dgGeneroMusical.UserDeletingRow += dgGeneroMusical_UserDeletingRow;
            // 
            // btnLimpiarFormulario
            // 
            btnLimpiarFormulario.Location = new Point(355, 336);
            btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            btnLimpiarFormulario.Size = new Size(118, 23);
            btnLimpiarFormulario.TabIndex = 7;
            btnLimpiarFormulario.Text = "Limpiar Formulario";
            btnLimpiarFormulario.UseVisualStyleBackColor = true;
            btnLimpiarFormulario.Click += btnLimpiarFormulario_Click;
            // 
            // MantoGeneroMusical
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 595);
            Controls.Add(btnLimpiarFormulario);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgGeneroMusical);
            Controls.Add(label1);
            Name = "MantoGeneroMusical";
            Text = "MantoGeneroMusical";
            Load += MantoGeneroMusical_Load;
            ((System.ComponentModel.ISupportInitialize)dgGeneroMusical).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtNombre;
        private Button btnGuardar;
        private DataGridView dgGeneroMusical;
        private Button btnLimpiarFormulario;
    }
}