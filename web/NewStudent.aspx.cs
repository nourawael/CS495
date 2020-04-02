using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class NewStudent : System.Web.UI.Page
{
    protected void btnSubmit_Click(object sender, EventArgs e) {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|student.mdf;Integrated Security=True";
        string strInsert = "INSERT INTO [Member] " +
            " VALUES('" + fNametxt.Text +
            "', '" + lNametxt.Text + "', '"
            + radioBtn.SelectedValue + "', '"
            + calender.SelectedDate + "', '"
            + emailtxt.Text +"', '" 
            + phonetxt.Text + "', '" + addresstxt.Text +
            "', '" + passtxt.Text + "', '" + nationality.SelectedValue
            + "', '" + faculty.SelectedValue + "', '" + bus.Text +
            "')";

        SqlCommand cmdInsert = new SqlCommand(strInsert, conn);
        conn.Open();

        cmdInsert.ExecuteNonQuery();

        conn.Close();
            
    
    }

}