using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class Balance : System.Web.UI.Page
    {
        private Decimal _totalBalance;
        private Decimal _totalOnTime;
        private Decimal _total30Time;
        private Decimal _total60Time;
        private Decimal _total90Time;
        private Decimal _total91Time;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null))
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                ((SiteMaster)Master).HeaderTitle = "Balance";
                Title = "Payments";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();
                    _totalBalance = 0;
                    _total30Time = 0;
                    _total60Time = 0;
                    _total90Time = 0;
                    _total91Time = 0;
                    LoadBalance();
                }
                ColinasFoods.Essentials.HomeSeen = true;
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
                    LoadBalance();
                }
            }
        }

        private void LoadBalance()
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

                    BalancesGrid.DataSourceID = "SqlDataSource1";
                    BalancesGrid.Sort("InvoiceDate", SortDirection.Descending);
                    BalancesGrid.DataBind();
                }
                catch (Exception ex)
                {
                    Trace.Write("Error", "**Error in LoadCustomerContacts**", ex);
                    //ErrorSignal.FromCurrentContext().Raise(ex);
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Cant Get Payment Infomation');", true);
                }
            }
        }

        protected void BalancesGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;
                e.Row.Cells[5].HorizontalAlign = HorizontalAlign.Right;
                e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Right;
                e.Row.Cells[7].HorizontalAlign = HorizontalAlign.Right;
                e.Row.Cells[8].HorizontalAlign = HorizontalAlign.Right;
                e.Row.Cells[9].HorizontalAlign = HorizontalAlign.Right;

                try
                {
                    String BalanceAmount = Regex.Replace(e.Row.Cells[4].Text, @"[^\d.]", "");
                    String OnTimeAmount = Regex.Replace(e.Row.Cells[5].Text, @"[^\d.]", "");
                    String Amount30 = Regex.Replace(e.Row.Cells[6].Text, @"[^\d.]", "");
                    String Amount60 = Regex.Replace(e.Row.Cells[7].Text, @"[^\d.]", "");
                    String Amount90 = Regex.Replace(e.Row.Cells[8].Text, @"[^\d.]", "");
                    String Amount91 = Regex.Replace(e.Row.Cells[9].Text, @"[^\d.]", "");

                    if (e.Row.Cells[4].Text[0] == '(')
                        _totalBalance -= Convert.ToDecimal(BalanceAmount);
                    else 
                        _totalBalance += Convert.ToDecimal(BalanceAmount);

                    if (e.Row.Cells[5].Text[0] == '(')
                        _totalOnTime -= Convert.ToDecimal(OnTimeAmount);
                    else
                        _totalOnTime += Convert.ToDecimal(OnTimeAmount);

                    if (e.Row.Cells[6].Text[0] == '(')
                        _total30Time -= Convert.ToDecimal(Amount30);
                    else
                        _total30Time += Convert.ToDecimal(Amount30);

                    if (e.Row.Cells[7].Text[0] == '(')
                        _total60Time -= Convert.ToDecimal(Amount60);
                    else
                        _total60Time += Convert.ToDecimal(Amount60);

                    if (e.Row.Cells[8].Text[0] == '(')
                        _total90Time -= Convert.ToDecimal(Amount90);
                    else
                        _total90Time += Convert.ToDecimal(Amount90);

                    if (e.Row.Cells[9].Text[0] == '(')
                        _total91Time -= Convert.ToDecimal(Amount91);
                    else
                        _total91Time += Convert.ToDecimal(Amount91);
                }
                catch { }
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[3].Text = "Total:";
                e.Row.Cells[4].Text = String.Format("{0:C}", _totalBalance);
                e.Row.Cells[5].Text = String.Format("{0:C}", _totalOnTime);
                e.Row.Cells[6].Text = String.Format("{0:C}", _total30Time);
                e.Row.Cells[7].Text = String.Format("{0:C}", _total60Time);
                e.Row.Cells[8].Text = String.Format("{0:C}", _total90Time);
                e.Row.Cells[9].Text = String.Format("{0:C}", _total91Time);
            }
        }
    }
}