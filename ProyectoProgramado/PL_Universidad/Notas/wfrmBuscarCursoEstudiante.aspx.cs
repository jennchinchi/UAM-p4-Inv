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
        private static List<Curso> cursos;
        private static List<Usuario> estudiantes;
        
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
            Guid id_m = cursos[cmbCursos.SelectedIndex-1].Matricula;
            Guid id_e = estudiantes[cmbEstudiantes.SelectedIndex-1].IdUsuario;
            Response.Redirect("/Notas/wfrmCrearNota.aspx?id_matricula="+ id_m +"&id_est="+ id_e);
        }
    }
}