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
    public partial class AddCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from TableBrand", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            DropDownList1.DataTextField = "BrandName";
            DropDownList1.DataValueField = "BrandID";
            DropDownList1.DataSource = dr;
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}