using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void BtOrder_Click(object sender, EventArgs e)
    {
        Session["TableNumber"] = DdlTable.SelectedValue;
        Session["Staff"] = DdlStaff.SelectedValue;
        Session["People"] = DdlPeople.SelectedValue;
        Response.Redirect("Order.aspx");
    }
    protected void BtDetail_Click(object sender, EventArgs e)
    {
        Session["TableNumber"] = DdlTable.SelectedValue;
        Session["Staff"] = DdlStaff.SelectedValue;
        Session["People"] = DdlPeople.SelectedValue;
        Response.Redirect("Detail.aspx");
    }
    protected void BtCheck_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckPlease.aspx");
    }
}