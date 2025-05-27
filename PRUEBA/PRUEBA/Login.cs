
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
using System.Xml;

namespace PRUEBA
{
    public partial class Login : Form
    {
        private readonly IConexionBD _conexion;
        public Login(IConexionBD conexion)
        {
            _conexion = conexion;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@usuario", txtUsuario.Text },
                        { "@clave", txtClave.Text }
                    };
                DataTable resultado = _conexion.EjecutarProcedimiento("SP_LOGIN", parametros);

                if (Convert.ToInt32(resultado.Rows[0]["codigo"]) == 1)
                {
                    // Si la consulta devuelve resultados, el usuario existe
                    MessageBox.Show(resultado.Rows[0]["mensaje"].ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí puedes abrir el formulario principal o realizar otras acciones
                    this.Hide(); // Oculta el formulario de login
                    Menu menu = new Menu(_conexion);
                    menu.Show(); // Muestra el formulario principal
                }
                else
                {
                    // Si no hay resultados, el usuario no existe
                    MessageBox.Show(resultado.Rows[0]["mensaje"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
