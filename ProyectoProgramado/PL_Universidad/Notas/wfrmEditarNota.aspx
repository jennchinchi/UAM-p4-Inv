<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFormularios.Master" AutoEventWireup="true" CodeBehind="wfrmEditarNota.aspx.cs" Inherits="PL_Universidad.Notas.wfrmEditarNota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style3
        {
            width: 156px;
            text-align: left;
            font-family: Calibri;
            font-size: 15px;
            color: #249ED6;
            height: 69px;
        }
        .auto-style4
        {
            height: 69px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:100%;">
        <tr>
            <td colspan="3">&nbsp;<h1>&nbsp;</h1>
                <h1>&nbsp;</h1>
                <h1>Nota del Estudiante</h1></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;<h2>Nota por Rubro</h2></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr> 
         <tr>
            <td class="auto-style1">Materia:</td>
            <td>
                <asp:TextBox ID="txtMateria" runat="server" Height="16px" Width="200px" Enabled="False"></asp:TextBox>
            </td>
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
                <asp:TextBox ID="txtEstudiante" runat="server" Height="16px" Width="200px" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Rubro:</td>
            <td>
                <asp:TextBox ID="txtRubro" runat="server" Height="16px" Width="200px" Enabled="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Nota:</td>
            <td>
                <asp:TextBox ID="txtNota" runat="server" Height="16px" Width="200px"></asp:TextBox>
                <asp:Label ID="lblPorcentaje" runat="server"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNota" ErrorMessage="Solo numeros" ValidationExpression="^\d+$">*</asp:RegularExpressionValidator>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <asp:Button ID="btnModificar" runat="server" Height="47px" OnClick="btnRegistrar_Click" Text="Modificar" Width="125px" />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"></td>
        </tr>     
    </table>

</asp:Content>

