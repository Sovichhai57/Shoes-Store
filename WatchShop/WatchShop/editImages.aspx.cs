using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditImages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; Database=DBWatches; " +
            "Integrated Security=True");

        SqlCommand cmd = new SqlCommand("Select wid, imgUrl From tblWatches where wid=@wId", cnn);
        cmd.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
        cmd.Parameters["@wId"].Value = wId.Text;

        SqlCommand cmd1 = new SqlCommand("Select * From tblimages where wid=@wId", cnn);
        
        cmd1.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
        cmd1.Parameters["@wId"].Value = wId.Text;

        SqlDataReader rd, rd1;
        cnn.Open();
        rd = cmd.ExecuteReader();
        lview1.DataSource = rd;
        lview1.DataBind();
        rd.Close();
        cnn.Close();

        cnn.Open();
        rd1 = cmd1.ExecuteReader();
        LView2.DataSource = rd1;
        LView2.DataBind();
        rd1.Close();
        cnn.Close();

        //rd = cmd.ExecuteReader();
        //if (rd.Read() == false)
        //    lblMes.Text = "No File Found !!!";
        //else
        //    lblMes.Text = "";

        //cnn.Close();
    }

    protected void cmdUMI_Click(object sender, EventArgs e)
    {
        if (fmImg.HasFile)
        {
            String imgName = fmImg.FileName;
            fmImg.SaveAs(Server.MapPath("~\\Images") + "/" + fmImg.FileName);

            SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; Database=DBWatches; " +
                "Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Update tblWatches Set imgUrl=@ImgUrl " +
                "Where wid=@wId", cnn);

            cmd.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@wId"].Value = wId.Text;
            cmd.Parameters.Add("@ImgUrl", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@ImgUrl"].Value = "Images/" + imgName;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            SqlCommand cmd1 = new SqlCommand("Select wid, imgUrl From tblWatches " +
                "where wid=@wId", cnn);

            cmd1.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
            cmd1.Parameters["@wId"].Value = wId.Text;

            SqlDataReader rd1;
            cnn.Open();
            rd1 = cmd1.ExecuteReader();
            lview1.DataSource = rd1;
            lview1.DataBind();
            rd1.Close();
            cnn.Close();
        }
    }
    protected void ImgUpload_Click(object sender, EventArgs e)
    {
        if (fmImg2.HasFile)
        {
            String imgName2 = fmImg2.FileName;
            fmImg2.SaveAs(Server.MapPath("~\\Images") + "/" + fmImg2.FileName);

            SqlConnection cnn = new SqlConnection("Server=LAPTOP-U6O1TPT3; Database=DBWatches; " +
                "Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert Into tblimages Values(@wId, @ImgUrl)", cnn);
           
            cmd.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@wId"].Value = wId.Text;
            cmd.Parameters.Add("@ImgUrl", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@ImgUrl"].Value = "Images/" + imgName2;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            SqlCommand cmd1 = new SqlCommand("Select * From tblimages where wid=@wId", cnn);
            cmd1.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
            cmd1.Parameters["@wId"].Value = wId.Text;
            SqlDataReader rd1;
            cnn.Open();
            rd1 = cmd1.ExecuteReader();
            LView2.DataSource = rd1;
            LView2.DataBind();
            rd1.Close();
            cnn.Close();
        }
    }

    protected void LView2_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        TextBox tIdD = (TextBox)e.Item.FindControl("txtImgIds");
        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-U6O1TPT3;" +
            "Initial Catalog=DBWatches;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("Delete From tblimages Where imgid=@ImgIdD", cnn);
        cmd.Parameters.Add("@ImgIdD", System.Data.SqlDbType.Int);
        cmd.Parameters["@ImgIdD"].Value = tIdD.Text;
        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();
        //Showing after Deleting
        SqlCommand cmd1 = new SqlCommand("Select * From tblimages where wid=@wId", cnn);
        cmd1.Parameters.Add("@wId", System.Data.SqlDbType.NVarChar);
        cmd1.Parameters["@wId"].Value = wId.Text;
        SqlDataReader rd1;
        cnn.Open();
        rd1 = cmd1.ExecuteReader();
        LView2.DataSource = rd1;
        LView2.DataBind();
        rd1.Close();
        cnn.Close();
    }
}
