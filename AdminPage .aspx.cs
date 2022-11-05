using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;



public partial class AdminPage_ : System.Web.UI.Page
{
    static String imagelink;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
    }
    protected void addproduct_Click(object sender, EventArgs e)
    {
        if (uploadimage() == true)
        {
            String query = "insert into products(pcategory,ptag,pname,p_description,price,quantity,p_imgurl) values('" + categorytb.Text + "','" + tagtb.Text + "','" + pnametb.Text + "','" + descript.Text + "'," + pricee.Text + "," + quanti.Text + ",'" + imagelink + "')";
            String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";
            MySqlConnection con = new MySqlConnection(mycon);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label4.Text = "Product Has Been Successfully Saved";
            getproductid();
            categorytb.Text = "";
            tagtb.Text = "";
            pnametb.Text = "";
            descript.Text = "";
            pricee.Text = "";
            quanti.Text = "";
        }
    }
    private Boolean uploadimage()
    {
        Boolean imagesaved = false;
        if (FileUpload1.HasFile == true)
        {

            String contenttype = FileUpload1.PostedFile.ContentType;

            if (contenttype == "image/jpeg")
            {

                FileUpload1.SaveAs(Server.MapPath("~/images/") + Label3.Text + ".jpg");
                imagelink = "images/" + Label3.Text + ".jpg";
                imagesaved = true;
            }
            else
            {
                Label4.Text = "Kindly Upload JPEG Format Image Only";
            }

        }

        else
        {
            Label4.Text = "You have not selected any file - Browse and Select File First";
        }

        return imagesaved;

    }
    public void getproductid()
    {
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";
        MySqlConnection scon = new MySqlConnection(mycon);
        String myquery = "select pid from products";
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = scon;
        MySqlDataAdapter da = new MySqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        scon.Close();
        if (ds.Tables[0].Rows.Count < 1)
        {
            Label3.Text = "1001";

        }
        else
        {
            String mycon1 = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";
            MySqlConnection scon1 = new MySqlConnection(mycon1);
            String myquery1 = "select max(pid) from products";
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.CommandText = myquery1;
            cmd1.Connection = scon1;
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            Label3.Text = ds1.Tables[0].Rows[0][0].ToString();
            int a;
            a = Convert.ToInt16(Label3.Text);
            a = a + 1;
            Label3.Text = a.ToString();
            scon1.Close();
        }

    }
    public void BindData()
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True");
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("select * from products", conn);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        cmd.Dispose();

        MySqlCommand cmd1 = new MySqlCommand("select * from reviews", conn);
        MySqlDataAdapter adp1 = new MySqlDataAdapter(cmd1);
        DataSet ds1 = new DataSet();
        adp1.Fill(ds1);
        GridView2.DataSource = ds1;
        GridView2.DataBind();
        cmd1.Dispose();
        conn.Close();


    }

    protected void delbtn_Click(object sender, EventArgs e)
    {
        String query = "delete from products where pid = " + delprod.Text;
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";
        MySqlConnection con = new MySqlConnection(mycon);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        delprod.Text = "";
    }

    protected void reviewButt_Click(object sender, EventArgs e)
    {
        String query = "delete from reviews where rid = " + reviewText.Text;
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";
        MySqlConnection con = new MySqlConnection(mycon);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        reviewText.Text = "";
    }

    protected void updatebtn_Click(object sender, EventArgs e)
    {
        String query = "update products set price = " + upprice.Text + ", quantity = " + upquant.Text + "   where pid = " + upid.Text;
        String mycon = "server = localhost; user id = root; persistsecurityinfo = True; database = giftshopdb; password=root; allowuservariables = True";
        MySqlConnection con = new MySqlConnection(mycon);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        delprod.Text = "";
    }
}