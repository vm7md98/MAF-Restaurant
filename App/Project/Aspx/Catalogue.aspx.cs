using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;



namespace Project_v1.Aspx
{
    public partial class Catalogue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated) { FormsAuthentication.RedirectToLoginPage(); }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Session["item_name"] = "Sushi";
            Session["price1"] = 125;
            Session["Category_Name"] = "Japanese Food";
            Session["Category_ID"] = "1";
            Session["Item_ID"] = "3";

            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);


            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price1"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];

            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();
            //Session["Total"] = ((int)Session["Total"]) + ((int)Session["price1"]);

            if (RowAdded == 1)
            {

            }


        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            /*to use javascript function in c#*/
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "m();", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Pasta";
            Session["price3"] = 95;
            Session["Category_Name"] = "Italian Food";
            Session["Category_ID"] = "2";
            Session["Item_ID"] = "6";

            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price3"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();
            //Session["Total"] = ((int)Session["Total"]) + ((int)Session["price3"]);

            if (RowAdded == 1)
            {

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Hummus";
            Session["price4"] = 15;
            Session["Category_Name"] = "Arabian Food";
            Session["Category_ID"] = "3";
            Session["Item_ID"] = "7";

            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price4"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();
            //Session["Total"] = ((int)Session["Total"]) + ((int)Session["price4"]);

            if (RowAdded == 1)
            {

            }

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Steak";
            Session["price5"] = 180;
            Session["Category_Name"] = "Turkish Food";
            Session["Category_ID"] = "4";
            Session["Item_ID"] = "8";

            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price5"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Burger";
            Session["price6"] = 35;
            Session["Category_Name"] = "American Food";
            Session["Category_ID"] = "5";
            Session["Item_ID"] = "9";


            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price6"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Wasabi";
            Session["price7"] = 40;
            Session["Category_Name"] = "Japanese Food";
            Session["Category_ID"] = "1";
            Session["Item_ID"] = "10";


            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price7"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Noodle";
            Session["price8"] = 30;
            Session["Category_Name"] = "Chinese Food";
            Session["Category_ID"] = "6";
            Session["Item_ID"] = "10";

            Session["Username22"] = "Abdullah1";

            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price8"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Bagel with Cheese";
            Session["price9"] = 18;
            Session["Category_Name"] = "European Food";
            Session["Category_ID"] = "7";
            Session["Item_ID"] = "11";


            Session["Username22"] = "Abdullah1";

            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price9"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Croissant";
            Session["price10"] = 9;
            Session["Category_Name"] = "European Food";
            Session["Category_ID"] = "7";
            Session["Item_ID"] = "12";


            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price10"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["item_name"] = "Pizza";
            Session["price2"] = 65;
            Session["Category_Name"] = "Italian Food";
            Session["Category_ID"] = "2";
            Session["Item_ID"] = "5";


            //open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn.Open();

            //we change it
            string sql = "INSERT INTO History VALUES(@Username,@ItemName,@Price,@CategoryId,@ItemId)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Price", SqlDbType.Int);
            cmd.Parameters.Add("@CategoryId", SqlDbType.NChar);
            cmd.Parameters.Add("@ItemId", SqlDbType.NChar);

            cmd.Parameters["@Username"].Value = User.Identity.Name;
            cmd.Parameters["@ItemName"].Value = Session["item_name"];
            cmd.Parameters["@Price"].Value = Session["price2"];
            cmd.Parameters["@CategoryId"].Value = Session["Category_ID"];
            cmd.Parameters["@ItemId"].Value = Session["Item_ID"];



            int RowAdded = cmd.ExecuteNonQuery();

            conn.Close();

            if (RowAdded == 1)
            {

            }
        }
    }
}