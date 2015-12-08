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
    public class ConexionUsuarios : ConexionBD
    {
        #region ProcedimientosAlmacenados
        string buscar = "sp_Buscar_Usuario";
        string buscarPorId = "sp_Buscar_Usuario_Por_Id";
        string buscarDatosPersonales = "sp_Buscar_Datos_Personales";
        string insertarDatosPersonales = "sp_Insertar_Datos_Personales";
        string modificarDatosPersonales = "sp_Modificar_Datos_Personales";
        #endregion

        #region métodos
        public ConexionUsuarios()
            : base()
        { }

        public DataSet Buscar(string nombreUsuario, string nombre, string primerApellido, Guid rol)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = buscar;
            SqlParameter pusername = new SqlParameter("@username", SqlDbType.NVarChar);
            pusername.Value = nombreUsuario;
            SqlParameter pnombre = new SqlParameter("@nombre", SqlDbType.VarChar);
            pnombre.Value = nombre;
            SqlParameter pprimer_apellido = new SqlParameter("@primer_apellido", SqlDbType.VarChar);
            pprimer_apellido.Value = primerApellido;
            SqlParameter prol = new SqlParameter("@rol", SqlDbType.UniqueIdentifier);
            prol.Value = rol;
            cmd.Parameters.Add(pusername);
            cmd.Parameters.Add(pnombre);
            cmd.Parameters.Add(pprimer_apellido);
            cmd.Parameters.Add(prol);

            return Consultar(cmd, "AspNetUsers");
        }

        public DataSet BuscarPorId(Guid id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = buscarPorId;
            SqlParameter pid = new SqlParameter("@Id", SqlDbType.UniqueIdentifier);
            pid.Value = id;
            cmd.Parameters.Add(pid);
            return Consultar(cmd, "AspNetUsers");
        }

        public DataSet BuscarDatosPersonales(Guid id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = buscarDatosPersonales;
            SqlParameter pid = new SqlParameter("@Id", SqlDbType.UniqueIdentifier);
            pid.Value = id;
            cmd.Parameters.Add(pid);
            return Consultar(cmd, "AspNetUsers");
        }

        public bool Insertar(Guid idUsuario, string nombre, string primerApellido, string segundoApellido,
            string numeroIdentificacion, Guid idPais, Guid idProvincia, Guid idCanton, Guid idDistrito,
            string direccion, string telefonoMovil, string telefonoFijo, string correo, string urlFoto,
            string genero, Guid idEstadoCivil)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = insertarDatosPersonales;
                cmd.Parameters.Add("@ID_Usuario", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@Primer_Apellido", SqlDbType.VarChar);
                cmd.Parameters.Add("@Segundo_Apellido", SqlDbType.VarChar);
                cmd.Parameters.Add("@Numero_Identificacion", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ID_Pais", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Provincia", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Canton", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Distrito", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Telefono_Movil", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Telefono_Fijo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
                cmd.Parameters.Add("@URL_Foto", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar);
                cmd.Parameters.Add("@ID_Estado_Civil", SqlDbType.UniqueIdentifier);
                Ejecutar(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Modificar(Guid idUsuario, string nombre, string primerApellido, string segundoApellido,
            string numeroIdentificacion, Guid idPais, Guid idProvincia, Guid idCanton, Guid idDistrito,
            string direccion, string telefonoMovil, string telefonoFijo, string correo, string urlFoto,
            string genero, Guid idEstadoCivil)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = modificarDatosPersonales;
                cmd.Parameters.Add("@ID_Usuario", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@Primer_Apellido", SqlDbType.VarChar);
                cmd.Parameters.Add("@Segundo_Apellido", SqlDbType.VarChar);
                cmd.Parameters.Add("@Numero_Identificacion", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ID_Pais", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Provincia", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Canton", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@ID_Distrito", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Telefono_Movil", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Telefono_Fijo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
                cmd.Parameters.Add("@URL_Foto", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar);
                cmd.Parameters.Add("@ID_Estado_Civil", SqlDbType.UniqueIdentifier);

                cmd.Parameters["@ID_Usuario"].Value = idUsuario;
                cmd.Parameters["@Nombre"].Value = nombre;
                cmd.Parameters["@Primer_Apellido"].Value = primerApellido;
                cmd.Parameters["@Segundo_Apellido"].Value = segundoApellido;
                cmd.Parameters["@Numero_Identificacion"].Value = numeroIdentificacion;
                cmd.Parameters["@ID_Pais"].Value = idPais;
                cmd.Parameters["@ID_Provincia"].Value = idProvincia;
                cmd.Parameters["@ID_Canton"].Value = idCanton;
                cmd.Parameters["@ID_Distrito"].Value = idDistrito;
                cmd.Parameters["@Direccion"].Value = direccion;
                cmd.Parameters["@Telefono_Movil"].Value = telefonoMovil;
                cmd.Parameters["@Telefono_Fijo"].Value = telefonoFijo;
                cmd.Parameters["@Correo"].Value = correo;
                cmd.Parameters["@URL_Foto"].Value = urlFoto;
                cmd.Parameters["@Genero"].Value = genero;
                cmd.Parameters["@ID_Estado_Civil"].Value = idEstadoCivil;
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
