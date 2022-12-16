using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class allWatches : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; " +
                "Database=DBWatches; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select wId, Brand, wModel, ImgUrl, " +
                "wPrice From tblWatches tw Inner Join tblWatchBrand twb " +
                "ON tw.BrandId=twb.BrandId", cnn);
            SqlDataReader rd;
            cnn.Open();
            rd = cmd.ExecuteReader();
            ListView1.DataSource = rd;
            ListView1.DataBind();
            
            rd.Close();
            cnn.Close();
        }
    }
    protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        TextBox tId = (TextBox)e.Item.FindControl("txtwId");
        

        if (e.CommandName == "detail")
        {
            Response.Redirect("proDetail.aspx?pid=" + tId.Text);
        }
        else
        {
            Response.Redirect("order.aspx?pid=" + tId.Text);
        }
    }

    protected void wBrS_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; " +
            "Database=DBWatches; Integrated Security=True");
        SqlCommand cmd = new SqlCommand("Select wId, Brand, wModel, ImgUrl, " +
            "wPrice From tblWatches tw Inner Join tblWatchBrand twb ON " +
            "tw.BrandId=twb.BrandId Where tw.BrandId=@wBrS " +
            "and tw.countryId=@wCrS", cnn);
        cmd.Parameters.Add("@wBrS", System.Data.SqlDbType.Int);
        cmd.Parameters["@wBrS"].Value = wBrS.SelectedValue;
        cmd.Parameters.Add("@wCrS", System.Data.SqlDbType.Int);
        cmd.Parameters["@wCrS"].Value = wSupS.SelectedValue;

        SqlDataReader rd;
        cnn.Open();
        rd = cmd.ExecuteReader();
        ListView1.DataSource = rd;
        ListView1.DataBind();
        
        rd.Close();
        cnn.Close();
        
    }

    protected void wSupS_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; Database=DBWatches; Integrated Security=True");
        SqlCommand cmd = new SqlCommand("Select wId, Brand, wModel, ImgUrl, wPrice From tblWatches tw Inner Join tblWatchBrand twb ON tw.BrandId=twb.BrandId Where tw.BrandId=@wBrS and tw.countryId=@wCrS", cnn);
        cmd.Parameters.Add("@wBrS", System.Data.SqlDbType.Int);
        cmd.Parameters["@wBrS"].Value = wBrS.SelectedValue;
        cmd.Parameters.Add("@wCrS", System.Data.SqlDbType.Int);
        cmd.Parameters["@wCrS"].Value = wSupS.SelectedValue;

        SqlDataReader rd;
        cnn.Open();
        rd = cmd.ExecuteReader();
        ListView1.DataSource = rd;
        ListView1.DataBind();
        rd.Close();
        cnn.Close();
    }
}
