using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;


public partial class Register : System.Web.UI.Page
{

    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=giftshopdb;password=root;allowuservariables=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void registerbtn_Click(object sender, EventArgs e)
    {
        string query = "insert into customerdata(cust_name,cust_contact,cust_addr,cust_email,c_uname,c_passwd)values('" + fullname.Text + "','" + contact.Text + "','" + addr.Text + "','" + email.Text + "','" + uname.Text + "','" + passwd.Text + "')";
        MySqlCommand cmd = new MySqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        Response.Write("Registration is successful");
        con.Close();
    }
}