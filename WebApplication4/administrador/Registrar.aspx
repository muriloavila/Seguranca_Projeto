<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="WebApplication4.administrador.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
    <form id="form1" runat="server">
        <p>
&nbsp;&nbsp;&nbsp;&nbsp; <h1>&nbsp;&nbsp; Registrar Novo Usuário</h1></p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp; Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp; Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp; Senha:
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCadastrar" runat="server" Text="CADASTRAR" Width="165px" OnClick="btnCadastrar_Click" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAlerta" runat="server"></asp:Label>
        &nbsp;&nbsp;
            <asp:LinkButton ID="lbtnDelete" runat="server" OnClick="lbtnDelete_Click">Deletar Usuarios</asp:LinkButton>
        </p>
    </form>
</asp:Content>
