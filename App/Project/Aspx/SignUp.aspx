<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Project_v1.Aspx.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../CSS/SignUp.css" rel="stylesheet" type="text/css"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="signup-form">
                   <!-- Sign Up-->
      <h1>Sign Up</h1>
            <!--First name textbox and RequiredFieldValidator-->
      <asp:TextBox ID="First_name" runat="server" placeholder="First Name" class="txt"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter First Name" ControlToValidate="First_name" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <!--Last name textbox and RequiredFieldValidator-->
      <asp:TextBox ID="Last_name" runat="server" placeholder="Last Name" class="txt"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Last Name" ControlToValidate="Last_name" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

            <!--Date Textbox and RequiredFieldValidator-->
      <asp:TextBox ID="Date_Birth" runat="server" TextMode="Date" class="txt"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter DOB" ControlToValidate="DropDownList_Gender" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

                    <!--Gender DropDownList1 and RequiredFieldValidator-->
       <asp:DropDownList ID="DropDownList_Gender" runat="server" CssClass="txt">
         <asp:ListItem Value="" >Select your Gender</asp:ListItem>
         <asp:ListItem Value="M">Male</asp:ListItem>
         <asp:ListItem Value="F">Female</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Select your Gender" ControlToValidate="DropDownList_Gender" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

               <!--User name textbox and RequiredFieldValidator and CustomValidator-->
      <asp:TextBox ID="User_name" runat="server" placeholder="Username" class="txt"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Username" ControlToValidate="User_name" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
      <asp:CustomValidator runat="server" ErrorMessage="CustomValidator" ID="Name_custom" ControlToValidate="User_name" OnServerValidate="Name_custom_ServerValidate"></asp:CustomValidator>
               <!--Email textbox and RequiredFieldValidator-->
      <asp:TextBox ID="Email" runat="server" placeholder="Email" class="txt"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Username" ControlToValidate="Email" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

               <!--Password textbox and RequiredFieldValidator-->
      <asp:TextBox ID="Password" runat="server" placeholder="Password" class="txt" TextMode="Password"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Password" ControlToValidate="Password" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

                <!--Confirm Password textbox and RequiredFieldValidator and CompareValidator-->
      <asp:TextBox ID="Confirm_password" runat="server" placeholder="Confirm Password" class="txt" TextMode="Password"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="password" ControlToValidate="Confirm_password" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
      <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password doesn't match" ControlToCompare="Password" ControlToValidate="Confirm_password"></asp:CompareValidator>
                <!--Button-->
              <asp:Button ID="Button1" runat="server" Text="Sign Up" class="signup-btn" OnClick="Button1_Click" Height="41px"/>

                <!--To Login-->
        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ready" NavigateUrl="~/Login.aspx">Already Have one ?</asp:HyperLink>
                   <br />
                   <asp:Label ID="lblExceptionMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
</asp:Content>
