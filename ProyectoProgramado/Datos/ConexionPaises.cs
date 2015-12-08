using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionPaises : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string listar = "sp_Listar_Pais";
        #endregion

        #region métodos
        public ConexionPaises()
            : base()
        { }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;

            return Consultar(cmd, "Pais");
        }
        #endregion
    }
}
