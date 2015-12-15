using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;
using Negocio;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PL_Universidad.Admin
{
    public partial class Usuarios : System.Web.UI.Page
    {
        string urlFoto = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page.Form.Attributes.Add("enctype", "multipart/form-data");

                if (!GenericPrincipal.Current.IsInRole("Administrador"))
                {
                    Response.Redirect("~\\wfrmInicio.aspx");
                }

                Rol iRol = new Rol();
                List<Rol> roles = iRol.Listar();
                foreach (Rol actual in roles)
                {
                    ddlBusquedaRoles.Items.Add(new ListItem(actual.Name, actual.Id.ToString()));
                    ddlRol.Items.Add(new ListItem(actual.Name, actual.Id.ToString()));
                }

                List<Pais> paises = Pais.Listar();
                foreach (Pais actual in paises)
                {
                    ddlPais.Items.Add(new ListItem(actual.Nombre, actual.Id.ToString()));
                }

                List<EstadoCivil> estadosCiviles = EstadoCivil.Listar();
                foreach (EstadoCivil actual in estadosCiviles)
                {
                    ddlEstadoCivil.Items.Add(new ListItem(actual.Descripcion, actual.ID.ToString()));
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Guid rolId = new Guid(ddlBusquedaRoles.SelectedValue);
            System.Data.DataRow row = null;

            List<Usuario> result = Usuario.Buscar(txtBusquedaNombre.Text, txtBusquedaPrimerNombre.Text, txtBusquedaPrimerApellido.Text, rolId);

            System.Data.DataTable tablaUsuarios = new System.Data.DataTable();
            tablaUsuarios.Columns.Add("Id");
            tablaUsuarios.Columns.Add("NombreUsuario");
            foreach (Usuario actual in result)
            {
                row = tablaUsuarios.NewRow();
                row["Id"] = actual.Id.ToString();
                row["NombreUsuario"] = actual.NombreUsuario;
                tablaUsuarios.Rows.Add(row);
            }

            tablaUsuarios.AcceptChanges();

            gvUsuarios.DataSource = tablaUsuarios;

            gvUsuarios.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDatosUsuario.Visible = true;
            Guid id = new Guid(((GridView)sender).SelectedValue.ToString());
            lblId.Text = ((GridView)sender).SelectedValue.ToString();
            Usuario result = Usuario.BuscarPorId(id);
            if (result != null)
            {
                txtNombreUsuario.Text = result.NombreUsuario;
            }
            txtNombreUsuario.Enabled = false;
            ddlRol.Enabled = false;

        }

        protected void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNombreUsuario.Enabled = true;
            ddlRol.Enabled = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblId.Text))
            {
                if(!string.IsNullOrEmpty(urlFoto))
                {
                    if (Usuario.Modificar(new Guid(lblId.Text), txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,
                        txtIdentificacion.Text, new Guid(ddlPais.SelectedValue), new Guid(ddlProvincia.SelectedValue),
                        new Guid(ddlCanton.SelectedValue), new Guid(ddlDistrito.SelectedValue), txtDireccion.Text,
                        txtCelular.Text, txtTelefonoHabitacion.Text, txtCorreo.Text, ("~//Imagenes//Usuarios//" + fuFoto.FileName),
                        rblGenero.SelectedValue, new Guid(ddlEstadoCivil.SelectedValue)))
                    { }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(urlFoto))
                {
                    var userStore = new UserStore<IdentityUser>();
                    var manager = new UserManager<IdentityUser>(userStore);
                    var user = new IdentityUser() { UserName = txtNombreUsuario.Text };
                    IdentityResult result = manager.Create(user, txtNombreUsuario.Text);
                    if (result.Succeeded)
                    {
                        lblId.Text = user.Id;
                        if (Usuario.Insertar(new Guid(user.Id), txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,
                            txtIdentificacion.Text, new Guid(ddlPais.SelectedValue), new Guid(ddlProvincia.SelectedValue),
                            new Guid(ddlCanton.SelectedValue), new Guid(ddlDistrito.SelectedValue), txtDireccion.Text,
                            txtCelular.Text, txtTelefonoHabitacion.Text, txtCorreo.Text, ("~//Imagenes//Usuarios//" + fuFoto.FileName), rblGenero.SelectedValue,
                            new Guid(ddlEstadoCivil.SelectedValue)))
                        { }
                    }
                    else
                    {
                        //    lblMensaje.Text = result.Errors.FirstOrDefault();
                        //    mpeMensaje.Show();
                    }
                }
            }
        }

        protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((DropDownList)sender).SelectedItem.Text == "Costa Rica")
            {
                meeIdentificacion.Enabled = true;
                List<Provincia> provincias = Provincia.Listar();
                foreach (Provincia actual in provincias)
                {
                    ddlProvincia.Items.Add(new ListItem(actual.Nombre, actual.Id.ToString()));
                }
                ddlProvincia.Items[0].Selected = true;
            }
            else
            {
                ddlProvincia.Items.Clear();
                ddlCanton.Items.Clear();
                ddlDistrito.Items.Clear();
                meeIdentificacion.Enabled = false;
            }
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCanton.Items.Clear();
            if (!String.IsNullOrEmpty(((DropDownList)sender).SelectedValue))
            {
                List<Canton> cantones = Canton.Listar(new Guid(((DropDownList)sender).SelectedValue));
                foreach (Canton actual in cantones)
                {
                    ddlCanton.Items.Add(new ListItem(actual.Nombre, actual.Id.ToString()));
                }
                if (((DropDownList)sender).Items.Count > 1)
                    ddlCanton.Items[0].Selected = true;
            }
        }

        protected void ddlCantón_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDistrito.Items.Clear();
            if (!String.IsNullOrEmpty(((DropDownList)sender).SelectedValue))
            {
                List<Distrito> distritos = Distrito.Listar(new Guid(((DropDownList)sender).SelectedValue));
                foreach (Distrito actual in distritos)
                {
                    ddlDistrito.Items.Add(new ListItem(actual.Nombre, actual.Id.ToString()));
                }
                if (((DropDownList)sender).Items.Count > 1)
                    ddlDistrito.Items[0].Selected = true;
            }
        }

        protected void btnCargarFoto_Click(object sender, EventArgs e)
        {
            if (fuFoto.HasFile)
            {
                string url = fuFoto.FileName;
                fuFoto.PostedFile.SaveAs(Server.MapPath("..") + "//Imagenes//Usuarios//" + url);
                urlFoto = "~//Imagenes//Usuarios//" + url;
                imgFoto.ImageUrl = urlFoto;
            }
        }
    }

}