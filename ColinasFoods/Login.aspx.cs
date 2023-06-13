using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ColinasFoods.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ColinasFoods
{
    public partial class Login : System.Web.UI.Page
    {
        private String strConnString = ConfigurationManager.ConnectionStrings["ColinasERPEntities"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            ((SiteMaster)Master).NavBarVisible = false;
            ((SiteMaster)Master).HeaderTitle = "Customer Login";
            Title = "Customer Login";
        }

        protected void btn_LogIn_Click(object sender, EventArgs e)
        {
            string username = tb_UserName.Text.ToLower();
            string password = tb_Password.Text;

            Session["LoginTime"] = DateTime.Now.ToString();
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Colinas_Login";
            cmd.Parameters.AddWithValue("user", username);
            cmd.Parameters.AddWithValue("pw", password);
            cmd.Connection = con;

            try
            {
                con.Open();
                object output = cmd.ExecuteScalar();
                if (output != null)
                {
                    Session["CustomerID"] = Convert.ToInt32(output);
                    Response.Redirect("InvoiceSearch.aspx", false);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Username and Password does not match');", true);
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error logging in." + ex.Message + "');", true);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}