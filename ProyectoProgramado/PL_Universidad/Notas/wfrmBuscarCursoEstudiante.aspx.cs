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
    public partial class wfrmBuscarCursoEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    //Usuario;
                    Guid idUsuario = Guid.Parse(User.Identity.GetUserId());
                    List<Curso> cursos = Curso.ListarPorProProfesor(idUsuario);
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
            List<Usuario> estudiantes = Usuario.BuscarPorCurso(idCurso);
            cmbEstudiantes.DataTextField = "Nombre";
            cmbEstudiantes.DataValueField = "IdUsuario";
            cmbEstudiantes.DataSource = estudiantes;
            cmbEstudiantes.DataBind();
        }

        protected void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Notas/wfrmCrearNota.aspx");
        }
    }
}