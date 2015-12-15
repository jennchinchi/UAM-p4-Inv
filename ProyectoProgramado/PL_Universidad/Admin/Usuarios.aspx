<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="PL_Universidad.Admin.Usuarios" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Control de cuentas de usuario</h1>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <section class="divFormulario">
        <h2>Búsqueda de usuarios</h2>
        <br />
        <div class="tablaFormulario">
            <div class="tablaFormularioRow">
                <div class="tablaFormularioCell">
                    Nombre de usuario:
                </div>
                <div class="tablaFormularioCell">
                    <asp:TextBox CssClass="formTextBox" ID="txtBusquedaNombre" runat="server"></asp:TextBox>
                </div>
                <div class="tablaFormularioCell">
                </div>
                <div class="tablaFormularioCell">
                    Rol:
                </div>
                <div class="tablaFormularioCell">
                    <asp:DropDownList ID="ddlBusquedaRoles" CssClass="formDropDownList" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="tablaFormularioRow">
                <div class="tablaFormularioCell">
                    Primer nombre:
                </div>
                <div class="tablaFormularioCell">
                    <asp:TextBox CssClass="formTextBox" ID="txtBusquedaPrimerNombre" runat="server"></asp:TextBox>
                </div>
                <div class="tablaFormularioCell">
                </div>
                <div class="tablaFormularioCell">
                    Primer apellido:
                </div>
                <div class="tablaFormularioCell">
                    <asp:TextBox CssClass="formTextBox" ID="txtBusquedaPrimerApellido" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="tablaFormularioRow">
                <div class="tablaFormularioCell">
                </div>
                <div class="tablaFormularioCell">
                </div>
                <div class="tablaFormularioCell">
                </div>
                <div class="tablaFormularioCell">
                </div>
                <div class="tablaFormularioCell">
                    <asp:Button CssClass="button" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                </div>
            </div>
        </div>
        <br />
        <asp:UpdatePanel ID="udpUsuarios" runat="server">
            <ContentTemplate>
                <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Id" DataMember="Id">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                        <asp:CommandField SelectText="Editar" ShowSelectButton="True" />
                        <asp:HyperLinkField DataTextField="NombreUsuario" HeaderText="Nombre Usuario" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <EmptyDataRowStyle BorderStyle="Dashed" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <br />
                <hr />
                <br />
                <asp:Panel class="divFormulario" ID="pnlDatosUsuario" Visible="false" runat="server">
                    <h2>Datos del usuario</h2>
                    <div>
                        <div class="tablaFormulario">
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Nombre de usuario:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox CssClass="formTextBox" ID="txtNombreUsuario" runat="server"></asp:TextBox>*
                                    <asp:Label ID="lblId" runat="server" Visible="false" Text=""></asp:Label>
                                </div>
                                <div class="tablaFormularioCell">
                                    Rol:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:DropDownList ID="ddlRol" CssClass="formDropDownList" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Foto:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:FileUpload ID="fuFoto" runat="server" />
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:Button CssClass="button" Text="Cargar" runat="server" ID="btnCargarFoto" OnClick="btnCargarFoto_Click" />
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    <asp:Image ID="imgFoto" runat="server" Height="150px" Width="130px" ImageUrl="~/Imagenes/blank.jpg" />
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Nombre:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox CssClass="formTextBox" ID="txtNombre" runat="server"></asp:TextBox>*
                                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Requerido"
                                        CssClass="validatorMessage" ValidationGroup="vgGuardar"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Primer apellido:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox CssClass="formTextBox" ID="txtPrimerApellido" runat="server"></asp:TextBox>*
                                    <asp:RequiredFieldValidator ID="rfvPrimerApellido" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="Requerido"
                                        CssClass="validatorMessage" ValidationGroup="vgGuardar"></asp:RequiredFieldValidator>
                                </div>
                                <div class="tablaFormularioCell">
                                    Segundo apellido:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox CssClass="formTextBox" ID="txtSegundoApellido" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Género:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:RadioButtonList ID="rblGenero" runat="server" RepeatDirection="Horizontal">
                                        <asp:ListItem Value="Masculino" Selected="True">M</asp:ListItem>
                                        <asp:ListItem Value="Femenino">F</asp:ListItem>
                                        <asp:ListItem Value="Transgénero">T</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="tablaFormularioCell">
                                    Estado civil:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:DropDownList ID="ddlEstadoCivil" runat="server" CssClass="formDropDownList"
                                        DataTextField="Descripcion" DataValueField="ID">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    País:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:DropDownList ID="ddlPais" AutoPostBack="true" CssClass="formDropDownList" runat="server" OnSelectedIndexChanged="ddlPais_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="tablaFormularioCell">
                                    Número de identificación:
                                </div>
                                <div class="tablaFormularioCell">
                                    <ajaxToolkit:MaskedEditExtender ID="meeIdentificacion" runat="server" TargetControlID="txtIdentificacion" Mask="999999999"
                                        MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError"
                                        MaskType="Number" InputDirection="RightToLeft" AcceptNegative="None" DisplayMoney="None"
                                        ErrorTooltipEnabled="True" Enabled="false" />
                                    <asp:TextBox CssClass="formTextBox" TextMode="Number" ID="txtIdentificacion" runat="server"></asp:TextBox>*
                                    <asp:RequiredFieldValidator ID="rfvIdentificacion" runat="server" ControlToValidate="txtIdentificacion" ErrorMessage="Requerido"
                                        CssClass="validatorMessage" ValidationGroup="vgGuardar"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <br />
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Correo:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox CssClass="formTextBox" ID="txtCorreo" runat="server"></asp:TextBox>*
                                    <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Requerido"
                                        CssClass="validatorMessage" ValidationGroup="vgGuardar"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Teléfono habitación:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox ID="txtTelefonoHabitacion" runat="server"></asp:TextBox>
                                </div>
                                <div class="tablaFormularioCell">
                                    Celular:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:TextBox ID="txtCelular" CssClass="formTextBox" runat="server"></asp:TextBox>*
                                    <ajaxToolkit:MaskedEditExtender ID="meeCelular" TargetControlID="txtCelular" MaskType="Number" Mask="99999999" runat="server" AcceptNegative="None"
                                        ClearTextOnInvalid="true" />
                                    <asp:RequiredFieldValidator ID="rfvCelular" runat="server" ControlToValidate="txtCelular" ErrorMessage="Requerido"
                                        CssClass="validatorMessage" ValidationGroup="vgGuardar"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <br />
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Provincia:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:DropDownList ID="ddlProvincia" CssClass="formDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="tablaFormularioCell">
                                    Cantón:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:DropDownList ID="ddlCanton" CssClass="formDropDownList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCantón_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Distrito:
                                </div>
                                <div class="tablaFormularioCell">
                                    <asp:DropDownList ID="ddlDistrito" CssClass="formDropDownList" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">
                                    Dirección:
                                </div>
                            </div>
                            <div class="tablaFormularioRow">
                                <div class="tablaFormularioCell">

                                    <asp:TextBox ID="txtDireccion" TextMode="MultiLine" ValidateRequestMode="Enabled" runat="server" Width="50%"
                                        Height="60px"></asp:TextBox>*
                                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Requerido"
                                        CssClass="validatorMessage" ValidationGroup="vgGuardar"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div style="text-align: right">
                            <asp:Button CssClass="button" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CausesValidation="true" ValidationGroup="vgGuardar" />
                            <asp:Button CssClass="button" ID="btnCancelar" runat="server" Text="Cancelar" />
                            <asp:Button CssClass="button" ID="btnNuevoUsuario" runat="server" Text="Nuevo" OnClick="btnNuevoUsuario_Click" />
                        </div>
                    </div>
                </asp:Panel>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="ddlPais" />
                <asp:PostBackTrigger ControlID="ddlProvincia" />
                <asp:PostBackTrigger ControlID="ddlCanton" />
                <asp:PostBackTrigger ControlID="btnCargarFoto" />
            </Triggers>
        </asp:UpdatePanel>
    </section>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
