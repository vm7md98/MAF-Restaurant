using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Project_v1.Classes;
using System.Security.Principal;
using System.Web.Security;
namespace Project_v1
{
    public partial class ItemByPrice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated) 
            {
                FormsAuthentication.RedirectToLoginPage();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double min = double.Parse(txtMin.Text);
            double max = double.Parse(txtMax.Text);
            List<Item> BookByPrice = Item.GetItemByPrice(min,max);

            StringBuilder htmlTable = new StringBuilder();
            htmlTable.Append("<table border=1>");
            htmlTable.Append("<tr> <th>itemid</th> <th>itemname</th> <th>coverphoto</th> <th>price</th> <th>categoryid</th> </tr>");




            foreach (var r in BookByPrice)
            {
                //row author 
                htmlTable.Append("<tr>");
                htmlTable.Append("<td>" + r.ItemId + "</td>");
                htmlTable.Append("<td>" + r.ItemName + "</td>");
                htmlTable.Append("<td>" + r.CoverPhoto + "</td>");
                htmlTable.Append("<td>" + r.Price + "</td>");
                htmlTable.Append("<td>" + r.CategoryId + "</td>");
                htmlTable.Append("</tr>");



            }

            htmlTable.Append("</table>");

            Literal1.Text = htmlTable.ToString();
        }
    }
}