using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Order : System.Web.UI.Page
{
    string sConnString = System.Configuration.ConfigurationManager.ConnectionStrings["RestaurantConnectionString"].ConnectionString;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ForBut1Click();
            GetOrderTemp(Session["TableNumber"].ToString().Trim());
           // RadioButtonList1.attr("onclick", "load('" + n + "')"); 
            LbStaff.Text = "人員:" + Session["Staff"].ToString().Trim();
            LbPeople.Text = "人數:"+ Session["People"].ToString().Trim();
        }
    }
    private void SetRadioList(DataTable dt)
    {
        LbPrice.Text = "均一價" + dt.Rows[0][1].ToString() + "元";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            RadioButtonList1.Items[i].Attributes.Add("onclick", "ShowFood('" + RadioButtonList1.Items[i].Text + "')");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ForBut1Click();
      //  SetRadioList(dt);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("texts");
        dt.Columns.Add("values");
        dt.Rows.Add("肉絲炒麵", "肉絲炒麵.60");
        dt.Rows.Add("蚵仔炒麵", "蚵仔炒麵.60");
        dt.Rows.Add("蝦仁炒飯", "蝦仁炒飯.60");
        dt.Rows.Add("櫻花蝦炒飯", "櫻花蝦炒飯.60");     
        RadioButtonList1.DataSource = dt;
        RadioButtonList1.DataValueField = "values";
        RadioButtonList1.DataTextField = "texts";
        RadioButtonList1.DataBind();
        LbPrice.Text = "均一價60元";
        Image1.ImageUrl = "";
      //  SetRadioList(dt);

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("texts");
        dt.Columns.Add("values");
        dt.Rows.Add("丁香魚", "丁香魚.80");
        dt.Rows.Add("小卷酥", "小卷酥.80");
        dt.Rows.Add("月亮蝦餅", "月亮蝦餅.80");
        dt.Rows.Add("炸銀魚", "炸銀魚.80");
        dt.Rows.Add("蚵仔酥", "蚵仔酥.80");
        dt.Rows.Add("鳳梨蝦球", "鳳梨蝦球.80");
        dt.Rows.Add("鹽酥蝦", "鹽酥蝦.80");
      
        RadioButtonList1.DataSource = dt;
        RadioButtonList1.DataValueField = "values";
        RadioButtonList1.DataTextField = "texts";
        RadioButtonList1.DataBind();
        LbPrice.Text = "均一價80元";
        Image1.ImageUrl = "";
      //  SetRadioList(dt);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("texts");
        dt.Columns.Add("values");
        dt.Rows.Add("砂鍋魚頭", "砂鍋魚頭.120");
        dt.Rows.Add("海鮮鍋", "海鮮鍋.120");
        dt.Rows.Add("蚵仔湯", "蚵仔湯.120");
        dt.Rows.Add("魚肚湯", "魚肚湯.120");
        dt.Rows.Add("蛤仔湯", "蛤仔湯.120");
        dt.Rows.Add("豬肝湯", "豬肝湯.120");
        RadioButtonList1.DataSource = dt;
        RadioButtonList1.DataValueField = "values";
        RadioButtonList1.DataTextField = "texts";
        RadioButtonList1.DataBind();
        LbPrice.Text = "均一價120元";
        Image1.ImageUrl = "";
       // SetRadioList(dt);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("texts");
        dt.Columns.Add("values");
        dt.Rows.Add("三杯田雞", "三杯田雞.100");
        dt.Rows.Add("三杯豆腐", "三杯豆腐.100");
        dt.Rows.Add("三杯軟絲", "三杯軟絲.100");
        dt.Rows.Add("山蘇", "山蘇.100");
        dt.Rows.Add("川七", "川七.100");
        dt.Rows.Add("水蓮", "水蓮.100");
        dt.Rows.Add("沙茶羊肉", "沙茶羊肉.100");
        dt.Rows.Add("炒蛤仔", "炒蛤仔.100");
        dt.Rows.Add("炒鵝腸", "炒鵝腸.100");
        dt.Rows.Add("空心菜", "空心菜.100");
        dt.Rows.Add("金針", "金針.100");
        dt.Rows.Add("客家小炒", "客家小炒.100");
        dt.Rows.Add("客家美食-薑絲炒大腸", "客家美食-薑絲炒大腸.100");
        dt.Rows.Add("海瓜子", "海瓜子.100");
        dt.Rows.Add("清炒高麗菜", "清炒高麗菜.100");
        dt.Rows.Add("麻油腰子", "麻油腰子.100");
        dt.Rows.Add("麻油雙腰", "麻油雙腰.100");
        dt.Rows.Add("絲瓜蛤仔", "絲瓜蛤仔.100");
        dt.Rows.Add("菠菜", "菠菜.100");
        dt.Rows.Add("雲筍", "雲筍.100");
        dt.Rows.Add("螺肉", "螺肉.100");
        dt.Rows.Add("蘆筍", "蘆筍.100");
        RadioButtonList1.DataSource = dt;
        RadioButtonList1.DataValueField = "values";
        RadioButtonList1.DataTextField = "texts";
        RadioButtonList1.DataBind();
        LbPrice.Text = "均一價100元";
       // SetRadioList(dt);
        Image1.ImageUrl = "";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("texts");
        dt.Columns.Add("values");
        dt.Rows.Add("松坂肉", "松坂肉.90");
        dt.Rows.Add("鹽烤風螺", "鹽烤風螺.90");      
        RadioButtonList1.DataSource = dt;
        RadioButtonList1.DataValueField = "values";
        RadioButtonList1.DataTextField = "texts";
        RadioButtonList1.DataBind();
        LbPrice.Text = "均一價90元";
        Image1.ImageUrl = "";
       // SetRadioList(dt);
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            string[] StrArr = RadioButtonList1.SelectedItem.Value.Split('.');
            //Response.Write(RadioButtonList1.SelectedItem.Text);
            //Response.Write("<script>alert('" + StrArr[0] + "點了" + DdlPeople.SelectedItem.Value + "份')</script>");
            int Iprice =  int.Parse(StrArr[1].ToString()) * int.Parse(DdlPeople.SelectedItem.Value);
            
            AddToTemp(StrArr[0].ToString(), DdlPeople.SelectedItem.Value, Iprice);
            GetOrderTemp(Session["TableNumber"].ToString().Trim());
        }
        catch (Exception)
        {

            Response.Write("<script>alert('點餐失敗,請選擇餐點')</script>");
        }
        
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Response.Write(RadioButtonList1.SelectedItem.Value);
        string[] StrArr = RadioButtonList1.SelectedItem.Value.Split('.');
        Image1.ImageUrl = "images/" + StrArr[0] + ".jpg";
    }
    protected void Button8_Click(object sender, EventArgs e)
    {       
        Response.Redirect("default.aspx");
    }
    private void AddToTemp(string StrFoods, string StrCounts,int IPrice)
    {
        using (SqlConnection conn = new SqlConnection(sConnString))
        {
            using (SqlCommand cmd = new SqlCommand(@"insert into Order_Temp(Foods,Counts,Uname,TableNumbers,People,Prices)
                                                     values(@Foods,@Counts,@Uname,@TableNumbers,@People,@Prices)", conn))
            {
                conn.Open();
                cmd.Parameters.Add("Foods", SqlDbType.NVarChar).Value = StrFoods.Trim();
                cmd.Parameters.Add("Counts", SqlDbType.NVarChar).Value = StrCounts.Trim();
                cmd.Parameters.Add("Prices", SqlDbType.Int).Value = IPrice;
                cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = Session["Staff"].ToString().Trim();
                cmd.Parameters.Add("TableNumbers", SqlDbType.NVarChar).Value = Session["TableNumber"].ToString().Trim();
                cmd.Parameters.Add("People", SqlDbType.NVarChar).Value = Session["People"].ToString().Trim();
                cmd.ExecuteNonQuery();
            }
        }
    }
    protected void RtList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {   
            LinkButton HlbDel = (LinkButton)e.Item.FindControl("HlbDel");
            HlbDel.CommandArgument = DataBinder.Eval(e.Item.DataItem, "SID").ToString();
        }
    }
    protected void RtList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        
        if (e.CommandName == "Del")
        {
            string aryValue = e.CommandArgument.ToString();

            SqlConnection conn = new SqlConnection(sConnString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"delete Order_Temp where Sid=@Sid", conn);
            cmd.Parameters.Add("@Sid", SqlDbType.Char, 10).Value = aryValue;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
            GetOrderTemp(Session["TableNumber"].ToString().Trim());
        }
    }
    private void GetOrderTemp(string StrTableNumbers)
    {

        using (SqlDataAdapter da = new SqlDataAdapter("select * from Order_Temp where TableNumbers=@TableNumbers and Visibles=0", sConnString))
        {
            da.SelectCommand.Parameters.Add("TableNumbers", SqlDbType.NVarChar).Value = StrTableNumbers;
            using (DataTable dt = new DataTable())
            {
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    RtList.Visible = true;
                    RtList.DataSource = dt;
                    RtList.DataBind();
                }
                else
                {
                    RtList.Visible = false;
                }
               
            }
        }
       
    }
    private void ForBut1Click()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("texts");
        dt.Columns.Add("values");
        dt.Rows.Add("生魚片", "生魚片.70");
        dt.Rows.Add("冷筍", "冷筍.70");
        dt.Rows.Add("和風洋蔥", "和風洋蔥.70");
        dt.Rows.Add("青蚵", "青蚵.70");
        dt.Rows.Add("魚蛋沙拉", "魚蛋沙拉.70");
        dt.Rows.Add("鵝肉", "鵝肉.70");
        RadioButtonList1.DataSource = dt;
        RadioButtonList1.DataValueField = "values";
        RadioButtonList1.DataTextField = "texts";
        RadioButtonList1.DataBind();
        LbPrice.Text = "均一價70元";
        Image1.ImageUrl = "";
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(sConnString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(@"delete Order_Temp where TableNumbers=@TableNumbers", conn);
        cmd.Parameters.Add("@TableNumbers", SqlDbType.Char, 10).Value = Session["TableNumber"].ToString().Trim();
        cmd.ExecuteNonQuery();
        conn.Close();
        cmd.Dispose();
        conn.Dispose();
        Response.Redirect("default.aspx");
    }
}