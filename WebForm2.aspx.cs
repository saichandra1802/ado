using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
              
                // Creating HttpCookie instance by specifying name "student"  
                HttpCookie cokie = new HttpCookie("student");
                // Assigning value to the created cookie  
                cokie.Value = "Rahul Kumar";
                // Adding Cookie to the response instance  
                Response.Cookies.Add(cokie);
                //--------------- Fetching Cookie -------------------------//  
                var co_val = Response.Cookies["student"].Value;
                Label1.Text = co_val;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\saichandra\Source\Repos\WebApplication5\XMLFile1.xml";
            FileInfo file = new FileInfo(filePath);
            if (file.Exists)
            {
                // Clear Rsponse reference  
                Response.Clear();
                // Add header by specifying file name  
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                // Add header for content length  
                Response.AddHeader("Content-Length", file.Length.ToString());
                // Specify content type  
                Response.ContentType = "text/plain";
                // Clearing flush  
                Response.Flush();
                // Transimiting file  
                Response.TransmitFile(file.FullName);
                Response.End();
            }
        }
    }
}