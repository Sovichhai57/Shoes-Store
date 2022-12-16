using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class editInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            wBGT.Enabled = false;
            wPr.Enabled = false;
            wModel.Enabled = false;
            wDes.Enabled = false;
            wCountry.Enabled = false;
            wBr.Enabled = false;
            btnUpdate.Enabled = false;
            chkAgree.Enabled = false;
        }
        if (chkAgree.Checked == false)
            btnUpdate.Enabled = false;
        else
            btnUpdate.Enabled = true;
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; Database=DBWatches; Integrated Security=True");
        SqlCommand cmd = new SqlCommand("Select wid, Brand, wModel, ProCountry, Types, wPrice, wDes From (((tblWatches tw Inner Join tblWatchBrand twb On tw.Brandid=twb.Brandid) Inner Join tblCountry tc On tc.CountryId=tw.CountryId) Inner Join tblType tt On tt.bgId=tw.bgId) where wid=@wId", cnn);

        cmd.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
        cmd.Parameters["@wId"].Value = wId.Text;

        SqlDataReader rd;
        cnn.Open();
        rd = cmd.ExecuteReader();
        if (rd.Read() == true)
        {
            wBGT.Enabled = true;
            wPr.Enabled = true;
            wModel.Enabled = true;
            wDes.Enabled = true;
            wCountry.Enabled = true;
            wBr.Enabled = true;
            wId.Text = rd[0].ToString();
            wModel.Text = rd[2].ToString();
            wPr.Text = rd[5].ToString();
            wDes.Text = rd[6].ToString();
            wId.Enabled = false;
            chkAgree.Enabled = true;
            if (chkAgree.Checked == false)
                btnUpdate.  Enabled = false;
            else
                btnUpdate.Enabled = true;
            lblMes.Text = "";
        }
        else
            lblMes.Text = "There is no the file found!!!";

        rd.Close();
        cnn.Close();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; Database=DBWatches; Integrated Security=True");
        SqlCommand cmd = new SqlCommand("Update tblWatches Set BrandId=@BrandId, CountryId=@CountryId, bgId=@bgId, wModel=@wModel, wPrice=@wPrice, wDes=@wDes where wId=@wId ", cnn);

        cmd.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
        cmd.Parameters["@wId"].Value = wId.Text;
        cmd.Parameters.Add("@BrandId", System.Data.SqlDbType.Int);
        cmd.Parameters["@BrandId"].Value = wBr.SelectedValue;
        cmd.Parameters.Add("@CountryId", System.Data.SqlDbType.Int);
        cmd.Parameters["@CountryId"].Value = wCountry.SelectedValue;
        cmd.Parameters.Add("@bgId", System.Data.SqlDbType.Int);
        cmd.Parameters["@bgId"].Value = wBGT.SelectedValue;
        cmd.Parameters.Add("@wModel", System.Data.SqlDbType.NVarChar);
        cmd.Parameters["@wModel"].Value = wModel.Text;
        cmd.Parameters.Add("@wPrice", System.Data.SqlDbType.Float);
        cmd.Parameters["@wPrice"].Value = wPr.Text;
        cmd.Parameters.Add("@wDes", System.Data.SqlDbType.NVarChar);
        cmd.Parameters["@wDes"].Value = wDes.Text;
        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();

        wId.Enabled = true;
        wBGT.Enabled = false;
        wPr.Enabled = false;
        wModel.Enabled = false;
        wDes.Enabled = false;
        wCountry.Enabled = false;
        wBr.Enabled = false;
        btnUpdate.Enabled = false;
        chkAgree.Checked = false;
        chkAgree.Enabled = false;

        lblMes.Text = "Updated Successfully !!!";
    }
}

