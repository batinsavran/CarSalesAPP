using CarSalesAPP.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarSalesAPP
{
    public partial class AUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUserData();
            }
        }

        private void LoadUserData()
        {
            try
            {
                SqlConnectionClass.CheckConnection();

                using (SqlCommand cmd = new SqlCommand("SELECT UserID, UserMail, UserPassword FROM TableUser", SqlConnectionClass.connection))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DataGrid1.DataSource = dt;
                        DataGrid1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                if (SqlConnectionClass.connection.State == ConnectionState.Open)
                {
                    SqlConnectionClass.connection.Close();
                }
            }
        }
    }
}