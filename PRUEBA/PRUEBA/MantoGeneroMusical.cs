
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
    public partial class MantoGeneroMusical : Form
    {
        private readonly ConexionBD _conexion;
        public MantoGeneroMusical(ConexionBD conexion)
        {
            _conexion = conexion;
            InitializeComponent();
        }

        private void MantoGeneroMusical_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@nombre1", txtNombre.Text }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_INSERTAR_GENERO_MUSICAL", parametros);

                Limpiar();
                CargarDatos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
        }

        public void CargarDatos()
        {
            DataTable result = _conexion.EjecutarProcedimiento("SP_LISTADO_GENERO_MUSICAL", null);
            dgGeneroMusical.DataSource = result;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", txtId.Text },
                    { "@nombre", txtNombre.Text }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_MODIFICAR_GENERO_MUSICAL", parametros);

                Limpiar();
                CargarDatos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", txtId.Text }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_ELIMINAR_GENERO_MUSICAL", parametros);

                Limpiar();
                CargarDatos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
