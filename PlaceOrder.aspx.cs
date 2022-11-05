using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class PlaceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("productid");
           /* dt.Columns.Add("scmake");
            dt.Columns.Add("scmodel");*/
            dt.Columns.Add("productname");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");
            dt.Columns.Add("totalprice");
            dt.Columns.Add("scdescription");


            if (Request.QueryString["id"] != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();
                    String mycon = "server=localhost;user id=root;persistsecurityinfo=True;database=giftshopdb;password=root;allowuservariables=True";
                    MySqlConnection scon = new MySqlConnection(mycon);
                    String myquery = "select * from products where pid=" + Request.QueryString["id"];
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = 1;
                    dr["productid"] = ds.Tables[0].Rows[0]["pid"].ToString();

                   /* dr["scmake"] = ds.Tables[0].Rows[0]["p_cmake"];
                    dr["scmodel"] = ds.Tables[0].Rows[0]["p_cmodel"];*/

                    dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString(); /*Please check this line*/
                    dr["scdescription"] = ds.Tables[0].Rows[0]["p_description"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;
                    dr["totalprice"] = totalprice;

                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    Response.Redirect("AddToCart.aspx");

                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                    String mycon = "server=localhost;user id=root;persistsecurityinfo=True;database=giftshopdb;password=root;allowuservariables=True";
                    MySqlConnection scon = new MySqlConnection(mycon);
                    String myquery = "select * from products where pid=" + Request.QueryString["id"];
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dr["sno"] = sr + 1;
                    dr["productid"] = ds.Tables[0].Rows[0]["pid"].ToString();

                  /*  dr["scmake"] = ds.Tables[0].Rows[0]["p_cmake"];
                    dr["scmodel"] = ds.Tables[0].Rows[0]["p_cmodel"];*/

                    dr["productname"] = ds.Tables[0].Rows[0]["pname"].ToString();
                    dr["scdescription"] = ds.Tables[0].Rows[0]["p_description"].ToString();
                    dr["quantity"] = Request.QueryString["quantity"];
                    dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                    int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                    int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                    int totalprice = price * quantity;
                    dr["totalprice"] = totalprice;
                    dt.Rows.Add(dr);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Session["buyitems"] = dt;
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                    Response.Redirect("AddToCart.aspx");

                }
            }
            else
            {
                dt = (DataTable)Session["buyitems"];
                GridView1.DataSource = dt;
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    GridView1.FooterRow.Cells[5].Text = "Total Amount";
                    GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();

                }


            }
            // Label2.Text = GridView1.Rows.Count.ToString();

        }
        Label4.Text = DateTime.Now.ToShortDateString();
        findorderid();
        showaddress();
    }
    public int grandtotal()
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        int nrow = dt.Rows.Count;
        int i = 0;
        int gtotal = 0;
        while (i < nrow)
        {
            gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

            i = i + 1;
        }
        return gtotal;
    }
    public void findorderid()
    {
        String pass = "abcdefghijklmnopqrstuvwxyz123456789";
        Random r = new Random();
        char[] mypass = new char[5];
        for (int i = 0; i < 5; i++)
        {
            mypass[i] = pass[(int)(35 * r.NextDouble())];

        }
        String orderid;
        orderid = "Order" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(mypass);

        Label3.Text = orderid;


    }


    public void showaddress()
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=giftshopdb; password=root; allowuservariables=True");
        conn.Open();
        MySqlDataAdapter sda = new MySqlDataAdapter("select cust_name,cust_addr from customerdata where c_uname = '" + Session["username"] + "'", conn);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        CustomerDetails.DataSource = dt;
        CustomerDetails.DataBind();
        conn.Close();
    }
    //create table orderdetails(odid int NOT NULL AUTO_INCREMENT,orderid varchar(50),sno int,oproductid int,omake varchar(100),omodel varchar(100),oproductname varchar(200),oprice varchar(50),oquantity varchar(50),dateoforder date,o_uname varchar(50),PRIMARY KEY(odid));

    protected void finalorderbtn_Click(object sender, EventArgs e)
    {
        DataTable dt;
        dt = (DataTable)Session["buyitems"];



        for (int i = 0; i < dt.Rows.Count; i++)
        {
            String updatepass = "insert into orderdetails(orderid,sno,oproductid,oproductname,oprice,oquantity,dateoforder,o_uname) values('" + Label3.Text + "'," + dt.Rows[i]["sno"] + "," + dt.Rows[i]["productid"] + ",'" + dt.Rows[i]["productname"] +  "'," + dt.Rows[i]["price"] + "," + dt.Rows[i]["quantity"] + ",'" + Label4.Text + "','" + Session["username"] + "')";
            String mycon1 = "server=localhost;user id=root;persistsecurityinfo=True;database=giftshopdb; password=root; allowuservariables=True";
            MySqlConnection s = new MySqlConnection(mycon1);
            s.Open();
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.CommandText = updatepass;
            cmd1.Connection = s;
            cmd1.ExecuteNonQuery();
            s.Close();
            Response.Write("order placed successfully");
            Response.Redirect("Invoice.aspx?orderid=" + Label3.Text);

        }
    }
}