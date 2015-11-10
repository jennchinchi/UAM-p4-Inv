<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrmLogin.aspx.cs" Inherits="PL_Project.wfrmLogin" %>

<!DOCTYPE html>

<html lang = "es">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form name="login-form" class="login-form" method="post" runat="server">
    <div class="header">
		<h1>UNIVERSIDAD LOS TRES PATOS</h1>

		<span>Por favor digite sus credenciales</span>
		</div>
	
		<div class="content">
		<input name="username" type="text" class="input username" placeholder="Usuario" />
		<div class="user-icon"></div>
		<input name="password" type="password" class="input password" placeholder="Contraseña" />
		<div class="pass-icon"></div>		
		</div>

		<div class="footer">
        
            <asp:Button class="button" runat="server" Text="Ingresar" OnClick="Unnamed1_Click" />
		<%--<a href="#" class="button">Ingresar</a>--%>
		</div>
    </form>
</body>
</html>
