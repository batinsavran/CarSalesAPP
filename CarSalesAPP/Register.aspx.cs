using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CarSalesAPP.Classes;

namespace CarSalesAPP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into TableUser (UserMail, UserPassword) values (@pmail,@ppassword)", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();

            sqlCommand.Parameters.AddWithValue("@pmail", tbMail.Text);
            sqlCommand.Parameters.AddWithValue("@ppassword", tbPassword.Text);
            sqlCommand.ExecuteNonQuery();
        }
    }
}