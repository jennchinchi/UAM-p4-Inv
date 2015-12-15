<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuPrincipal.ascx.cs" Inherits="PL_Universidad.Controles.MenuPrincipal" %>
<!--<link href="../Estilos/Menu.css" rel="stylesheet" />!-->

<link href="../Estilos/FrontEnd.css" rel="stylesheet" />
<link href="../Estilos/fontello.css" rel="stylesheet" />
<link href="../Estilos/MenuJQ.css" rel="stylesheet" />
<script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
<nav class="menu">
    <ul id="ulPrincipal" runat="server">
        <li class="submenu" id="quinto" runat="server"><a>Mantenimiento<span class="icon-down-open"></span></a>
            <ul>
                <li><a href="../Admin/Usuarios.aspx">Usuarios</a></li>
                <li><a href="#">Carreras</a></li>
                <li><a href="#">Variables</a></li>
            </ul>
        </li>
        <li class="submenu" id="inicio" runat="server"><a href="wfrmInicio.aspx">Inicio</a></li>
        <li class="submenu" id="primero" runat="server"><a href="wfrmExpediente.aspx">Expediente</a></li>
        <li class="submenu" id="segundo" runat="server"><a href="#">Programa</a></li>
        <li class="submenu" id="tercero" runat="server"><a href="#">Notas</a></li>
        <li class="submenu" id="cuarto" runat="server"><a href="#">Certificados</a></li>
    </ul>
</nav>
