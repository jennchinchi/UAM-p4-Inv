using System;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Datos
{
    public class ConexionEstadoCivil : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string listar = "sp_Listar_Estado_Civil";
        #endregion

        #region métodos
        public ConexionEstadoCivil()
            : base()
        { }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;
            return Consultar(cmd, "EstadoCivil");
        }
        #endregion
    }
}
