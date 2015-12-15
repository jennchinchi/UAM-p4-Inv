using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Negocio;

namespace PL_Universidad.Notas
{
    public partial class wfrmEditarNota : System.Web.UI.Page
    {
        private static List<Rubro> rubros;
        private static List<Calificacion> calificaciones;
        private static Guid id_nota;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id_nota = new Guid(Request.QueryString["id_nota"]);
                Calificacion calificacion = Calificacion.BuscarPorId(id_nota);

                Usuario estudiante = Usuario.BuscarDatosPersonales(calificacion.IdEstudiante);
                txtEstudiante.Text = estudiante.Nombre;
                txtMateria.Text = calificacion.Materia;
                txtRubro.Text = calificacion.DescripcionRubro;
                txtNota.Text = calificacion.Nota.ToString();

                if (!User.IsInRole("Profesor"))
                {
                    btnModificar.Enabled = false;
                }
            }

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Calificacion.Modificar(id_nota, float.Parse(txtNota.Text)))
            {
                Response.Redirect("/Notas/wfrmConsultarNota.aspx");
            }
            else
            {
                lblMessage.Text = "Ocurrió un error.";
            }
        }
    }
}