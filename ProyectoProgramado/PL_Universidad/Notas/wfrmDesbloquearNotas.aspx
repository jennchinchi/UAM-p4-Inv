<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFormularios.Master" AutoEventWireup="true" CodeBehind="wfrmDesbloquearNotas.aspx.cs" Inherits="PL_Universidad.Notas.wfrmDesbloquearNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="width:100%;"> 
        <tr>
            <td class="auto-style1">Curso:</td>
            <td>
                <asp:DropDownList ID="cmbCursos" runat="server" Height="16px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="cmbCursos_SelectedIndexChanged" AppendDataBoundItems="True">
                    <asp:ListItem Text="--Seleccionar--" Value="" Selected="True" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Estudiante</td>
            <td>
                <asp:DropDownList ID="cmbEstudiantes" runat="server"  Height="16px" Width="200px" AutoPostBack="True" AppendDataBoundItems="true" OnSelectedIndexChanged="cmbEstudiantes_SelectedIndexChanged">
                    <asp:ListItem Text="--Seleccionar--" Value="" Selected="True" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>     
        <tr>
            <td colspan="2">
                <asp:GridView ID="gridCalificaciones" runat="server" Width="656px" AutoGenerateColumns="False" OnRowCommand="gridCalificaciones_RowCommand" OnSelectedIndexChanged="gridCalificaciones_SelectedIndexChanged1">
                    <Columns>
                        <asp:BoundField DataField="Nota" HeaderText="Nota" />
                        <asp:BoundField DataField="DescripcionRubro" HeaderText="Rubro" />
                        <asp:BoundField DataField="Materia" HeaderText="Curso" />
                        <asp:ButtonField ButtonType="Button" Text="Habilitar" CommandName="habilitar" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>     
    </table>

</asp:Content>

