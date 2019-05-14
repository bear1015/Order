using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class CheckPlease : System.Web.UI.Page
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
            da.SelectCommand.CommandText = @"select SUM(Turnovers) as Prices from TodayMoney where  
                                             CONVERT(varchar(100), Cdate, 111)= CONVERT(varchar(100), GETDATE(), 111)";
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            if (dt2.Rows.Count>0)
            {
                LbMoney.Text = "<br /><br />今日營業額:" + dt2.Rows[0][0].ToString()+"元";
                DataTable dt3 = new DataTable();
                da.SelectCommand.CommandText = @"select  distinct(Foods),SUM(Counts) as Counts 
                                               from Order_Temp where  CONVERT(varchar(100), Cdate, 111)= CONVERT(varchar(100), GETDATE(), 111)
                                               and Visibles=1  group by Foods";

                da.Fill(dt3);
                if (dt3.Rows.Count>0)
	            {
	            	Rtlist3.DataSource=dt3;
                    Rtlist3.DataBind();
	            }
            }
            else
            {
                LbMoney.Text = "<br /><br />今日營業額:0元";
            }
        }
    }
    protected void RtList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Close")
        {
            string[] aryValue = e.CommandArgument.ToString().Split(',');
            SqlConnection conn = new SqlConnection(sConnString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(@" update Order_Temp set Visibles=1 where TableNumbers=@TableNumbers;
                                              insert into TodayMoney (Turnovers)values(@Turnovers)", conn);
            cmd.Parameters.Add("@TableNumbers", SqlDbType.Char, 10).Value = aryValue[0];
            cmd.Parameters.Add("@Turnovers", SqlDbType.Char, 10).Value = aryValue[1];
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
            Response.Redirect("CheckPlease.aspx");
        }
        if (e.CommandName == "Detail")
        {
            DataTable dt = new DataTable();
            string[] aryValue = e.CommandArgument.ToString().Split(',');
            SqlDataAdapter da = new SqlDataAdapter("select * from Order_Temp where TableNumbers=@TableNumbers and Visibles=0", sConnString);
            da.SelectCommand.Parameters.Add("TableNumbers", SqlDbType.VarChar).Value = e.CommandArgument.ToString();
            da.Fill(dt);
            Rtlist2.DataSource = dt;
            Rtlist2.DataBind();
        }

    }
    protected void RtList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            LinkButton HlbClose = (LinkButton)e.Item.FindControl("HlbClose");
            HlbClose.CommandArgument = DataBinder.Eval(e.Item.DataItem, "Prices").ToString();

            HlbClose.CommandArgument = string.Format("{0},{1}",
            DataBinder.Eval(e.Item.DataItem, "TableNumbers").ToString(),
            DataBinder.Eval(e.Item.DataItem, "Prices").ToString());

            LinkButton HlbDetail = (LinkButton)e.Item.FindControl("HlbDetail");
            HlbDetail.CommandArgument = DataBinder.Eval(e.Item.DataItem, "TableNumbers").ToString();
        }
    }
    protected void BtGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}