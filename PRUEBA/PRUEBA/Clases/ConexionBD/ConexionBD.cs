using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA.Clases.ConexionBD
{
    public class ConexionBD
    {
        public DataTable EjecutarProcedimiento(string nombreSP, Dictionary<string, object> parametros)
        {
            string cadenaConexion = "Data Source=EMANUEL\\SQLEXPRESS;Initial Catalog=repertorio_musica;Integrated Security=True";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(nombreSP, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable resultado = new DataTable();
                        adaptador.Fill(resultado);
                        return resultado;
                    }
                }
            }
        }

    }
}
