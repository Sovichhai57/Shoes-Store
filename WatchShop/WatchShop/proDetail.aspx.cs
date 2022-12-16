using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class proDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String sId = Request.QueryString.Get("pid");
        SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; " +
            "Database=DBWatches; Integrated Security=True");
        SqlCommand cmd = new SqlCommand("Select wid, Brand, wModel, ImgUrl, " +
            "wPrice, wDes, ProCountry, Types From ((tblWatches tw Inner Join " +
            "tblWatchBrand twb ON tw.Brandid=twb.Brandid) Inner Join " +
            "tblType tt ON tw.bgid=tt.bgid) Inner Join tblCountry tc " +
            "ON tw.countryid=tc.Countryid Where tw.wid=@wIds", cnn);
        cmd.Parameters.Add("@wIds", System.Data.SqlDbType.NVarChar);
        cmd.Parameters["@wIds"].Value = sId;
        SqlDataReader rd;
        cnn.Open();
        rd = cmd.ExecuteReader();
        ListView1.DataSource = rd;
        ListView1.DataBind();
        rd.Close();
        cnn.Close();

        SqlCommand cmd1 = new SqlCommand("Select * From tblImages where wId=@wId", cnn);
        cmd1.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
        cmd1.Parameters["@wId"].Value = sId;
        SqlDataReader rd1;
        cnn.Open();
        rd1 = cmd1.ExecuteReader();
        LView2.DataSource = rd1;
        LView2.DataBind();
        rd1.Close();
        cnn.Close();
    }
    }
