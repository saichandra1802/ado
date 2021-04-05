using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            using (SqlConnection con =new SqlConnection("Data Source=.;Initial Catalog=ado;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertUnqiueName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                   Response.Write(sdr["Name"] + " " + sdr["Gender"]);
                }

            }


                if (!Page.IsPostBack)
                {
                    if (ViewState["email"] != null)
                    {
                        email.Text = ViewState["email"].ToString();
                    }

                }
        }

        protected void login_Click(object sender, EventArgs e)
        {

            if (email.Text=="abc@g.com" && password.Text == "123")
            {
                // Storing email to Session variable  
                Session["email"] = email.Text;
                Response.Redirect("login.aspx");
            }
            // Checking Session variable is not empty  
            if (Session["email"] != null)
            {
                // Displaying stored email  
                Label3.Text = "This email is stored to the session.";
                Label4.Text = Session["email"].ToString();
            }
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {
            ViewState["email"] = email.Text;
            if (email.Text=="abc@gmil.com")
            {
                Label1.Text = "Email Exists";
            }
        }
    }
}