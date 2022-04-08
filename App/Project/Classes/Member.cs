using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project_v1
{
    public class Member
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Member() { }

        public void AddMemeber()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();


            string sql = "Insert into Member values (@username, @pwd, @role, @fname, @lname, @gender, @email, @dob)";
            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("username", this.UserName);
            cmd.Parameters.AddWithValue("pwd", this.Password);
            cmd.Parameters.AddWithValue("role", this.Role);
            cmd.Parameters.AddWithValue("fname", this.FirstName);
            cmd.Parameters.AddWithValue("lname", this.LastName);
            cmd.Parameters.AddWithValue("gender", this.Gender);
            cmd.Parameters.AddWithValue("email", this.Email);

            if (this.DateOfBirth.HasValue)
            {
                cmd.Parameters.AddWithValue("dob", this.DateOfBirth);
            }
            else
            {
                cmd.Parameters.AddWithValue("dob", DBNull.Value);
            }


            cmd.ExecuteNonQuery();
        }

        public static DataTable GetUser(string UserName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = "Select * from Member Where UserName = @username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", UserName);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();
            da.Dispose();


            return dt;
        }

        public static bool SignIn(string UserName, string Password)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = "Select count(*) from Member Where UserName = @username and password=@password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", UserName);
            cmd.Parameters.AddWithValue("password", Password);

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            if (count > 0) { return true; }
            else { return false; }
        }

        public Member(string UserName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = "Select * from Member where UserName = @username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", UserName);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.UserName = reader["UserName"].ToString();
                this.FirstName = reader["FirstName"].ToString();
                this.LastName = reader["LastName"].ToString();
                this.Role = reader["Role"].ToString();
                this.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                this.Email = reader["Email"].ToString();
                this.Gender = reader["Gender"].ToString();

            }
            conn.Close();

        }


        public static DataTable GetAllMembers()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = "Select * from Member";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();
            da.Dispose();


            return dt;

        }

        public static int Delete(string UserName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = "Delete  from Member Where UserName = @username ";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("username", UserName);


            int ex = cmd.ExecuteNonQuery();

            conn.Close();

            return ex;


        }



        public void update(string Username,string Password,string Role,string FirstName,string LastName,string Gender, string Email,DateTime? DateOfBirth) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = @"Update  Member set Password=@password, Role=@role, FirstName=@firstname,LastName=@lastname,Gender=@gender, Email=@email,DateOfBirth=@dateOfBirth WHERE UserName=@username";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("password", Password);
            cmd.Parameters.AddWithValue("role", Role);
            cmd.Parameters.AddWithValue("firstname", FirstName);
            cmd.Parameters.AddWithValue("lastname", LastName);
            cmd.Parameters.AddWithValue("gender",Gender);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("username", Username);

            if (this.DateOfBirth != null)
            {
                cmd.Parameters.AddWithValue("dateOfBirth", DateOfBirth);
            }
            else
            {
                cmd.Parameters.AddWithValue("dateOfBirth", DBNull.Value);
            }

            cmd.ExecuteNonQuery();


        }

        public static DataTable getMemberByUsername(string Username)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Config.GetConnectionStr();
            conn.Open();

            string sql = "Select * from Member Where Username = @username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", Username);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();
            da.Dispose();


            return dt;
        }

    }
}