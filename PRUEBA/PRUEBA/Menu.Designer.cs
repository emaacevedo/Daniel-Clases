namespace PRUEBA
{
    partial class Menu
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
            Calculadora = new Button();
            MantoArtistas = new Button();
            MantoGenerosMusicales = new Button();
            SuspendLayout();
            // 
            // Calculadora
            // 
            Calculadora.Location = new Point(12, 12);
            Calculadora.Name = "Calculadora";
            Calculadora.Size = new Size(280, 23);
            Calculadora.TabIndex = 15;
            Calculadora.Text = "Calculadora";
            Calculadora.UseVisualStyleBackColor = true;
            Calculadora.Click += btnGuardar_Click;
            // 
            // MantoArtistas
            // 
            MantoArtistas.Location = new Point(12, 41);
            MantoArtistas.Name = "MantoArtistas";
            MantoArtistas.Size = new Size(280, 23);
            MantoArtistas.TabIndex = 16;
            MantoArtistas.Text = "Mantenimiento de Artistas";
            MantoArtistas.UseVisualStyleBackColor = true;
            MantoArtistas.Click += MantoArtistas_Click;
            // 
            // MantoGenerosMusicales
            // 
            MantoGenerosMusicales.Location = new Point(12, 70);
            MantoGenerosMusicales.Name = "MantoGenerosMusicales";
            MantoGenerosMusicales.Size = new Size(280, 23);
            MantoGenerosMusicales.TabIndex = 17;
            MantoGenerosMusicales.Text = "Mantenimiento de Generos Musicales";
            MantoGenerosMusicales.UseVisualStyleBackColor = true;
            MantoGenerosMusicales.Click += MantoGenerosMusicales_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 632);
            Controls.Add(MantoGenerosMusicales);
            Controls.Add(MantoArtistas);
            Controls.Add(Calculadora);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Calculadora;
        private Button MantoArtistas;
        private Button MantoGenerosMusicales;
    }
}