using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Findmygift : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String a = DropDownList1.SelectedItem.Value;
        String b = DropDownList2.SelectedItem.Value;
        String c = DropDownList3.SelectedItem.Value;
        Response.Redirect("SearchResults.aspx?test1=" + a + "&test2=" + b + "&test3=" + c);

    }
}