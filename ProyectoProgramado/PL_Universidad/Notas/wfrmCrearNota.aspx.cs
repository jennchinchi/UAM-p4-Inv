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
    public partial class wfrmCrearNota : System.Web.UI.Page
    {
        private static List<Rubro> rubros;
        private static List<Calificacion> calificaciones;
        private static Guid id_matricula;
        private static Guid id_estudiante;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id_matricula = new Guid(Request.QueryString["id_matricula"]);
                id_estudiante = new Guid(Request.QueryString["id_est"]);

                Usuario estudiante = Usuario.BuscarDatosPersonales(id_estudiante);
                txtEstudiante.Text = estudiante.Nombre;

                rubros = Rubro.Listar();
                cmbRubros.DataTextField = "Descripcion";
                cmbRubros.DataValueField = "Id";
                cmbRubros.DataSource = rubros;
                cmbRubros.DataBind();
                
                calificaciones = Calificacion.BuscarCalificacionEstudiante(id_estudiante, id_matricula);

                for (int i = 0; i < rubros.Count; i++)
                {
                    foreach (Calificacion c in calificaciones)
                    {
                        if (rubros[i].Descripcion.Equals(c.DescripcionRubro))
                        {
                            cmbRubros.Items[i+1].Enabled = false;
                        }
                    }
                }
                
            }
            
        }

        protected void cmbRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPorcentaje.Text = rubros[cmbRubros.SelectedIndex - 1].Porcentaje.ToString() + "%";
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Calificacion.Insertar(Guid.NewGuid(), id_matricula, new Guid(cmbRubros.SelectedValue), float.Parse(txtNota.Text)))
            {
                Response.Redirect("/Notas/wfrmBuscarCursoEstudiante.aspx");
            }
            else
            {
                lblMessage.Text = "Ocurrió un error.";
            }
        }
    }
}