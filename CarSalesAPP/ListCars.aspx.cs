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
    public partial class ListCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select CarModel,BrandName,CarPhoto,CarFuelType,CarDescription,CarSeller,CarContact,CarPrice,CarBrandID from TableCar inner join TableBrand on TableCar.CarBrandID=TableBrand.BrandID where CarConfirmation=@pcon", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            cmd.Parameters.AddWithValue("@pcon", true);

            SqlDataReader dr = cmd.ExecuteReader();

            DataList1.DataSource = dr;
            DataList1.DataBind();
            
            dr.Close();
        }
    }
}