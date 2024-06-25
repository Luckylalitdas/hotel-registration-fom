using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UserName = TextBox1.Text;
            string Roomtype =string .Empty;
            string Amenities = string.Empty;
            
            if (CheckBox1.Checked == true)
            {
                
                Amenities = CheckBox1.Text + ",";
            }
            if (CheckBox2.Checked == true)
            {
               
                Amenities = Amenities + CheckBox2.Text;
            }
            if(RadioButton1.Checked==true)
            {
               
                Roomtype =  RadioButton1.Text;
            }
            else if (RadioButton2.Checked==true)
            {
               
                Roomtype =  RadioButton2.Text;
            }
            SqlConnection con = new SqlConnection("data source =DESKTOP-GFGHN9F\\SQLEXPRESS;database=webform;integrated security=yes");
            con.Open();
            string query = "insert into hotelform values('" + UserName + "','" + Roomtype + "','" + Amenities + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("WebForm6.aspx");



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             
        }
    }
}