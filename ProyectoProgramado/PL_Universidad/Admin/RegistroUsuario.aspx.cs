using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PL_Universidad.Admin
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var roles = new RoleStore<IdentityRole>();
            var rolesManager = new RoleManager<IdentityRole>(roles);
            ddlRol.DataSource = rolesManager.Roles.ToList();
            ddlRol.DataBind();
        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var user = new IdentityUser() { UserName = txtUsuario.Text };
            IdentityResult result = manager.Create(user, txtContrasenna.Text);
            
            if (result.Succeeded)
            {
                StatusMessage.Text = string.Format("User {0} was created successfully!", user.UserName);
            }
            else
            {
                lblMensaje.Text = result.Errors.FirstOrDefault();
                mpeMensaje.Show();
            }
        }
    }
}