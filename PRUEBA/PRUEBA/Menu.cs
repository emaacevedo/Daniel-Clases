using PRUEBA.Clases.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEBA
{
    public partial class Menu : Form
    {
        private readonly ConexionBD _conexion;
        public Menu(ConexionBD _conexion)
        {
            this._conexion = _conexion;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e) //Calculadora xd
        {
            //Ejecutar el form de la calculadora
            Form1 calculadora = new Form1();
            calculadora.ShowDialog();
        }

        private void MantoArtistas_Click(object sender, EventArgs e)
        {
            MantoArtistascs mantoArtistascs = new MantoArtistascs(_conexion);
            mantoArtistascs.ShowDialog();
        }

        private void MantoGenerosMusicales_Click(object sender, EventArgs e)
        {
            MantoGeneroMusical mantoGeneroMusical = new MantoGeneroMusical(_conexion);
            mantoGeneroMusical.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnMantocanciones_Click(object sender, EventArgs e)
        {
            MantoCanciones mantoCanciones = new MantoCanciones(_conexion);
            mantoCanciones.ShowDialog();
        }
    }
}
