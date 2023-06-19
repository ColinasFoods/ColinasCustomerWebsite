using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class Main : System.Web.UI.Page
    {
        private bool welcomeTextVisible = true;
        public bool WelcomeTextVisible
        {
            get { return welcomeTextVisible; }
            set { welcomeTextVisible = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            WelcomeTextVisible = false;
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                ((SiteMaster)Master).NavBarVisible = false;
                ((SiteMaster)Master).HeaderTitle = "Welcome to Colinas Foods";
                welcomeTextVisible = !Essentials.HomeSeen;
                WelcomeDiv.Visible = welcomeTextVisible;
                Title = "Order History";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();


                }
            }
        }

        public static string GetName()
        {
            return ColinasFoods.Essentials.UserName != null ? ColinasFoods.Essentials.UserName.ToCharArray()[0].ToString().ToUpper() + ColinasFoods.Essentials.UserName.Substring(1) : "Guest";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["Check_Page_Refresh"] = Session["Check_Page_Refresh"];
        }
        
        protected void BtnAddNewSO_Click(object sender, EventArgs e)
        {
            
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                // Is Event Fired PostBack, NOT REFRESH
                if (ViewState["Check_Page_Refresh"].ToString() == Session["Check_Page_Refresh"].ToString())
                {
                    Response.Redirect("AddNewSalesOrder.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }

            }
        }
        protected void BtnBalance_Click(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                // Is Event Fired PostBack, NOT REFRESH
                if (ViewState["Check_Page_Refresh"].ToString() == Session["Check_Page_Refresh"].ToString())
                {
                    Response.Redirect("Balance.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }

        }
        protected void BtnInvoice_Click(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                // Is Event Fired PostBack, NOT REFRESH
                if (ViewState["Check_Page_Refresh"].ToString() == Session["Check_Page_Refresh"].ToString())
                {
                    Response.Redirect("InvoiceSearch.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }
        protected void BtnOrderHistory_Click(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                // Is Event Fired PostBack, NOT REFRESH
                if (ViewState["Check_Page_Refresh"].ToString() == Session["Check_Page_Refresh"].ToString())
                {
                    Response.Redirect("SalesOrderHistory.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }
        protected void BtnPayment_Click(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                // Is Event Fired PostBack, NOT REFRESH
                if (ViewState["Check_Page_Refresh"].ToString() == Session["Check_Page_Refresh"].ToString())
                {
                    Response.Redirect("PaymentSearch.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }

        private void LoadOrderHistory()
        {
            try
            {
                int customerID = Convert.ToInt32(Session["CustomerID"]);

                SqlDataSource1.SelectParameters.Clear();
                SqlDataSource1.SelectParameters.Add("CustomerID", customerID.ToString());
                ItemsGrid.DataSourceID = "SqlDataSource1";

                ItemsGrid.DataBind();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                Trace.Write("Error", "**Error in LoadOrderHistory**", ex);
                //ErrorSignal.FromCurrentContext().Raise(ex);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Cant Get Order History:" + message + "');", true);
            }
        }

        protected void ItemsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    }
}
