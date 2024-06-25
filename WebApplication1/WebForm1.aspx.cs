using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            string firstname = TextBox1.Text;
            string lastname = TextBox2.Text;
            string username = TextBox3.Text;
            string password = TextBox4.Text;
            string confirmpassword = TextBox5.Text;
            string gender = string.Empty;
            string language = string.Empty;
            string country = DropDownList1.SelectedItem.ToString();
            string email = TextBox10.Text;
            string address = TextBox11.Text;
            string phonenumber = TextBox9.Text;
            string age = TextBox12.Text;

            if (RadioButton1.Checked == true)
            {
                gender = RadioButton1.Text;
            }
            else
            {
                gender = RadioButton2.Text;
            }
            if(CheckBox1.Checked==true)
            {
                language = language + CheckBox1.Text;
            }
            if (CheckBox2.Checked == true)
            {
                language = language + CheckBox2.Text;
            }
            if (CheckBox3.Checked == true)
            {
                language = language + CheckBox3.Text;
            }
            if (CheckBox4.Checked == true)
            {
                language = language + CheckBox4.Text;
            }
            
            SqlConnection con = new SqlConnection("data source =DESKTOP-GFGHN9F\\SQLEXPRESS;database=webform;integrated security=yes");
            con.Open();
            string query = "insert into registertable values('" + firstname+"','"+lastname+"','"+username+"','"+password+"','"+confirmpassword+"','"+gender+"','"+country+"','"+language+"','"+email+"','"+address+"','"+phonenumber+"','"+age+"')";
            SqlCommand cmd=new SqlCommand( query, con );
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("WebForm2.aspx");
        }
    }
}