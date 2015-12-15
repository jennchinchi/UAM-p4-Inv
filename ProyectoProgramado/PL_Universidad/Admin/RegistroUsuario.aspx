<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="PL_Universidad.Admin.RegistroUsuario" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" PopupControlID="pnlMensaje" TargetControlID="btnCrearUsuario"></ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="pnlMensaje" runat="server">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </asp:Panel>
    <div>
        <h1>Registro de usuario</h1>
    </div>
    <div>
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>
        <div>
            <span style="margin-bottom: 10px">
                <asp:Label ID="Label1" runat="server">Nombre de Usuario</asp:Label>
            </span>
            <span>
                <asp:TextBox runat="server" ID="txtUsuario" />
            </span>
        </div>
        <div>
            <span style="margin-bottom: 10px">
                <asp:Label ID="Label2" runat="server">Contraseña</asp:Label>
            </span>
            <span style="margin-bottom: 10px">
                <asp:TextBox runat="server" ID="txtContrasenna" TextMode="Password" />
            </span>
        </div>
        <div>
            <span style="margin-bottom:10px">
                <asp:Label ID="Label3" runat="server">Confirmar Contraseña</asp:Label>
            </span>
            <span>
                <asp:TextBox runat="server" ID="txtConfirmarContrasenna" TextMode="Password" />
            </span>
        </div>
        <div>
            <span style="margin-bottom:10px">
                <asp:Label ID="Label4" runat="server">Rol de usuario</asp:Label>
            </span>
            <span>
                <asp:DropDownList ID="ddlRol" runat="server" DataValueField="Id" DataTextField="Name"></asp:DropDownList>
            </span>
        </div>
        <div>
            <div>
                <asp:Button ID="btnCrearUsuario" runat="server" OnClick="CreateUser_Click" Text="Registrar" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
