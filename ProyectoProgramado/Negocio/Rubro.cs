using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Rubro
    {
        private Guid id;
        private string desc;
        private float porcentaje;

        public string Descripcion
        {
            get { return desc; }
            set { desc = value; }
        }

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public float Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }

        public static List<Rubro> Listar()
        {
            List<Rubro> result = new List<Rubro>();
            DataSet set = new ConexionRubros().Listar();

            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Rubro nuevo = new Rubro();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Descripcion = actual.ItemArray[1].ToString();
                nuevo.Porcentaje = float.Parse(actual.ItemArray[2].ToString());
                result.Add(nuevo);
            }
            return result;
        }
    }
}
