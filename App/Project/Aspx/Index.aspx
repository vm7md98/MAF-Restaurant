<%@ Page Title="" Language="C#" MasterPageFile="/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Project_v1.Index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="https://fonts.googleapis.com/css?family=Raleway&display=swap" rel="stylesheet">

	<link rel="stylesheet" href="../CSS/StyleSheet_Index.css" />

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div class="background">
		<div class="Title">
			<div class="Name">
				<h1>MAF Restaurant</h1>
				<hr>
				<p>This website is for "MAF Restaurant" and it contains a lot of helpful things that would let you know about us better.
					<br>
					<br>
					Please give us some of your time to check our "About Us" section and "Survey" so we can improve our selves to provide you an excellent service.
				</p>
				<br>
				<br>
				</div>
				<div class="CTA">
				<asp:Button ID="Button1" runat="server" Text="About US" CssClass="button1" PostBackUrl="~/Aspx/About_Us.aspx" />
				</div>
		</div>
	</div>

</asp:Content>
