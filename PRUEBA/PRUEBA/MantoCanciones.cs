using PRUEBA.Clases.ConexionBD;
using System;
using System.CodeDom;
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
    public partial class MantoCanciones : Form
    {
        private readonly IConexionBD _conexion;
        public MantoCanciones(IConexionBD conexion)
        {
            _conexion = conexion;
            InitializeComponent();
        }

        private void MantoCanciones_Load(object sender, EventArgs e)
        {
            dtDueracion.ShowUpDown = true;
            cargar_datos();

        }

        public void cargar_datos()
        {
            DataTable listaCanciones = _conexion.EjecutarProcedimiento("LISTAR_CANCIONES", null);
            DataTable listaArtistas = _conexion.EjecutarProcedimiento("SP_LISTADO_ARTISTAS", null);


            dgCanciones.DataSource = listaCanciones;
            cmbArtista.DataSource = listaArtistas;
            cmbArtista.DisplayMember = "nombre";
            cmbArtista.ValueMember = "id";
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtLetra.Text = "";
            dtDueracion.Value = DateTime.Now;
            cmbArtista.SelectedIndex = -1;
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
                        { "@letra", txtLetra.Text },
                        { "@duracion", dtDueracion.Value.TimeOfDay },
                        { "@lanzamiento", dtFecha_Lanzamiento.Value.Date},
                        { "@id_artista", cmbArtista.SelectedValue }
                    };

                    result = _conexion.EjecutarProcedimiento("AGREGAR_CANCIONES", parametros);
                }
                else
                {
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@id", txtId.Text },
                        { "@nombre", txtNombre.Text },
                        { "@letra", txtLetra.Text },
                        { "@duracion", dtDueracion.Value.TimeOfDay },
                        { "@lanzamiento", dtFecha_Lanzamiento.Value.Date},
                        { "@id_artista", cmbArtista.SelectedValue }
                    };
                    result = _conexion.EjecutarProcedimiento("ACTUALIZAR_CANCIONES", parametros);
                }


                limpiar();
                cargar_datos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", txtId.Text },
                    { "@nombre", txtNombre.Text },
                    { "@letra", txtLetra.Text },
                    { "@duracion", dtDueracion.Value.TimeOfDay },
                    { "@lanzamiento", dtFecha_Lanzamiento.Value.Date},
                    { "@id_artista", cmbArtista.SelectedValue }
                };

                DataTable result = _conexion.EjecutarProcedimiento("ACTUALIZAR_CANCIONES", parametros);

                limpiar();
                cargar_datos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgCanciones_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(e.Row.Cells["id"].Value);

                DialogResult result = MessageBox.Show($"¿Deseas eliminar la canción con ID {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true; // Cancela la eliminación
                }
                else
                {
                    // Aquí haces la eliminación en tu base de datos o lista
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        { "@id", id },

                    };

                    DataTable resultado = _conexion.EjecutarProcedimiento("ELIMINAR_CANCIONES", parametros);

                    // Usamos BeginInvoke para que la recarga ocurra después del evento
                    this.BeginInvoke(new Action(() =>
                    {
                        limpiar();
                        cargar_datos();
                        MessageBox.Show(resultado.Rows[0]["mensaje"].ToString());
                    }));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgCanciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgCanciones.Rows[e.RowIndex].Cells["id"].Value);
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", id }

                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_LISTARCANCIONES_ID", parametros);
                if (result.Rows.Count > 0)
                {

                    TimeSpan duracion = (TimeSpan)result.Rows[0]["duracion"];
                    DateTime fechaLanzamiento = Convert.ToDateTime(result.Rows[0]["lanzamiento"]);

                    txtId.Text = result.Rows[0]["id"].ToString();
                    txtNombre.Text = result.Rows[0]["nombre"].ToString();
                    txtLetra.Text = result.Rows[0]["letra"].ToString();
                    dtDueracion.Value = DateTime.Today.Add(duracion);
                    dtFecha_Lanzamiento.Value = fechaLanzamiento;
                    cmbArtista.SelectedValue = result.Rows[0]["id_artista"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró la canción con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
