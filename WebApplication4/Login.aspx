<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication4.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" runat="server">
    <form id="form1" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp; IIII AEEEE GALERA!!! EU SOU A PÁGINA QUE VAI TE LOGAR, ENTÃO NÃO ERRA</p>
    <p>
        &nbsp;&nbsp;&nbsp; Login:
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp; Senha:
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogar" runat="server" OnClick="btnLogar_Click" Text="LOGA AQUI!!!!" Width="171px" />
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAlerta" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lbtnLogout" runat="server" OnClick="lbtnLogout_Click" Visible="False">Logout</asp:LinkButton>
    </p>
</form>
</asp:Content>
