using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Detail : System.Web.UI.Page
{
    string sConnString = System.Configuration.ConfigurationManager.ConnectionStrings["RestaurantConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"select distinct(TableNumbers),SUM(Prices) as Prices,People,Uname from Order_Temp 
                                                     where Visibles=0 group by TableNumbers,People,Uname", sConnString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                RtList.DataSource = dt;
                RtList.DataBind();
            }
            else
            {
                Label1.Text = "目前無可加點的桌子";
                Label1.Visible = true;
            }
        }
    }
    protected void RtList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Add")
        {
            Session["TableNumber"] = e.CommandArgument.ToString();
            Response.Redirect("Order.aspx");
        }
    }
    protected void RtList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            LinkButton HlbAdd = (LinkButton)e.Item.FindControl("HlbAdd");
            HlbAdd.Text = DataBinder.Eval(e.Item.DataItem, "TableNumbers").ToString();
            HlbAdd.CommandArgument = DataBinder.Eval(e.Item.DataItem, "TableNumbers").ToString();           
        }
    }
    protected void BtGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}