using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Username = TextBox1.Text;
            string Password = TextBox2.Text;
            SqlConnection Con = new SqlConnection("data source = DESKTOP-GFGHN9F\\SQLEXPRESS;database=webform;integrated security = yes;");
            Con.Open();
            string query = "select password from registertable where username='" + Username + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            Password = cmd.ExecuteScalar().ToString();
            
            if (Password == TextBox2.Text)
            {
                Response.Redirect("WebForm4.aspx");
            }
            else
            {
                Label3.Text = " invalid credentials !!! ";
            }
            Con.Close();

        }
    }
}