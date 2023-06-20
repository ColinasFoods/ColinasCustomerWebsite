using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class PaymentSearch : System.Web.UI.Page
    {
        private Decimal _TotalPayment;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                ((SiteMaster)Master).HeaderTitle = "Payments";
                Title = "Payments";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();
                    _TotalPayment = 0;
                    LoadPayments();
                }
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["Check_Page_Refresh"] = Session["Check_Page_Refresh"];
        }

        protected void BtnQuery_Click(object sender, EventArgs e)
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
                    LoadPayments();
                }
            }
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
                    int PaymentID = Convert.ToInt32(PaymentsGrid.DataKeys[row.RowIndex]["PaymentAplicationID"]);
                    String PaymentNo = row.Cells[0].Text;
                    String PaymentTotal = row.Cells[2].Text;

                    LoadPaymentDetails(PaymentID, PaymentNo, PaymentTotal);
                }
            }
        }

        private void LoadPayments()
        {
            if ((Session["CustomerID"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                try
                {
                    int customer_id = Convert.ToInt32(Session["CustomerID"]);

                    DateTime startDate;
                    if (TxtStartDate.Text != "")
                    {
                        try { startDate = Convert.ToDateTime(TxtStartDate.Text); }
                        catch
                        {
                            startDate = Convert.ToDateTime("01/01/1900");
                            TxtStartDate.Text = "";
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please validate start date');", true);
                        }
                    }
                    else
                    {
                        startDate = Convert.ToDateTime("01/01/1900");
                    }

                    DateTime endDate;
                    if (TxtEndDate.Text != "")
                    {
                        try { endDate = Convert.ToDateTime(TxtEndDate.Text); }
                        catch
                        {
                            endDate = Convert.ToDateTime("12/31/2200");
                            TxtEndDate.Text = "";
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please validate end date');", true);
                        }
                    }
                    else
                    {
                        endDate = Convert.ToDateTime("12/31/2200");
                    }


                    SqlDataSource1.SelectParameters.Clear();
                    SqlDataSource1.SelectParameters.Add("customerID", customer_id.ToString());
                    SqlDataSource1.SelectParameters.Add("startDate", startDate.ToShortDateString());
                    SqlDataSource1.SelectParameters.Add("endDate", endDate.ToShortDateString() + " 23:59:59");

                    PaymentsGrid.DataSourceID = "SqlDataSource1";
                    PaymentsGrid.Sort("PaymentDate", SortDirection.Descending);
                    PaymentsGrid.DataBind();
                }
                catch (Exception ex)
                {
                    Trace.Write("Error", "**Error in LoadCustomerContacts**", ex);
                    //ErrorSignal.FromCurrentContext().Raise(ex);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Cant Get Payment Infomation');", true);
                }
            }
        }

        protected void LoadPaymentDetails(int PaymentID, String PaymentNo, String Total)
        {
            TxtPaymentNo.Text = PaymentNo;
            TxtPaymentTotal.Text = String.Format("{0:C}", Total);

            SqlDataSource2.SelectParameters.Clear();
            SqlDataSource2.SelectParameters.Add("paymentID", PaymentID.ToString());

            DetailsGrid.DataSourceID = "SqlDataSource2";
            DetailsGrid.DataBind();
        }

        protected void PaymentsGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
                try
                {
                    String PaymentAmount = Regex.Replace(e.Row.Cells[2].Text, @"[^\d.]", "");
                    _TotalPayment += Convert.ToDecimal(PaymentAmount);
                }
                catch { }
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[1].Text = "Total:";
                e.Row.Cells[2].Text = String.Format("{0:C}", _TotalPayment);
            }
        }
    }
}