using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmptyG.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SwapG.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("FillG.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Session.Remove("username");
    }
}