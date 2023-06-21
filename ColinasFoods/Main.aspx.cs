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
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                ((SiteMaster)Master).NavBarVisible = false;
                ((SiteMaster)Master).logOutVisible = false;
                ((SiteMaster)Master).HeaderTitle = "Welcome to Colinas Foods";
                WelcomeDiv.Visible = welcomeTextVisible;
                Title = "Order History";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();

                    LoadOrderHistory();
                    LoadBalance();
                    GetMyBalance();
                }
            }
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
        protected void BtnProfileCredentials_Click(object sender, EventArgs e)
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
                    Response.Redirect("ProfileCredentials.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }
        protected void BtnPDFDownload_click(object sender, EventArgs e)
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
                    Response.Redirect("PDFDownloads.aspx", false);
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

        private void LoadBalance()
        {
            try
            {
                int customerID = Convert.ToInt32(Session["CustomerID"]);

                SqlDataSource2.SelectParameters.Clear();
                SqlDataSource2.SelectParameters.Add("CustomerID", customerID.ToString());
                hiddenBalanceGrid.DataSourceID = "SqlDataSource2";

                hiddenBalanceGrid.DataBind();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                Trace.Write("Error", "**Error in LoadOrderHistory**", ex);
                //ErrorSignal.FromCurrentContext().Raise(ex);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Cant Get Order History:" + message + "');", true);
            }
        }
        protected void GetMyBalance()
        {
            Decimal currentBalance = 0.0M;
            foreach (GridViewRow row in hiddenBalanceGrid.Rows)
            {
                Decimal temp;
                if (Decimal.TryParse(row.Cells[4].Text.Trim('$'), out temp))
                {
                    currentBalance += temp;
                } else
                {
                    continue;
                }
            }

            Essentials.CurrentBalance = currentBalance;
            balanceLabel.Text = '$' + Decimal.Round(Essentials.CurrentBalance, 2).ToString();
        }

        protected void ItemsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            try
            {
                string logouttime = System.DateTime.Now.ToString();
                if (Session["LoginTime"] != null)
                {
                    string logintime = Session["LoginTime"].ToString();
                    TimeSpan timeDiff = DateTime.Parse(logouttime) - DateTime.Parse(logintime);
                    string differenceinseconds = timeDiff.Seconds.ToString();
                    string differenceinminutes = timeDiff.Minutes.ToString();

                }


                Session.Contents.RemoveAll();

                Response.Redirect("~/Login.aspx", true);

            }

            catch (Exception ex)
            {
                //ErrorSignal.FromCurrentContext().Raise(ex);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error: Logging out');", true);
            }





        }
    }
}
