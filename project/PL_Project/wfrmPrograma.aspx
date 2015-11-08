<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfrmPrograma.aspx.cs" Inherits="PL_Project.wfrmPrograma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <div id='cssmenu'>
                    <ul>
                                               
                        <li><a href="#"><span>Gestion de Matricula</span></a></li>
                        <li><a href='#'><span>Consulta Programa</span></a></li>
                
                    </ul>
                    </div>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder4">

        <table border="0" style="width: 116%; height: 124px; font-style: italic; margin-left: 0px;">
    <tr>
        <td colspan="3" style="height: 53px; text-align: center">
            <asp:Label ID="Label1" runat="server" Text="Calendario de Cursos Lectivos"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 104px">
            <asp:Label ID="Label2" runat="server" Text="12 de enero"></asp:Label>
        </td>
        <td style="color: #000000; width: 12px">
            -</td>
        <td>
            <asp:Label ID="Label5" runat="server" Text="24 de abril"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 104px">
            <asp:Label ID="Label3" runat="server" Text="12 de mayo"></asp:Label>
        </td>
        <td style="color: #000000; width: 12px">
            -</td>
        <td>
            <asp:Label ID="Label6" runat="server" Text="24 de agosto"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 104px">
            <asp:Label ID="Label4" runat="server" Text="12 de setiembre"></asp:Label>
        </td>
        <td style="color: #000000; width: 12px">
            -</td>
        <td>
            <asp:Label ID="Label7" runat="server" Text="24 de diciembre"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>

