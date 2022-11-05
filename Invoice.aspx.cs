using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

public partial class Invoice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = Request.QueryString["orderid"];
        Panel1.Visible = true;
        Label4.Text = Label3.Text;
        findorderdate(Request.QueryString["orderid"]);
        findaddress(Label5.Text);
        showgrid(Request.QueryString["orderid"]);
    }
    protected void DownloadInvoice_Click(object sender, EventArgs e)
    {
        exportpdf();

    }

    private void exportpdf()
    {
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=OrderInvoice.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        StringWriter sw = new StringWriter();
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        Panel1.RenderControl(hw);
        StringReader sr = new StringReader(sw.ToString());
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        pdfDoc.Open();
        htmlparser.Parse(sr);
        pdfDoc.Close();
        Response.Write(pdfDoc);
        Response.End();
    }
    private void findorderdate(String Orderid)
    {
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password = root; allowuservariables = True";
        String myquery = "Select * from orderdetails where orderid='" + Orderid + "'";
        MySqlConnection con = new MySqlConnection(mycon);
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = con;
        MySqlDataAdapter da = new MySqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {

            Label5.Text = ds.Tables[0].Rows[0]["dateoforder"].ToString();

        }

        con.Close();
    }
    private void findaddress(String Orderid)
    {
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";

        String myquery = "Select * from customerdata where c_uname='" + Session["username"] + "'";
        MySqlConnection con = new MySqlConnection(mycon);
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = con;
        MySqlDataAdapter da = new MySqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {

            Label6.Text = ds.Tables[0].Rows[0]["cust_addr"].ToString();
            Label7.Text = "1,Sunshine bldg, THK Marg, Mahim, Mumbai - 4000 16";

        }

        con.Close();
    }
    private void showgrid(String orderid)
    {
        DataTable dt = new DataTable();
        DataRow dr;

        dt.Columns.Add("sno");
        dt.Columns.Add("productid");
      /*  dt.Columns.Add("make");
        dt.Columns.Add("model");*/
        dt.Columns.Add("productname");

        dt.Columns.Add("quantity");
        dt.Columns.Add("price");
        dt.Columns.Add("totalprice");
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";

        MySqlConnection scon = new MySqlConnection(mycon);
        String myquery = "select * from orderdetails where orderid = '" + orderid + "'";
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = scon;
        MySqlDataAdapter da = new MySqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        int totalrows = ds.Tables[0].Rows.Count;
        int i = 0;
        int grandtotal = 0;
        while (i < totalrows)
        {
            dr = dt.NewRow();
            dr["sno"] = ds.Tables[0].Rows[i]["sno"].ToString();
            dr["productid"] = ds.Tables[0].Rows[i]["oproductid"].ToString();

         /*   dr["make"] = ds.Tables[0].Rows[0]["omake"];
            dr["model"] = ds.Tables[0].Rows[0]["omodel"];  */

            dr["productname"] = ds.Tables[0].Rows[i]["oproductname"].ToString();
            dr["quantity"] = ds.Tables[0].Rows[i]["oquantity"].ToString();
            dr["price"] = ds.Tables[0].Rows[i]["oprice"].ToString();
            int price = Convert.ToInt16(ds.Tables[0].Rows[i]["oprice"].ToString());
            int quantity = Convert.ToInt16(ds.Tables[0].Rows[i]["oquantity"].ToString());
            int totalprice = price * quantity;
            dr["totalprice"] = totalprice;
            grandtotal = grandtotal + totalprice;
            dt.Rows.Add(dr);
            i = i + 1;
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();

        Label8.Text = grandtotal.ToString();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }

}