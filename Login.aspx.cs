using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //BindData();
    }

    protected void loginbtn_Click(object sender, EventArgs e)
    {
        if (loginuname.Text == "Admin" && loginpasswd.Text == "admin123")
        {
            Response.Redirect("AdminPage .aspx");
        }
        else
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=giftshopdb; password=root; allowuservariables=True");
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from customerdata where c_uname = '" + loginuname.Text + "'and c_passwd = '" + loginpasswd.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Loginmsg.Text = "Login Successful";

                Session["username"] = loginuname.Text;
                Session["buyitems"] = null;
                //fillsavedCart();
                Response.Redirect("Account.aspx");
            }
            else
            {
                Loginmsg.Text = "Invalid Login Please check your username and password";
            }
            conn.Close();
        }

    }
     public void BindData()
     {
         MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True");
         conn.Open();
         MySqlCommand cmd = new MySqlCommand("select * from customerdata", conn);
         MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
         DataSet ds = new DataSet();
         adp.Fill(ds);
         GridView1.DataSource = ds;
         GridView1.DataBind();
         cmd.Dispose();
         conn.Close();

     }

  /*  private void fillsavedCart()
    {
        DataTable dt = new DataTable();
        DataRow dr;
        dt.Columns.Add("sno");
        dt.Columns.Add("productid");
        dt.Columns.Add("scmake");
        dt.Columns.Add("scmodel");/*mycode*
        dt.Columns.Add("productname");
        dt.Columns.Add("scdescription");
        dt.Columns.Add("quantity");
        dt.Columns.Add("price");
        dt.Columns.Add("totalprice");
        dt.Columns.Add("productimage");

        String mycon = "server=localhost;user id=root;persistsecurityinfo=True;database=jaykantdb; password=root; allowuservariables=True";
        MySqlConnection scon = new MySqlConnection(mycon);
        String myquery = "select * from savedcart where username='" + Session["username"].ToString() + "'";
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = scon;
        MySqlDataAdapter da = new MySqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            int i = 0;
            int counter = ds.Tables[0].Rows.Count;
            while (i < counter)
            {
                dr = dt.NewRow();
                dr["sno"] = i + 1;
                dr["productid"] = ds.Tables[0].Rows[i]["productid"].ToString();
                /*mycode*
                dr["scmake"] = ds.Tables[0].Rows[0]["scmake"];
                dr["scmodel"] = ds.Tables[0].Rows[0]["scmodel"];

                dr["productname"] = ds.Tables[0].Rows[i]["productname"].ToString();

                dr["scdescription"] = ds.Tables[0].Rows[0]["scdescription"].ToString();

                dr["productimage"] = ds.Tables[0].Rows[i]["productimage"].ToString();
                dr["quantity"] = "1";
                dr["price"] = ds.Tables[0].Rows[i]["price"].ToString();
                int price1 = Convert.ToInt16(ds.Tables[0].Rows[i]["price"].ToString());
                int quantity1 = Convert.ToInt16(ds.Tables[0].Rows[i]["quantity"].ToString());
                int totalprice1 = price1 * quantity1;
                dr["totalprice"] = totalprice1;
                dt.Rows.Add(dr);
                i = i + 1;
            }

        }
        else
        {
            Session["buyitems"] = null;
        }
        Session["buyitems"] = dt;
    */

}

