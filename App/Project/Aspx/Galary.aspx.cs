using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project_v1.Classes;


namespace Project_v1
{
    public partial class Galary : System.Web.UI.Page
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
            string item_name = txtitem.Text;

            DataTable dt = Item.GetItemName(item_name);
            dl.DataSource = dt;
            dl.DataBind();
        }
    }
}