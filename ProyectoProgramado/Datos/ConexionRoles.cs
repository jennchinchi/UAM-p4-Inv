using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class ConexionRoles : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string buscar = "sp_Buscar_Rol";
        string listar = "sp_Listar_Roles";
        #endregion

        #region métodos
        public ConexionRoles()
            : base()
        { }

        public DataSet Buscar(Guid id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = buscar;
            SqlParameter pId = new SqlParameter("@id", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add(pId);

            return Consultar(cmd, "AspNetRoles");
        }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = listar;

            return Consultar(cmd, "AspNetRoles");
        }
        #endregion
    }
}
