using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_v1
{
    public partial class AllMembers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable table = Member.GetAllMembers();
            GridView1.DataSource = table;
            GridView1.DataBind();


            if (!User.IsInRole("A"))
            {
                GridView1.Visible = false;
                Response.Redirect("No_Acess.aspx");
                
                

                return;
            }
            else
            {

                GridView1.Visible = true;


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Delete_txt = TextBox1.Text;
            int check=Member.Delete(Delete_txt);

            if(check == 1) 
            {
                Response.Write("<script>alert('Data Deleted successfully')</script>");


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Update_txt = TextBox2.Text;

            DataTable m = Member.getMemberByUsername(Update_txt);

            if (m.Rows.Count==0) 
            {
                lbl_update.Text = "Member Not Found";
            }
            else 
            {
                GridView2.DataSource = m;
                GridView2.DataBind();

                TextBox3.Text = m.Rows[0]["Password"].ToString();
                TextBox4.Text = m.Rows[0]["Role"].ToString();
                TextBox5.Text = m.Rows[0]["FirstName"].ToString();
                TextBox6.Text = m.Rows[0]["LastName"].ToString();
                TextBox7.Text = m.Rows[0]["Gender"].ToString();
                TextBox8.Text = m.Rows[0]["Email"].ToString();
                TextBox9.Text = m.Rows[0]["DateOfBirth"].ToString();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string Update_txt = TextBox2.Text;

            string Password = TextBox3.Text;
            string Role = TextBox4.Text;
            string FirstName = TextBox5.Text;
            string LastName = TextBox6.Text;
            string Gender = TextBox7.Text;
            string Email = TextBox8.Text;
            DateTime? DateOfBirth = Convert.ToDateTime(TextBox9.Text);
            //Convert.ToDateTime(TextBox9.Text)
            Member m = new Member(Update_txt);
            m.update(Update_txt,Password, Role, FirstName, LastName, Gender, Email, DateOfBirth);
        }
    }
}