<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="ItemByPrice.aspx.cs" Inherits="Project_v1.ItemByPrice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Min"></asp:Label>
    <asp:TextBox ID="txtMin" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Max"></asp:Label>
    <asp:TextBox ID="txtMax" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>

    <br />
</asp:Content>
