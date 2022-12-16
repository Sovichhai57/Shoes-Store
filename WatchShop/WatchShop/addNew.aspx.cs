using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class addNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            btnSubmit.Enabled = false;
            btnAddNew.Visible = false;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ImgUpload.HasFile)
        {
            String imgName = ImgUpload.FileName;
            ImgUpload.SaveAs(Server.MapPath("~\\Images") + "/" + ImgUpload.FileName);

            SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; " +
                "Database=DBWatches; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into tblWatches " +
                "Values (@wId, @BrandId, @CountryId, @bgId, @wModel, @wPrice, " +
                "@ImgUrl, @wDes, @DateIn)", cnn);

            cmd.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@wId"].Value = wId.Text;
            cmd.Parameters.Add("@BrandId", System.Data.SqlDbType.Int);
            cmd.Parameters["@BrandId"].Value = wBr.SelectedValue;
            cmd.Parameters.Add("@CountryId", System.Data.SqlDbType.Int);
            cmd.Parameters["@CountryId"].Value = wCountry.SelectedValue;
            cmd.Parameters.Add("@bgId", System.Data.SqlDbType.Int);
            cmd.Parameters["@bgId"].Value = wBGl.SelectedValue;
            cmd.Parameters.Add("@wModel", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@wModel"].Value = wModel.Text;
            cmd.Parameters.Add("@wPrice", System.Data.SqlDbType.Float);
            cmd.Parameters["@wPrice"].Value = wPr.Text;
            cmd.Parameters.Add("@ImgUrl", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@ImgUrl"].Value = "Images/" + imgName;
            cmd.Parameters.Add("@wDes", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@wDes"].Value = wDes.Text;
            cmd.Parameters.Add("@DateIn", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@DateIn"].Value = DateTime.Now;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            wId.Enabled = false;
            wBGl.Enabled = false;
            wPr.Enabled = false;
            wModel.Enabled = false;
            wDes.Enabled = false;
            wCountry.Enabled = false;
            wBr.Enabled = false;
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
            chkAgree.Checked = false;
            btnAddNew.Visible = true;

            lblMes.Text = "Adding The New Watch Successfully !!!";
            lblImgMes.Text = "";
        }
        else
            lblImgMes.Text = "Please choose a Photo of the Watch";
    }





    protected void chkAgree_CheckedChanged1(object sender, EventArgs e)
    {
        if (chkAgree.Checked == true)
            btnSubmit.Enabled = true;
        else
            btnSubmit.Enabled = false;
    }



    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        wId.Text = "";
        wPr.Text = "";
        wModel.Text = "";
        wDes.Text = "";
        lblMes.Text = "";
        lblImgMes.Text = "";

        btnAddNew.Visible = false;

        wId.Enabled = true;
       wBGl.Enabled = true;
        wPr.Enabled = true;
        wModel.Enabled = true;
        wDes.Enabled = true;
        wCountry.Enabled = true;
        wBr.Enabled = true;
        btnSubmit.Visible = true;
        btnSubmit.Enabled = false;
        chkAgree.Checked = false;
    }
}