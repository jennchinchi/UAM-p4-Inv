using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
namespace Negocio
{
    public class Rol
    {
        private Guid id;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Rol> Buscar(Guid id)
        {
            List<Rol> result = new List<Rol>();
            DataSet set = new ConexionRoles().Buscar(id);
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Rol nuevo = new Rol();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Name = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }

        public List<Rol> Listar()
        {
            List<Rol> result = new List<Rol>();
            DataSet set = new ConexionRoles().Listar();
            foreach (DataRow actual in set.Tables[0].Rows)
            {
                Rol nuevo = new Rol();
                nuevo.Id = new Guid(actual.ItemArray[0].ToString());
                nuevo.Name = actual.ItemArray[1].ToString();
                result.Add(nuevo);
            }
            return result;
        }
    }
}
