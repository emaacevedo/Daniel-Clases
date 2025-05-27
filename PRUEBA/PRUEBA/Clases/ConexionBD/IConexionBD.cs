using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA.Clases.ConexionBD
{
    public interface IConexionBD
    {
        DataTable EjecutarProcedimiento(string nombreSP, Dictionary<string, object> parametros);
    }
}
