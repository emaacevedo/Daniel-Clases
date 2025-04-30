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

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@nombre", txtNombre.Text },
                    { "@id_genero", cmbGeneroMusical.SelectedValue }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_INSERTAR_ARTISTAS", parametros);

                Limpiar();
                CargarDatos();

                MessageBox.Show(result.Rows[0]["mensaje"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    { "@id_genero", cmbGeneroMusical.SelectedValue }
                };

                DataTable result = _conexion.EjecutarProcedimiento("SP_MODIFICAR_ARTISTAS", parametros);

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
    }
}
