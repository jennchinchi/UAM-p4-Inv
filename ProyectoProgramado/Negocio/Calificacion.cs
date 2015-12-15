using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Calificacion
    {
        #region Variables
        private Guid id;
        private Guid idMatricula;
        private Guid idRubro;
        private float nota;
        private bool estado;
        private DateTime fechaYHoraDesbloqueo;
        private string descripcionRubro;
        private float porcentajeRubro;
        private Guid idEstudiante;
        private Guid estadoMatricula;
        private Guid idCursoMatricula;
        private string materia;
        #endregion

        #region Propiedades
        public Guid Id 
        {
            get { return id; }
            set { id = value; }
        }

        public Guid IdMatricula
        {
            get { return idMatricula; }
            set { idMatricula = value; }
        }

        public Guid IdRubro
        {
            get { return idRubro; }
            set { idRubro = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public float Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public bool Estado 
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaYHoraDesbloqueo
        {
            get { return fechaYHoraDesbloqueo; }
            set { fechaYHoraDesbloqueo = value; }
        }

        public string DescripcionRubro
         {
            get { return descripcionRubro; }
            set { descripcionRubro = value; }
        }

        public float PorcentajeRubro
        {
            get { return porcentajeRubro; }
            set { porcentajeRubro = value; }
        }

        public Guid IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        public Guid EstadoMatricula
        {
            get { return estadoMatricula; }
            set { estadoMatricula = value; }
        }

        public Guid IdCursoMatricula
         {
             get { return idCursoMatricula; }
             set { idCursoMatricula = value; }
        }


        #endregion 

        #region Metodos

        public static bool verificarEstaDesbloqueo(DateTime fecha)
        {
            DateTime aux = fecha.AddHours(2);
            if (DateTime.Now > fecha && DateTime.Now < aux)
            {
                return true;
            }
            return false;
        }

        public static Calificacion BuscarPorId(Guid id)
        {
            DataSet set = new Datos.ConexionCalificacion().BuscarPorId(id);
            if (set.Tables[0].Rows.Count == 1)
            {
                DataRow actual = set.Tables[0].Rows[0];
                Calificacion nuevo = new Calificacion();
                nuevo.IdRubro = new Guid(actual[0].ToString());
                nuevo.DescripcionRubro = actual[1].ToString();
                nuevo.PorcentajeRubro = float.Parse(actual[2].ToString());
                nuevo.Id = new Guid(actual[3].ToString());
                nuevo.Nota = float.Parse(actual[4].ToString());
                nuevo.FechaYHoraDesbloqueo = DateTime.Parse((actual[6].ToString()));
                nuevo.Estado = verificarEstaDesbloqueo(nuevo.FechaYHoraDesbloqueo);
                nuevo.IdMatricula = new Guid(actual[7].ToString());
                nuevo.IdEstudiante = new Guid(actual[8].ToString());
                nuevo.IdCursoMatricula = new Guid(actual[9].ToString());
                nuevo.Materia = actual[10].ToString();
                return nuevo;
            }
            return null;
        }

        public static List<Calificacion> BuscarCalificacionEstudiante(Guid idEstudiante, Guid idMatricula)
        {
            List<Calificacion> result = new List<Calificacion>();
            DataSet set = new Datos.ConexionCalificacion().BuscarCalificacionEstudiante(idEstudiante,idMatricula);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Calificacion nuevo = new Calificacion();
                nuevo.IdRubro = new Guid(actual[0].ToString());
                nuevo.DescripcionRubro = actual[1].ToString();
                nuevo.PorcentajeRubro = float.Parse(actual[2].ToString());
                nuevo.Id = new Guid(actual[3].ToString());
                nuevo.Nota = float.Parse(actual[4].ToString());
                nuevo.FechaYHoraDesbloqueo = DateTime.Parse((actual[6].ToString()));
                nuevo.Estado = verificarEstaDesbloqueo(nuevo.FechaYHoraDesbloqueo);
                nuevo.IdMatricula = new Guid(actual[7].ToString());
                nuevo.IdEstudiante = new Guid(actual[8].ToString());
                nuevo.IdCursoMatricula = new Guid(actual[9].ToString());
                nuevo.Materia = actual[10].ToString();
                result.Add(nuevo);
            }
            return result;
        }
        public static bool Insertar(Guid id, Guid idMatricula, Guid idRubro, float nota)
        {
            try
            {
                return new Datos.ConexionCalificacion().Insertar(id, idMatricula, idRubro, nota);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false; 
            }
        }

        public static bool Modificar(Guid id, float nota)
        {
            try
            {
                return new Datos.ConexionCalificacion().Modificar(id,nota);
            }
            catch
            { return false; }
        }

        public static bool Desbloquear(Guid id)
        {
            try
            {
                return new Datos.ConexionCalificacion().Desbloquear(id);
            }
            catch
            { return false; }
        }

        #endregion

    }
}
