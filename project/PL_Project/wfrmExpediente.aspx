<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfrmExpediente.aspx.cs" Inherits="PL_Project.wfrmExpediente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 99%; height: 923px;">
    <tr>
        <td colspan="2" style="height: 35px">
            <asp:Label ID="Label24" runat="server" Font-Size="Large" Text="DATOS PERSONALES"></asp:Label>
        </td>
        <td style="height: 35px">
            </td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="height: 35px; width: 220px">
            <asp:Label ID="Label1" runat="server" Text="Identificacion:"></asp:Label>
        </td>
        <td style="height: 35px">
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td rowspan="2" style="width: 138px">
            &nbsp;</td>
        <td style="height: 35px; width: 220px">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            :</td>
        <td style="height: 35px">
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 35px; width: 220px">
            <asp:Label ID="Label4" runat="server" Text="Primer Apellido:"></asp:Label>
        </td>
        <td style="height: 35px">
            <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td rowspan="2" style="width: 138px">
            &nbsp;</td>
        <td style="height: 35px; width: 220px">
            <asp:Label ID="Label5" runat="server" Text="Segundo Apellido:"></asp:Label>
        </td>
        <td style="height: 35px">
            <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 35px; width: 220px">
            <asp:Label ID="Label6" runat="server" Text="Correo Electronico:"></asp:Label>
        </td>
        <td style="height: 35px">
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td rowspan="2" style="width: 138px">
            &nbsp;</td>
        <td style="height: 36px; width: 220px">
            <asp:Label ID="Label7" runat="server" Text="Numero Movil:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox6" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 36px; width: 220px">
            <asp:Label ID="Label8" runat="server" Text="Numero Fijo:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox7" runat="server" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td rowspan="2" style="width: 138px">
            &nbsp;</td>
        <td style="height: 36px; width: 220px">
            <asp:Label ID="Label9" runat="server" Text="Genero:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox8" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 36px; width: 220px">
            <asp:Label ID="Label10" runat="server" Text="Estado Civil:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:DropDownList ID="DropDownList1" runat="server" Width="175px" Height="16px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td rowspan="3" style="width: 138px">
            &nbsp;</td>
        <td style="height: 36px; width: 220px">
            <asp:Label ID="Label11" runat="server" Text="Direccion de Residencia:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox10" runat="server" Width="165px" Height="19px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 36px; width: 220px">
            <asp:Label ID="Label12" runat="server" Text="Foto Tamaño Pasaporte:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="height: 36px; width: 220px">
            &nbsp;</td>
        <td style="height: 36px">
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label3" runat="server" Text="DATOS LABORALES" Font-Size="Large"></asp:Label>
        </td>
        <td style="height: 36px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label13" runat="server" Text="Nombre de la emresa:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox11" runat="server" Height="22px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label14" runat="server" Text="Ubicacion:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox12" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label15" runat="server" Text="Puesto:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox13" runat="server" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label16" runat="server" Text="Numero de telefono:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox14" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px; height: 36px;">
            </td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label17" runat="server" Text="Años de Antiguedad:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox15" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label18" runat="server" Font-Size="Large" Text="DATOS ACADEMICOS"></asp:Label>
        </td>
        <td style="height: 36px">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 138px; height: 36px;">
            </td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label19" runat="server" Text="Nombre de la Institucion Egresada:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox17" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px; height: 36px;">
            </td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label20" runat="server" Text="Numero de Folio:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox18" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px; height: 36px;">
            </td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label21" runat="server" Text="Numero de Tomo:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox19" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="width: 220px; height: 36px">
            <asp:Label ID="Label22" runat="server" Text="Numeri de Asiento:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:TextBox ID="TextBox20" runat="server" Height="16px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 138px">
            &nbsp;</td>
        <td style="width: 220px; height: 36px">
            &nbsp;<asp:Label ID="Label23" runat="server" Text="Imagen del  Titulo:"></asp:Label>
        </td>
        <td style="height: 36px">
            <asp:FileUpload ID="FileUpload2" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="width: 138px; height: 133px;">
            </td>
        <td style="width: 220px; height: 133px">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="48px" ImageUrl="~/images/add person.png" ToolTip="Guardar Todos Los Datos" Width="75px" />
        </td>
        <td style="height: 133px">
            <asp:ImageButton ID="ImageButton2" runat="server" Height="48px" ImageUrl="~/images/clea.png" Width="75px" ToolTip="Limpiar Todos Los Datos" />
        </td>
    </tr>
        
    </table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">

    
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder3">
</asp:Content>


