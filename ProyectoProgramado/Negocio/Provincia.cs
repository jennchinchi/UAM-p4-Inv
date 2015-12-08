using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio
{
    public class Provincia
    {
        private Guid id;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public static List<Provincia> Listar()
        {
            List<Provincia> result = new List<Provincia>();
            DataSet set = new Datos.ConexionProvincias().Listar();
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Provincia nuevo = new Provincia();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Nombre = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }
    }
}
