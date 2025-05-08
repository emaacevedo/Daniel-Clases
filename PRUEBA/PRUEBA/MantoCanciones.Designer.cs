namespace PRUEBA
{
    partial class MantoCanciones
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
            components = new System.ComponentModel.Container();
            cmbArtista = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            dgCanciones = new DataGridView();
            label1 = new Label();
            txtLetra = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtFecha_Lanzamiento = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            dtDueracion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgCanciones).BeginInit();
            SuspendLayout();
            // 
            // cmbArtista
            // 
            cmbArtista.FormattingEnabled = true;
            cmbArtista.Location = new Point(590, 341);
            cmbArtista.Name = "cmbArtista";
            cmbArtista.Size = new Size(284, 23);
            cmbArtista.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 349);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 29;
            label4.Text = "ARTISTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 254);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 28;
            label2.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(559, 398);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 23);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(402, 398);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 23);
            btnActualizar.TabIndex = 26;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(250, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 23);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 292);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(284, 23);
            txtNombre.TabIndex = 24;
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 254);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 23;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 300);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 22;
            label3.Text = "NOMBRE";
            // 
            // dgCanciones
            // 
            dgCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCanciones.Location = new Point(69, 71);
            dgCanciones.Name = "dgCanciones";
            dgCanciones.Size = new Size(805, 132);
            dgCanciones.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 36);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 20;
            label1.Text = "MANTENIMIENTO DE CANCIONES";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(147, 341);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(284, 23);
            txtLetra.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 349);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 31;
            label5.Text = "LETRA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 254);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 33;
            label6.Text = "Duracion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 300);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 35;
            label7.Text = "Fecha de Lanzamiento";
            // 
            // dtFecha_Lanzamiento
            // 
            dtFecha_Lanzamiento.Location = new Point(590, 294);
            dtFecha_Lanzamiento.Name = "dtFecha_Lanzamiento";
            dtFecha_Lanzamiento.Size = new Size(284, 23);
            dtFecha_Lanzamiento.TabIndex = 36;
            // 
            // dtDueracion
            // 
            dtDueracion.Format = DateTimePickerFormat.Time;
            dtDueracion.Location = new Point(590, 246);
            dtDueracion.Name = "dtDueracion";
            dtDueracion.Size = new Size(144, 23);
            dtDueracion.TabIndex = 37;
            // 
            // MantoCanciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 537);
            Controls.Add(dtDueracion);
            Controls.Add(dtFecha_Lanzamiento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtLetra);
            Controls.Add(label5);
            Controls.Add(cmbArtista);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(dgCanciones);
            Controls.Add(label1);
            Name = "MantoCanciones";
            Text = "MantoCanciones";
            Load += MantoCanciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgCanciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbArtista;
        private Label label4;
        private Label label2;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label3;
        private DataGridView dgCanciones;
        private Label label1;
        private TextBox txtLetra;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtFecha_Lanzamiento;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dtDueracion;
    }
}