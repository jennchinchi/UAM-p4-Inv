using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionRubros : ConexionBD
    {
        #region ProcedimientosAlmacenados
            string listar = "sp_ListarRubros";
        #endregion

        #region métodos
            public ConexionRubros()
            : base()
        { }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;

            return Consultar(cmd, "Rubro");
        }
        #endregion
    }
}
