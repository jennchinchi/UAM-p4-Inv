<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFormularios.Master" AutoEventWireup="true" CodeBehind="wfrmBuscarCursoEstudiante.aspx.cs" Inherits="PL_Universidad.Notas.wfrmBuscarCursoEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:100%;">
        <tr>
            <td colspan="3">&nbsp;<h1>&nbsp;</h1>
                <h1>&nbsp;</h1>
                <h1>Buscar curso</h1></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td class="auto-style1">Curso:</td>
            <td>
                <asp:DropDownList ID="cmbCursos" runat="server" Height="16px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="cmbCursos_SelectedIndexChanged" AppendDataBoundItems="True">
                    <asp:ListItem Text="--Seleccionar--" Value="" Selected="True" />
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;<h2>Estudiante por Curso</h2></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Estudiante:</td>
            <td>
                <asp:DropDownList ID="cmbEstudiantes" runat="server"  Height="16px" Width="200px" AutoPostBack="True" AppendDataBoundItems="true" OnSelectedIndexChanged="cmbEstudiantes_SelectedIndexChanged">
                    <asp:ListItem Text="--Seleccionar--" Value="" Selected="True" />
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

