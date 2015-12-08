using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Pais
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

        public static List<Pais> Listar()
        {
            List<Pais> result = new List<Pais>();
            DataSet set = new Datos.ConexionPaises().Listar();
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Pais nuevo = new Pais();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Nombre = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }
    }
}
