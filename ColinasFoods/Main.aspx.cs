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
                ((SiteMaster)Master).HeaderTitle = "Welcome to Colinas Foods";
                Title = "Order History";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();

                    
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
    }
}
