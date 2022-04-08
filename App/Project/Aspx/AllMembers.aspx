<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AllMembers.aspx.cs" Inherits="Project_v1.AllMembers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
                <style type="text/css">
                    
                    .CRUD{margin-left:10px}
                    .txt_mar
                    {
                        margin-left:10px;
                        margin-top:10px
                    }
                    .mar{margin:10px;}
                    .grid
                    {
                        margin-left:20px;
                        margin-top:20px;
                        margin-bottom:20px;
                    }
                    h6{display:inline;margin-right:10px}
            </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="CRUD" ">

        <h1> All Member</h1>
    <asp:GridView  ID="GridView1" runat="server" >
    </asp:GridView>
        <hr />
        <hr />

        <div class="mar">
        <%--delete--%>
     <h3> Enter Username to delete</h3>
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="DELETE" OnClick="Button1_Click"  />
        </div>
        <hr />

        <div class="mar">
        <%--find by username--%>
         <h3> Enter Username to Find information</h3>
    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="FIND" OnClick="Button2_Click"  />
    <asp:Label ID="lbl_update" runat="server" Text="Label"></asp:Label>
        </div>


        <div class="grid">
            
            <h3 style="margin:10px">Selected Member</h3>
     <asp:GridView ID="GridView2" runat="server"></asp:GridView>

        </div>

        <hr />
      <div class="txt_mar">
     <h6> Password</h6><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
     <h6> Role</h6><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
     <h6> FirstName</h6><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
     <h6> LastName</h6><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
     <h6> Gender</h6><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
     <h6> Email</h6><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
     <h6> DateOfBirth</h6><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
       </div>
        <asp:Button ID="Button3" runat="server" Text="UPDATE" OnClick="Button3_Click"  />

        </div>

</asp:Content>
