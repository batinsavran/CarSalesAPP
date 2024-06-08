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
            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("Select * from TableBrand", SqlConnectionClass.connection);
                SqlConnectionClass.CheckConnection();

                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    DropDownList1.DataTextField = "BrandName";
                    DropDownList1.DataValueField = "BrandID";
                    DropDownList1.DataSource = dr;
                    DropDownList1.DataBind();

                    dr.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Veritabanı hatası: " + ex.Message);
                }
                finally
                {
                    SqlConnectionClass.connection.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("Insert into TableCar (CarModel, CarBrandID, CarPhoto, CarFuelType, CarDescription, CarSeller, CarContact, CarPrice, CarConfirmation) values (@pmodel, @pbrand, @pphoto, @pfuel, @pdescription, @pseller, @pcontact, @pprice, @pconfirmation)", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();

            try
            {
                sql.Parameters.AddWithValue("@pmodel", tbModel.Text);
                sql.Parameters.AddWithValue("@pbrand", Convert.ToInt32(DropDownList1.SelectedValue));
                sql.Parameters.AddWithValue("@pphoto", tbPhoto.Text);
                sql.Parameters.AddWithValue("@pfuel", tbFuelType.Text);
                sql.Parameters.AddWithValue("@pdescription", tbDescription.Text);
                sql.Parameters.AddWithValue("@pseller", tbSeller.Text);
                sql.Parameters.AddWithValue("@pcontact", tbContact.Text);
                sql.Parameters.AddWithValue("@pprice", Convert.ToDecimal(tbPrice.Text));
                sql.Parameters.AddWithValue("@pconfirmation",true); // Varsayılan olarak false değer atandı

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                SqlConnectionClass.connection.Close();
            }
        }
    }
}
