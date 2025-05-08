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
        private readonly ConexionBD _conexion;
        public MantoCanciones(ConexionBD conexion)
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
            dtDueracion.Value = DateTime.Now;
            cmbArtista.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@nombre", txtNombre.Text },
                    { "@letra", txtLetra.Text },
                    { "@duracion", dtDueracion.Value.TimeOfDay },
                    { "@lanzamiento", dtFecha_Lanzamiento.Value.Date},
                    { "@id_artista", cmbArtista.SelectedValue }
                };

                DataTable result = _conexion.EjecutarProcedimiento("AGREGAR_CANCIONES", parametros);

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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@id", txtId.Text },
           
                };

                DataTable result = _conexion.EjecutarProcedimiento("ELIMINAR_CANCIONES", parametros);

                limpiar();
                cargar_datos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
