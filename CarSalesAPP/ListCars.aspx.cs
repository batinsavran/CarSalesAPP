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
            SqlCommand cmd = new SqlCommand("Select * from TableCar where CarConfirmation=@pcon", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            cmd.Parameters.AddWithValue("@pcon", true);

            SqlDataReader dr = cmd.ExecuteReader();

            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}