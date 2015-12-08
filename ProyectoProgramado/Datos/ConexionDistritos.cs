using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ConexionDistritos : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string listar = "sp_Listar_Distritos_Por_Canton";
        #endregion

        #region métodos
        public ConexionDistritos()
            : base()
        { }

        public DataSet Listar(Guid idCanton)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;
            SqlParameter pId = new SqlParameter("@IdCanton", SqlDbType.UniqueIdentifier);
            pId.Value = idCanton;
            cmd.Parameters.Add(pId);

            return Consultar(cmd, "Distrito");
        }
        #endregion
    }
}
