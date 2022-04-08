<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Galary.aspx.cs" Inherits="Project_v1.Galary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <link rel="stylesheet" href="../CSS/Galary.css" />

            <style type="text/css">
                .auto-style1 {
                    height: 20px;
                }
            .auto-style2 {
        width: 214px;
    }
    .auto-style3 {
        width: 214px;
        height: 20px;
    }
            </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="contain">
         <asp:TextBox ID="txtitem" runat="server"></asp:TextBox>
         <asp:DataList ID="dl" runat="server" Width="100%">
             <ItemTemplate>
                 <table style="width:100%;">
                     <tr>
                         <td class="auto-style1" colspan="2">
                             <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("ItemName") %>'></asp:Literal>
                         </td>
                         <td class="auto-style1"></td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:Image ID="Image3" runat="server" Height="150px" ImageUrl='<%# "/Images/img2/"+Eval("CoverPhoto") %>' Width="150px" />
                         </td>
                         <td>
                             Price :
                             <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("Price") %>'></asp:Literal>
                         </td>
                         <td>&nbsp;</td>
                     </tr>
                     <tr>
                         <td class="auto-style3"></td>
                         <td class="auto-style1"></td>
                         <td class="auto-style1"></td>
                     </tr>
                 </table>
             </ItemTemplate>
         </asp:DataList>
         <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click"  />
        </div>
</asp:Content>
