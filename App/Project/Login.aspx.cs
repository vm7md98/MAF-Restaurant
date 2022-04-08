using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;

namespace Project_v1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string password = Login1.Password;
            bool isPersistent = Login1.RememberMeSet;
            bool signedin = Member.SignIn(username, password);

            if (signedin)
            {
                Member user = new Member(username);

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddMinutes(2880), isPersistent, user.Role);


                string encTicket = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName,encTicket);

                if (isPersistent)
                {
                    cookie.Expires = ticket.Expiration;
                }
                Response.Cookies.Add(cookie);

                Response.Redirect("Aspx/Index.aspx");
            }
            e.Authenticated = false;
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}