using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionCantones : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string listar = "sp_Listar_Cantones_Por_Provincia";
        #endregion

        #region métodos
        public ConexionCantones()
            : base()
        { }

        public DataSet Listar(Guid idProvincia)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;
            SqlParameter pId = new SqlParameter("@IdProvincia", SqlDbType.UniqueIdentifier);
            pId.Value = idProvincia;
            cmd.Parameters.Add(pId);

            return Consultar(cmd, "Canton");
        }
        #endregion
    }
}
