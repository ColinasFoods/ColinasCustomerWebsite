using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class SalesOrderHistory : System.Web.UI.Page
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
                ((SiteMaster)Master).SalesVisible = false;
                ((SiteMaster)Master).HeaderTitle = "Sales";
                Title = "Sales";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();

                    LoadOrderHistory();
                    Essentials.CurrentPage = ColinasFoods.Page.SALES_ORDER;
                }
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["Check_Page_Refresh"] = Session["Check_Page_Refresh"];
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

        protected void ItemsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDetails_Click(object sender, EventArgs e)
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
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();

                    Button btn = (Button)sender;
                    GridViewRow row = (GridViewRow)btn.NamingContainer;
                    int SalesID = Convert.ToInt32(ItemsGrid.DataKeys[row.RowIndex]["SalesOrderID"]);
                    String SalesNo = row.Cells[0].Text;
                    String Total = row.Cells[3].Text;

                    LoadSalesOrderDetails(SalesID, SalesNo, Total);
                }
            }
        }

        private void LoadSalesOrderDetails(int SalesID, String SalesNo, String Total)
        {
            TxtSalesOrderNo.Text = SalesNo;
            TxtTotal.Text = String.Format("{0:C}", Total);

            SqlDataSource2.SelectParameters.Clear();
            SqlDataSource2.SelectParameters.Add("SalesID", SalesID.ToString());

            DetailsGrid.DataSourceID = "SqlDataSource2";
            DetailsGrid.DataBind();
        }
    }
}