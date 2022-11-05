using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


public partial class Reviews : System.Web.UI.Page
{
    MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True");

    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("select * from reviews", conn);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        cmd.Dispose();
        conn.Close();
    }
    protected void insertreviewbtn_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            string query = "insert into reviews(r_text,usrname)values('" + reviewtxtbox.Text + "','" + Session["username"] + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Thanks for your Review.";
            reviewtxtbox.Visible = false;
            insertreviewbtn.Visible = false;
            conn.Close();
        }
        else
        {
            Label1.Text = "Please login to share your review";
        }
    }
}