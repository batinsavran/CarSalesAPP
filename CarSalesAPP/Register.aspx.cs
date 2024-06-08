using System;
using System.Data.SqlClient;
using System.Web.UI;
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
            try
            {
                SqlConnectionClass.CheckConnection();

                using (SqlCommand sqlCommand = new SqlCommand("Insert into TableUser (UserMail, UserPassword) values (@pmail, @ppassword)", SqlConnectionClass.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@pmail", tbMail.Text);
                    sqlCommand.Parameters.AddWithValue("@ppassword", tbPassword.Text);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                if (SqlConnectionClass.connection.State == System.Data.ConnectionState.Open)
                {
                    SqlConnectionClass.connection.Close();
                }
            }
        }
    }
}
