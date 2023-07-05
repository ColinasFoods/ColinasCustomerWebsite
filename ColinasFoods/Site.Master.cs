using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public enum Page
    {
        LOGIN,
        MAIN,
        BALANCE,
        PAYMENTS,
        INVOICES,
        SALES_ORDER
    }

    public static class Essentials
    {
        private static String username;
        private static String password;
        private static decimal currentBalance;
        private static Page currentPage;
        public static String UserName
        {
            set { username = value; }
            get { return username; }
        }

        public static String Password
        {
            set { password = value; }
            get { return password; }
        }

        public static decimal CurrentBalance
        {
            set { currentBalance = value; }
            get { return currentBalance; }
        }
        
        public static Page CurrentPage
        {
            set { currentPage = value; }
            get { return currentPage; }
        }
    }
    public partial class SiteMaster : MasterPage
    {
        public string HeaderTitle
        {
            get
            {
                return LblHeaderTitle.Text;
            }
            set
            {
                LblHeaderTitle.Text = value;
            }
        }

        public bool NavBarVisible
        {
            get { return NavBar.Visible; }
            set { NavBar.Visible = value; }
        }
        public bool logOutVisible
        {
            get { return logout_link.Visible; }
            set { logout_link.Visible = value; }
        }
        public bool ProfileVisible
        {
            get { return Profiles.Visible; }
            set { Profiles.Visible = value; }
        }
        public bool PFPVisible
        {
            get { return PFP.Visible; }
            set { PFP.Visible = value; }
        }

        public bool SalesVisible
        {
            get { return LblSalesOrder.Visible; }
            set { LblSalesOrder.Visible = value; }
        }

        public bool InvoiceVisible
        {
            get { return LblInvoices.Visible; }
            set { LblInvoices.Visible = value; }
        }

        public bool BalanceVisible
        {
            get { return LblBalance.Visible; }
            set { LblBalance.Visible = value; }
        }

        public bool PaymentVisible
        {
            get { return LblPayments.Visible; }
            set { LblPayments.Visible = value; }
        }

        protected void logout_Click(object sender, EventArgs e)
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

        protected void btnToAdminHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
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
                if (IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();
                    Response.Redirect("ProfileCredentials.aspx", false);

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
                if (IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();
                    Response.Redirect("PDFDownloads.aspx", false);

                }
            }

        }
        protected void BtnReturn_click(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                // Is Event Fired PostBack, NOT REFRESH
                if (IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();
                    Page.ClientScript.RegisterStartupScript(
    this.GetType(), "OpenWindow", "window.open('/images/return.jpg','_blank');", true);

                }
            }

        }

        public static class Cipher
        {
            public static String GetUniqueSessionID()
            {
                return Guid.NewGuid().ToString();
            }
        }

    }
}