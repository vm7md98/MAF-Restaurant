<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Catalogue.aspx.cs" Inherits="Project_v1.Aspx.Catalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="../CSS/Catalogue.css" />
  <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
      <script type="text/javascript" src="../JavaScript.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="big_box">
      <div class="box_1">
          
          <table id="food">
              <tr>
                <th>Name</th>
                <th>Desc</th>
                <th>Price</th>
              </tr>
              <tr onmouseover="b1()" id="p1">
                 <td><p >Sushi</p></td>
                 <td><p>Japanese Food</p></td>
                 <td><p>125 AED</p></td>
              </tr>
              <tr onmouseover="b2()" id="p2">
                 <td><p >Pizza</p></td>
                 <td><p>Italian Food</p></td>
                 <td><p>65 AED</p></td>
              </tr> 
              <tr  onmouseover="b3()" id="p3">
                 <td><p>Pasta</p></td>
                 <td><p>Italian Food</p></td>
                 <td><p>95 AED</p></td>
              </tr>
              <tr onmouseover="b4()" id="p4">
                 <td><p >Hummus</p></td>
                 <td><p>Arabian Food</p></td>
                 <td><p>15 AED</p></td>

              </tr>
              <tr onmouseover="b5()" id="p5">
                 <td><p >Steak</p></td>
                 <td><p>Turkish Food</p></td>
                 <td><p>180 AED</p></td>
              </tr>
              <tr  onmouseover="b6()" id="p6">
                 <td><p>Burger</p></td>
                 <td><p>American Food</p></td>
                 <td><p>35 AED</p></td>
              </tr>
                 <tr onmouseover="b7()" id="p7">     
                  <td><p >Wasabi</p></td>
                  <td><p>Japanese Food</p></td>
                  <td><p>40 AED</p></td>
              </tr>
              <tr onmouseover="b8()" id="p8">         
                  <td><p >Noodle</p></td>
                  <td><p>Chinese Food</p></td>
                  <td><p>30 AED</p></td>
                  
              </tr>
              <tr onmouseover="b9()" id="p9">
                  <td><p >Bagel with Cheese</p></td>
                  <td><p>European Food</p></td>
                  <td><p>18 AED</p></td>
              </tr>             
              <tr onmouseover="b10()" id="p10">
                  <td><p >Croissant</p></td>
                  <td><p>European Food</p></td>
                  <td><p>9 AED</p></td>
              </tr>    
          </table>

       </div>
            <!--Show()  مادري شو الفايده منه-->
           <div class="box_2" id="show">
               <div id="hide">
                   <h1>Please point to the items that you want to buy</h1>
               </div>
             <div id="f1">
              <asp:Image ID="img" runat="server" ImageUrl="~/Images/img2/sushi.jpg" CssClass="c" />
              
              <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" CssClass="btn" />
               </div>

             <div id="f2">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/img2/Pizza.jpg" CssClass="c" />
               
              <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" CssClass="btn"/>
               </div>
             <div id="f3">
              <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/img2/Pasta.jpg" CssClass="c" />
               
                 <asp:Button ID="Button4" runat="server" Text="Add" OnClick="Button4_Click" CssClass="btn"/>
               </div>
             <div id="f4">
              <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/img2/Hummus.jpg" CssClass="c" />
              
                 <asp:Button ID="Button5" runat="server" Text="Add" OnClick="Button5_Click" CssClass="btn"/>
               </div>
             <div id="f5">
              <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/img2/Steak.jpg" CssClass="c" />
               
                 <asp:Button ID="Button6" runat="server" Text="Add" OnClick="Button6_Click" CssClass="btn"/>
               </div>
             <div id="f6">
              <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/img2/Burger.jpg" CssClass="c" />
               
                 <asp:Button ID="Button7" runat="server" Text="Add" OnClick="Button7_Click" CssClass="btn"/>
               </div>
             <div id="f7">
               <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/img2/Wasabi.jpg" CssClass="c" />
                 <asp:Button ID="Button8" runat="server" Text="Add" OnClick="Button8_Click" CssClass="btn" />
               </div>
             <div id="f8">
              <asp:Image ID="Image7" runat="server" ImageUrl="~/Images/img2/Noodle.jpg" CssClass="c" />
                 <asp:Button ID="Button9" runat="server" Text="Add" OnClick="Button9_Click" CssClass="btn"/>
               </div>
             <div id="f9">
              <asp:Image ID="Image8" runat="server" ImageUrl="~/Images/img2/bagel-with-cheese.jpg" CssClass="c" />
                 <asp:Button ID="Button10" runat="server" Text="Add" OnClick="Button10_Click" CssClass="btn" />
               </div>
             <div id="f10">
             <asp:Image ID="Image9" runat="server" ImageUrl="~/Images/img2/croissant.jpg" CssClass="c" />
                 <asp:Button ID="Button11" runat="server" Text="Add" OnClick="Button11_Click" CssClass="btn" />
               </div>
			<asp:Button ID="Button3" runat="server" Text="Buy" OnClick="Button3_Click" CssClass="Pr_btn"/>
           </div>
        </div>
</asp:Content>
