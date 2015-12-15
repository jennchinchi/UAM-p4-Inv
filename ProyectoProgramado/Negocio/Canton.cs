using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Canton
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

        public static List<Canton> Listar(Guid idProvincia)
        {
            List<Canton> result = new List<Canton>();
            DataSet set = new Datos.ConexionCantones().Listar(idProvincia);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Canton nuevo = new Canton();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Nombre = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }
    }
}
