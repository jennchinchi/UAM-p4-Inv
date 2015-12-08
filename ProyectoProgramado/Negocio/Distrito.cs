using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Negocio
{
    public class Distrito
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

        public static List<Distrito> Listar(Guid idCanton)
        {
            List<Distrito> result = new List<Distrito>();
            DataSet set = new Datos.ConexionDistritos().Listar(idCanton);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Distrito nuevo = new Distrito();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Nombre = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }
    }
}
