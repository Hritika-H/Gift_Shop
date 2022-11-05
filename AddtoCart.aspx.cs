using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

public partial class AddtoCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* String a = Request.QueryString["id"];
                String b = Request.QueryString["quantity"];
                Response.Write(a+" "+b);*/
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("productid");
            /* dt.Columns.Add("pcategory");
             dt.Columns.Add("ptag");*/
            dt.Columns.Add("productname");
            dt.Columns.Add("scdescription");
            dt.Columns.Add("quantity");
            dt.Columns.Add("price");
            dt.Columns.Add("totalprice");
            dt.Columns.Add("productimage");


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
                    /*mycode
                    dr["pcategoy"] = ds.Tables[0].Rows[0]["pcategory"];
                    dr["ptag"] = ds.Tables[0].Rows[0]["ptag"];*/

                    dr["productname"] = ds.Tables[0].Rows[0]["pname"].ToString();
                    dr["scdescription"] = ds.Tables[0].Rows[0]["p_description"].ToString();
                    dr["productimage"] = ds.Tables[0].Rows[0]["p_imgurl"].ToString();
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
                    /*mycode
                    dr["pcategory"] = ds.Tables[0].Rows[0]["pcategory"];
                    dr["ptag"] = ds.Tables[0].Rows[0]["ptag"];*/

                    dr["productname"] = ds.Tables[0].Rows[0]["pname"].ToString();

                    dr["scdescription"] = ds.Tables[0].Rows[0]["p_description"].ToString();

                    dr["productimage"] = ds.Tables[0].Rows[0]["p_imgurl"].ToString();
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
            Label2.Text = GridView1.Rows.Count.ToString();

        }

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

    protected void Checkoutbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlaceOrder.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Products.aspx");
    }
}
