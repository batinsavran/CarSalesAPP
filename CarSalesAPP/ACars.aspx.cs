using CarSalesAPP.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarSalesAPP
{
    public partial class ACarsaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCarData();
            }
        }

        private void LoadCarData()
        {
            try
            {
                SqlConnectionClass.CheckConnection();

                using (SqlCommand cmd = new SqlCommand("SELECT CarModel, BrandName, CarPhoto, CarFuelType, CarDescription, CarSeller, CarContact, CarPrice, CarBrandID FROM TableCar INNER JOIN TableBrand ON TableCar.CarBrandID = TableBrand.BrandID WHERE CarConfirmation = @pcon", SqlConnectionClass.connection))
                {
                    cmd.Parameters.AddWithValue("@pcon", true);

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