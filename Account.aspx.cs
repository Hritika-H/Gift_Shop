using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            acclbl.Text = "Hello " + Session["username"] + " these are some of your old purchases";
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from orderdetails where o_uname='" + Session["username"] + "'", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
          /*  DataTable dt = new DataTable();
            dr = dt.NewRow();
            dr["oid"] = ds.Tables[0].Rows[0]["odid"].ToString();
            dr["productid"] = ds.Tables[0].Rows[0]["orderid"].ToString();

          

            dr["productname"] = ds.Tables[0].Rows[0]["oproductname"].ToString();
            dr["date of order"] = ds.Tables[0].Rows[0]["dateoforder"].ToString();
   
  
            dr["totalprice"] = ds.Tables[0].Rows[0]["oprice"];
            dt.Rows.Add(dr);*/

            AccGridView.DataSource = ds;
            AccGridView.DataBind();
            cmd.Dispose();
            conn.Close();
        }
    }
}