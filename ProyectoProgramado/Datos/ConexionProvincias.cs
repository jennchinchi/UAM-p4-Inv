using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionProvincias : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string listar = "sp_Listar_Provincias";
        #endregion

        #region métodos
        public ConexionProvincias()
            : base()
        { }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;

            return Consultar(cmd, "Provincia");
        }
        #endregion
    }
}
