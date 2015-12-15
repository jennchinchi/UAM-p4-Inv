using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Negocio
{
    public class Usuario
    {
        private Guid id;
        private Guid idUsuario;
        private string nombreUsuario;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string rol;
        private string genero;
        private string direccion;
        private Guid idPais;
        private Guid idProvincia;
        private Guid idCanton;
        private Guid idDistrito;
        private string numeroIdentificacion;
        private string telefonoFijo;
        private string telefonoMovil;
        private string correo;
        private string uRLFoto;
        private string eStadoCivil;
        
        public Guid IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string EstadoCivil
        {
            get { return eStadoCivil; }
            set { eStadoCivil = value; }
        }

        public string URLFoto
        {
            get { return uRLFoto; }
            set { uRLFoto = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string TelefonoMovil
        {
            get { return telefonoMovil; }
            set { telefonoMovil = value; }
        }

        public string TelefonoFijo
        {
            get { return telefonoFijo; }
            set { telefonoFijo = value; }
        }

        public string NumeroIdentificacion
        {
            get { return numeroIdentificacion; }
            set { numeroIdentificacion = value; }
        }

        public Guid IdDistrito
        {
            get { return idDistrito; }
            set { idDistrito = value; }
        }

        public Guid IdCanton
        {
            get { return idCanton; }
            set { idCanton = value; }
        }

        public Guid IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }

        public Guid IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public static List<Usuario> Buscar(string nombreUsuario, string nombre, string primerApellido, Guid rol)
        {
            List<Usuario> result = new List<Usuario>();
            DataSet set = new Datos.ConexionUsuarios().Buscar(nombreUsuario, nombre, primerApellido, rol);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Usuario nuevo = new Usuario();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.NombreUsuario = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }

        public static Usuario BuscarPorId(Guid id)
        {
            DataSet set = new Datos.ConexionUsuarios().BuscarPorId(id);
            if (set.Tables[0].Rows.Count == 1)
            {
                Usuario result = new Usuario();
                result.Id = new Guid(set.Tables[0].Rows[0].ItemArray[0].ToString());
                result.NombreUsuario = set.Tables[0].Rows[0].ItemArray[1].ToString();
                return result;
            }
            return null;
        }

        public static Usuario BuscarDatosPersonales(Guid id)
        {
            DataSet set = new Datos.ConexionUsuarios().BuscarDatosPersonales(id);
            if (set.Tables[0].Rows.Count == 1)
            {
                object[] itemArray = set.Tables[0].Rows[0].ItemArray;
                Usuario result = new Usuario();
                result.Nombre = itemArray[0].ToString();
                result.PrimerApellido = itemArray[1].ToString();
                result.segundoApellido = itemArray[2] != null ? itemArray[2].ToString() : string.Empty;
                result.NumeroIdentificacion = itemArray[3].ToString();
                result.idPais = new Guid(itemArray[4].ToString());
                result.idProvincia = new Guid(itemArray[5].ToString());
                result.idCanton = new Guid(itemArray[6].ToString());
                result.idDistrito = new Guid(itemArray[7].ToString());
                result.Direccion = itemArray[8].ToString();
                result.TelefonoFijo = itemArray[9].ToString();
                result.TelefonoMovil = itemArray[10].ToString();
                result.Correo = itemArray[11].ToString();
                result.URLFoto = itemArray[12].ToString();
                result.Genero = itemArray[13].ToString();
                result.EstadoCivil = itemArray[14].ToString();
                return result;
            }
            return null;
        }

        //Jenn
        public static List<Usuario> BuscarPorCurso(Guid id)
        {
            List<Usuario> result = new List<Usuario>();
            DataSet set = new Datos.ConexionUsuarios().BuscarPorCurso(id);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Usuario nuevo = new Usuario();
                nuevo.IdUsuario = new Guid(actual.ItemArray[0].ToString());
                nuevo.Nombre = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }

        public static bool Insertar(Guid idUsuario, string nombre, string primerApellido, string segundoApellido,
            string numeroIdentificacion, Guid idPais, Guid idProvincia, Guid idCanton, Guid idDistrito,
            string direccion, string telefonoMovil, string telefonoFijo, string correo, string urlFoto,
            string genero, Guid idEstadoCivil)
        {
            try
            {
                return new Datos.ConexionUsuarios().Insertar(idUsuario, nombre, primerApellido, segundoApellido,
                    numeroIdentificacion, idPais, idProvincia, idCanton, idDistrito,
                    direccion, telefonoMovil, telefonoFijo, correo,urlFoto, genero, idEstadoCivil);
            }
            catch
            { return false; }
        }

        public static bool Modificar(Guid idUsuario, string nombre, string primerApellido, string segundoApellido,
            string numeroIdentificacion, Guid idPais, Guid idProvincia, Guid idCanton, Guid idDistrito,
            string direccion, string telefonoMovil, string telefonoFijo, string correo, string urlFoto,
            string genero, Guid idEstadoCivil)
        {
            try
            {
                return new Datos.ConexionUsuarios().Modificar(idUsuario, nombre, primerApellido, segundoApellido,
                    numeroIdentificacion, idPais, idProvincia, idCanton, idDistrito,
                    direccion, telefonoMovil, telefonoFijo, correo, urlFoto, genero, idEstadoCivil);
            }
            catch
            { return false; }
        }
    }
}
