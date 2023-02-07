<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="None" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="User_Manager.Crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>REGISTRAR USUARIO</h1>
    <div>
        <asp:Panel ID="pnlId" runat="server" Visible="false">
            <div class="row">
                <div class="col-4">
                    <div class="mb-1">
                        <asp:Label ID="lblId" runat="server" CssClass="form-label" Text="Id: "></asp:Label>
                        <asp:TextBox ID="txtId" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
        </asp:Panel>

        <div>
            <asp:Label ID="lblNombre" runat="server" CssClass="form-label" Text="Nombres: "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" CssClass="text-error" ErrorMessage="Ingresar Nombre" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="lblApellido" runat="server" CssClass="form-label" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" CssClass="text-error" ErrorMessage="Ingresar Apellidos" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="lblEdad" runat="server" CssClass="form-label" Text="Edad: "></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEdad" runat="server" CssClass="text-error" ErrorMessage="Ingresar Edad" ControlToValidate="txtEdad"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEdad" runat="server" CssClass="text-error" ValidationExpression="^([0-9])*$" ErrorMessage="Ingresa solo numero" ControlToValidate="txtEdad"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Label ID="lblCorreo" runat="server" CssClass="form-label" Text="Correo: "></asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-error" ErrorMessage="Ingresar Correo" ControlToValidate="txtEdad"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revCorreo" runat="server" CssClass="text-error" ValidationExpression="^[^@]+@[^@]+\.[a-zA-Z]{2,}$" ErrorMessage="Ingresa solo numero" ControlToValidate="txtCorreo"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Label ID="lblNacionalidad" runat="server" CssClass="form-label" Text="Nacionalidad: "></asp:Label>
            <asp:DropDownList ID="ddlNacionalidad" runat="server" CssClass="form-select">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvNacionalidad" runat="server" CssClass="text-error" ErrorMessage="Seleecionar Nacionalidad" ControlToValidate="ddlNacionalidad"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="lblGenero" runat="server" CssClass="form-label" Text="Genero: "></asp:Label>
            <asp:DropDownList ID="ddlGenero" runat="server" CssClass="form-select">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvGenero" runat="server" CssClass="text-error" ErrorMessage="Seleccionar Genero" ControlToValidate="ddlGenero"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="lblPerfil" runat="server" CssClass="form-label" Text="Perfil: "></asp:Label>
            <asp:DropDownList ID="ddlPerfil" runat="server" CssClass="form-select">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvPerfil" runat="server" CssClass="text-error" ErrorMessage="Seleccionar Perfil" ControlToValidate="ddlPerfil"></asp:RequiredFieldValidator>
        </div>

        <div>
            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>

        <asp:Label ID="lblResultado" runat="server" CssClass="form-label" Text="Resultado: "></asp:Label>

    </div>
</asp:Content>
