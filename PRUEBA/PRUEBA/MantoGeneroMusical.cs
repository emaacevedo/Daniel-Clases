
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
                DataTable result;
                if (txtId.Text == "")
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@nombre", txtNombre.Text }
                    };

                    result = _conexion.EjecutarProcedimiento("SP_INSERTAR_GENERO_MUSICAL", parametros);


                } else
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@id", txtId.Text },
                        { "@nombre", txtNombre.Text }
                    };

                    result = _conexion.EjecutarProcedimiento("SP_MODIFICAR_GENERO_MUSICAL", parametros);
                }

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

        private void dgGeneroMusical_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(e.Row.Cells["id"].Value);
                DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el género musical con ID {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@id", id }
                    };

                    DataTable result = _conexion.EjecutarProcedimiento("SP_ELIMINAR_GENERO_MUSICAL", parametros);

                    this.BeginInvoke(new Action(() =>
                    {
                        Limpiar();
                        CargarDatos();
                        MessageBox.Show(result.Rows[0]["mensaje"].ToString());
                    }));


                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgGeneroMusical_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgGeneroMusical.Rows[e.RowIndex].Cells["id"].Value);

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", id }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_LISTADO_GENEROMUSICAL_ID", parametros);

                if (result.Rows.Count > 0)
                { 
                    txtId.Text = result.Rows[0]["id"].ToString();
                    txtNombre.Text = result.Rows[0]["nombre"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el género musical con el ID especificado.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
