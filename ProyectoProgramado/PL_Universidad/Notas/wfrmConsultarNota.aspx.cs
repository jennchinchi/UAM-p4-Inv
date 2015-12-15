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
    public partial class wfrmConsultarNota : System.Web.UI.Page
    {
        private static List<Curso> cursos;
        private static List<Usuario> estudiantes;
        private static List<Rubro> rubros;
        private static List<Calificacion> calificaciones;
        private static Guid id_matricula;
        private static Guid id_estudiante;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    //Usuario;
                    Guid idUsuario = Guid.Parse(User.Identity.GetUserId());
                    cursos = Curso.ListarPorProProfesor(idUsuario);
                    cmbCursos.DataTextField = "Nombre";
                    cmbCursos.DataValueField = "Id";
                    cmbCursos.DataSource = cursos;
                    cmbCursos.DataBind();
                }
                else
                {

                }
            }
        }
        protected void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid idCurso = Guid.Parse(cmbCursos.SelectedValue);
            estudiantes = Usuario.BuscarPorCurso(idCurso);
            cmbEstudiantes.DataTextField = "Nombre";
            cmbEstudiantes.DataValueField = "IdUsuario";
            cmbEstudiantes.DataSource = estudiantes;
            cmbEstudiantes.DataBind();
        }

        protected void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_matricula = cursos[cmbCursos.SelectedIndex - 1].Matricula;
            id_estudiante = estudiantes[cmbEstudiantes.SelectedIndex - 1].IdUsuario;

            Usuario estudiante = Usuario.BuscarDatosPersonales(id_estudiante);

            calificaciones = Calificacion.BuscarCalificacionEstudiante(id_estudiante, id_matricula);

            gridCalificaciones.DataSource = calificaciones;
            gridCalificaciones.DataBind();

            for (int i = 0; i < calificaciones.Count; i++)
            {
                if (!calificaciones[i].Estado || !User.IsInRole("Profesor"))
                {
                    Button hb = gridCalificaciones.Rows[i].Cells[3].Controls[0] as Button;
                    hb.Text = "Bloqueado";
                    hb.Enabled = false;
                }
            }
        }

        protected void gridCalificaciones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "habilitar") return;
            int id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("/Notas/wfrmEditarNota.aspx?id_nota=" + calificaciones[id].Id);

        }

        protected void gridCalificaciones_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}