using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Curso
    {
    #region Variables
        private Guid id;
        private Guid idProfesor;
        private Guid idMateria;
        private Guid idCuatrimestre;
        private bool estado;
        private Guid idDia;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private String nombre;
        private Guid matricula;
    #endregion

    #region Properties
        public Guid Id 
        {
            get { return id; }
            set { id = value; }
        }
        
        public Guid IdProfesor 
        {
            get { return idProfesor; }
            set { idProfesor = value; }
        }

        public Guid IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public Guid IdCuatrimestre
        {
            get { return idCuatrimestre; }
            set { idCuatrimestre = value; }
        }

        public bool Estado 
        {
            get { return estado; }
            set { estado = value; }
        }

        public Guid IdDia
        {
            get { return idDia; }
            set { idDia = value; }
        }

        public DateTime HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Guid Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
    #endregion

    #region Metodos
        public static List<Curso> ListarPorProProfesor(Guid idUsuario)
        {
            List<Curso> result = new List<Curso>();
            DataSet set = new Datos.ConexionCurso().Listar(idUsuario);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Curso nuevo = new Curso();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Nombre = actual.ItemArray[8].ToString();
                nuevo.Matricula = new Guid(actual.ItemArray[9].ToString());
                result.Add(nuevo);
            }
            return result;
        }
    #endregion


    }
}
