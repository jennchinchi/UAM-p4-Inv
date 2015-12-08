<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrmInicioSesion.aspx.cs" Inherits="PL_Universidad.wfrmInicioSesion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Estilos/Login.css" rel="stylesheet" />
</head>
<body>
    <div>asddasasd</div>
    <form id="form1" runat="server">
    <h1>Universidad Saint Joseph
</h1>
         
    <h2>Inicio De Sesion</h2>
        <h5>Por favor digite sus credenciales</h5>
        <asp:TextBox id="txtNombreUsuario" placeholder="&#128272; Nombre" runat="server"></asp:TextBox>
        <asp:TextBox id="txtContrasenna" TextMode="Password" placeholder="&#128272; Contraseña" runat="server"></asp:TextBox>
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"/>
        <div id="registro">

              <a href="#"> &#33; Registrar Usuario</a>
            <div id="olvido">
             <a href="#">&#191;  Olvido su contraseña &#63; </a>
        </div>
        </div>
          
         
    </form>
</body>
</html>
