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
    public partial class MantoArtistascs : Form
    {
        private readonly ConexionBD _conexion;
        public MantoArtistascs(ConexionBD conexion)
        {
            _conexion = conexion;
            InitializeComponent();
        }

        private void MantoArtistascs_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            DataTable listaArtista = _conexion.EjecutarProcedimiento("SP_LISTADO_ARTISTAS", null);
            DataTable listaGenero = _conexion.EjecutarProcedimiento("SP_LISTADO_GENERO_MUSICAL", null);

            dgArtistas.DataSource = listaArtista;
            cmbGeneroMusical.DataSource = listaGenero;
            cmbGeneroMusical.DisplayMember = "nombre";
            cmbGeneroMusical.ValueMember = "id";
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
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
                        { "@nombre", txtNombre.Text },
                        { "@id_genero", cmbGeneroMusical.SelectedValue }
                    };

                    result = _conexion.EjecutarProcedimiento("SP_INSERTAR_ARTISTAS", parametros);
                }
                else
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@id", txtId.Text },
                        { "@nombre", txtNombre.Text },
                        { "@id_genero", cmbGeneroMusical.SelectedValue }
                    };

                    result = _conexion.EjecutarProcedimiento("SP_MODIFICAR_ARTISTAS", parametros);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", txtId.Text }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_ELIMINAR_ARTISTAS", parametros);

                Limpiar();
                CargarDatos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgArtistas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(e.Row.Cells["id"].Value);
                DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el artista con ID {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@id", id }
                    };

                    DataTable result = _conexion.EjecutarProcedimiento("SP_ELIMINAR_ARTISTAS", parametros);

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
                e.Cancel = true;
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgArtistas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgArtistas.Rows[e.RowIndex].Cells["id"].Value);

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", id }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_LISTADO_ARTISTAS_ID", parametros);

                if (result.Rows.Count > 0)
                {
                    txtId.Text = result.Rows[0]["id"].ToString();
                    txtNombre.Text = result.Rows[0]["nombre"].ToString();
                    cmbGeneroMusical.SelectedValue = result.Rows[0]["id_genero"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el artista con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                txtId.Text = "";
                txtNombre.Text = "";
                cmbGeneroMusical.SelectedIndex = -1;
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
