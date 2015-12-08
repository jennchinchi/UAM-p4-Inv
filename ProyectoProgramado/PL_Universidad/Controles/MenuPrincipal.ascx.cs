using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;

namespace PL_Universidad.Controles
{
    public partial class MenuPrincipal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (GenericPrincipal.Current.Identity.IsAuthenticated)
                {
                    if (GenericPrincipal.Current.IsInRole("Administrador"))
                    {
                        quinto.Visible = true;
                    }
                    else
                        quinto.Visible = false;
                }
                else
                {
                    Response.Redirect("~\\wfrmInicioSesion.aspx");
                }
            }
        }
    }
}