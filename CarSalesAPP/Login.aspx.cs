using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CarSalesAPP.Classes;
using System.Data;

namespace CarSalesAPP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from TableUser where UserMail=@pmail and UserPassword=@ppassword", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();

            cmd.Parameters.AddWithValue("@pmail", tbMail.Text);
            cmd.Parameters.AddWithValue("@ppassword", tbPassword.Text);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("ListCars.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş");
            }

        }
    }
}