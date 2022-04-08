using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_v1.Aspx
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Name_custom_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (Page.IsValid)
                {
                    Member user = new Member();

                    user.FirstName = First_name.Text;
                    user.LastName = Last_name.Text;
                    user.UserName = User_name.Text;
                    user.Password = Password.Text;
                    user.Email = Email.Text;
                    user.Gender = DropDownList_Gender.SelectedValue;
                    user.Role = "User";

                    if (!string.IsNullOrEmpty(Date_Birth.Text))
                    {
                        user.DateOfBirth = DateTime.Parse(Date_Birth.Text);
                    }

                    user.AddMemeber();

                    Response.Redirect("About_Us.aspx");
                }

            }
            catch (Exception error)
            {
                lblExceptionMessage.Text = "An error has occured! <br>" + error.Message;
            }


        }
    }
}