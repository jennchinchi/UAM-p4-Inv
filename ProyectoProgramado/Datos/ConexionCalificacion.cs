using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace Datos
{
    public class ConexionCalificacion : ConexionBD
    {
          #region ProcedimientosAlmacenados
        string buscar = "sp_Buscar_Calificacion";
        string buscarPorId = "sp_Buscar_Calificacion_Por_Id";
        string insertarCalificacion = "sp_Insertar_Calificacion";
        string modificarCalificacion = "sp_Modificar_Calificacion";
        string buscarCalificacionesPorEstudiante = "sp_Buscar_Calificaciones_Por_Estudiante";
        string desbloquearCalificacion = "sp_Desbloquear_Calificacion";
        #endregion

        #region métodos
        public ConexionCalificacion()
            : base()
        { }

        public DataSet BuscarPorId(Guid id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = buscarPorId;
            SqlParameter pid = new SqlParameter("@Id", SqlDbType.UniqueIdentifier);
            pid.Value = id;
            cmd.Parameters.Add(pid);
            return Consultar(cmd, "Calificacion");
        }

        public DataSet BuscarCalificacionEstudiante(Guid idEstudiante, Guid idMatricula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = buscarCalificacionesPorEstudiante;
            SqlParameter pidEstudiante = new SqlParameter("@ID_Estudiante", SqlDbType.UniqueIdentifier);
            pidEstudiante.Value = idEstudiante;
            SqlParameter pidMatricula = new SqlParameter("@ID_Matricula", SqlDbType.UniqueIdentifier);
            pidMatricula.Value = idMatricula;
            cmd.Parameters.Add(pidEstudiante);
            cmd.Parameters.Add(pidMatricula);
            return Consultar(cmd, "Calificacion");
        }

        public bool Insertar(Guid id, Guid idMatricula, Guid idRubro, float nota)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = insertarCalificacion;
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Matricula", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Rubro", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@Nota", SqlDbType.Float);

                cmd.Parameters["@ID"].Value = id;
                cmd.Parameters["@ID_Matricula"].Value = idMatricula;
                cmd.Parameters["@ID_Rubro"].Value = idRubro;
                cmd.Parameters["@Nota"].Value = nota;

                Ejecutar(cmd);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool Modificar(Guid id, float nota)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = modificarCalificacion;
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@Nota", SqlDbType.Float);
                cmd.Parameters["@ID"].Value = id;
                cmd.Parameters["@Nota"].Value = nota;
                Ejecutar(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Desbloquear(Guid id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = desbloquearCalificacion;
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier);
                cmd.Parameters["@ID"].Value = id;
                Ejecutar(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
