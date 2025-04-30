namespace PRUEBA
{
    partial class MantoArtistascs
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
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            dgArtistas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbGeneroMusical = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgArtistas).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(509, 385);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(352, 385);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 23);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(200, 385);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 306);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(202, 279);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 314);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 11;
            label3.Text = "NOMBRE";
            // 
            // dgArtistas
            // 
            dgArtistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgArtistas.Location = new Point(108, 108);
            dgArtistas.Name = "dgArtistas";
            dgArtistas.Size = new Size(617, 132);
            dgArtistas.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 30);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 9;
            label1.Text = "MANTENIMIENTO DE ARTISTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 279);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 17;
            label2.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 352);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 18;
            label4.Text = "GENERO";
            // 
            // cmbGeneroMusical
            // 
            cmbGeneroMusical.FormattingEnabled = true;
            cmbGeneroMusical.Location = new Point(202, 344);
            cmbGeneroMusical.Name = "cmbGeneroMusical";
            cmbGeneroMusical.Size = new Size(284, 23);
            cmbGeneroMusical.TabIndex = 19;
            // 
            // MantoArtistascs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 590);
            Controls.Add(cmbGeneroMusical);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(dgArtistas);
            Controls.Add(label1);
            Name = "MantoArtistascs";
            Text = "MantoArtistascs";
            Load += MantoArtistascs_Load;
            ((System.ComponentModel.ISupportInitialize)dgArtistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label3;
        private DataGridView dgArtistas;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cmbGeneroMusical;
    }
}