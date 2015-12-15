using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio
{
    public class EstadoCivil
    {
        private Guid iD;
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Guid ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public static List<EstadoCivil> Listar()
        {
            List<EstadoCivil> result = new List<EstadoCivil>();
            DataSet set = new Datos.ConexionEstadoCivil().Listar();
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                EstadoCivil nuevo = new EstadoCivil();
                nuevo.ID = new Guid(actual.ItemArray[0].ToString());
                nuevo.Descripcion = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }
    }
}
