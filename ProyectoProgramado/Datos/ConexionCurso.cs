using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionCurso : ConexionBD
    {
    #region ProcedimientosAlmacenados
        string listar = "sp_BuscarCursosPorProfesor";
    #endregion

    #region métodos
        public ConexionCurso()
            : base()
        { }
        public DataSet Listar(Guid idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;
            SqlParameter pId = new SqlParameter("@ID_Usuario", SqlDbType.UniqueIdentifier);
            pId.Value = idUsuario;
            cmd.Parameters.Add(pId);

            return Consultar(cmd, "Curso");
        }
    #endregion

    }
}
