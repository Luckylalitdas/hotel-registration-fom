using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public void getdata()
        {
            
SqlConnection con = new SqlConnection("data source=DESKTOP-GFGHN9F\\SQLEXPRESS;database=webform;integrated security=yes");
           string query = "select * from registertable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               getdata();
            }
        }
                            //Row Editing
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //When ever user click on edit button we need to catch the row index and need to fill.
            //Bydefault row index is -1.
            GridView1.EditIndex = e.NewEditIndex;
            getdata();
        }


                            //Row Updating

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox t1 = (TextBox)row.FindControl("TextBox1");
            TextBox t2 = (TextBox)row.FindControl("TextBox2");
            SqlConnection con = new SqlConnection("data source=DESKTOP-GFGHN9F\\SQLEXPRESS;database=webform;integrated security=yes");
            con.Open();
            //pass the query
            var query = "update registertable  set lastname= '" + t2.Text + "' Where firstname='" + t1.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            getdata();
        }
                            //Row Cancel
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            getdata();
        }

                            //Row Deleting
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rows = GridView1.Rows[e.RowIndex];
            Label lbl = (Label)rows.FindControl("Label1");
            SqlConnection con = new SqlConnection("data source=DESKTOP-GFGHN9F\\SQLEXPRESS;database=webform;integrated security=yes");
            con.Open();
            //pass the query
            var query = "delete from registertable Where firstname ='" + lbl.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            getdata();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "Hotel registration";
            Response.Redirect("WebForm5.aspx");

        }
    }
}