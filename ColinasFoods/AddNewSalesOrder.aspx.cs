using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class AddNewSalesOrder : System.Web.UI.Page
    {

        private double _gTotal = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["LoginTime"] == null) || Session["CustomerID"] == null)
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                ((SiteMaster)Master).HeaderTitle = "Invoice Search";
                Title = "Add New Sales Order";

                if (!IsPostBack)
                {
                    Session["Check_Page_Refresh"] = DateTime.Now.ToString();
                    _gTotal = 0;
                    ViewState["granTotal"] = _gTotal;
                    LoadItemsGrid("Sales_OrderedItems", "%%");
                    ViewState["Procedure"] = "Sales_OrderedItems";
                    BtnOrdered.BackColor = System.Drawing.Color.FromArgb(73, 74, 84);
                }
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["Check_Page_Refresh"] = Session["Check_Page_Refresh"];
        }

        private void LoadItemsGrid(String storedProcedure, String filter)
        {
            try
            {
                int customerID = Convert.ToInt32(Session["CustomerID"]);

                SqlDataSource1.SelectCommand = storedProcedure;
                SqlDataSource1.SelectParameters.Clear();
                SqlDataSource1.SelectParameters.Add("CustomerID", customerID.ToString());
                SqlDataSource1.SelectParameters.Add("MatDesc", filter);
                ItemsGrid.DataSourceID = "SqlDataSource1";

                ItemsGrid.DataBind();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                Trace.Write("Error", "**Error in LoadCustomerContacts**", ex);
                //ErrorSignal.FromCurrentContext().Raise(ex);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Cant Get Previously Ordered Items:" + message + "');", true);
            }
        }

        protected void ItemsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow SelectedItem = ItemsGrid.Rows[ItemsGrid.SelectedIndex];

            AddNewRowToGrid(SelectedItem);
        }

        private void AddNewRowToGrid(GridViewRow SelectedItem)
        {
            int rowIndex = 0;
            DataTable dt = new DataTable();
            DataRow dr = null;

            if (ViewState["CurrentTable"] != null)
            {
                dt = (DataTable)ViewState["CurrentTable"];
                rowIndex = dt.Rows.Count;
            }
            else
            {
                dt.Columns.Add(new DataColumn("MaterialID", typeof(string)));
                dt.Columns.Add(new DataColumn("ItemNumber", typeof(string)));
                dt.Columns.Add(new DataColumn("PartNo", typeof(string)));
                dt.Columns.Add(new DataColumn("ItemDesc", typeof(string)));
                dt.Columns.Add(new DataColumn("UM", typeof(string)));
                dt.Columns.Add(new DataColumn("Price", typeof(string)));
                dt.Columns.Add(new DataColumn("Qty", typeof(string)));
                dt.Columns.Add(new DataColumn("Total", typeof(string)));
            }

            dr = dt.NewRow();
            dr["MaterialID"] = ItemsGrid.DataKeys[SelectedItem.RowIndex][0];
            dr["ItemNumber"] = rowIndex + 1;
            dr["PartNo"] = SelectedItem.Cells[0].Text;
            dr["ItemDesc"] = SelectedItem.Cells[1].Text;
            dr["UM"] = SelectedItem.Cells[2].Text;
            dr["Price"] = SelectedItem.Cells[3].Text;
            dr["Qty"] = "1";
            dr["Total"] = dr["Price"];
            dt.Rows.Add(dr);

            //Store the DataTable in ViewState
            ViewState["CurrentTable"] = dt;

            CartGrid.DataSource = dt;
            CartGrid.DataBind();

            //Set Previous Data on Postbacks
            SetPreviousQtyData();
        }

        private void SetPreviousQtyData()
        {
            int rowIndex = 0;
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TextBox QtyBox = (TextBox)CartGrid.Rows[rowIndex].Cells[5].FindControl("Qty");
                        QtyBox.Text = dt.Rows[i]["Qty"].ToString();
                        rowIndex++;
                    }
                }
            }
        }

        protected void Qty_TextChanged(object sender, EventArgs e)
        {
            TextBox qty = (TextBox)sender;
            GridViewRow row = qty.NamingContainer as GridViewRow;
            DataTable dt = (DataTable)ViewState["CurrentTable"];
            int rowIndex = row.RowIndex;

            // Get price as string (w/o '$') and set it as total for now.
            String total = Regex.Replace(row.Cells[4].Text, @"[^\d.]", "");
            double Price = Convert.ToDouble(total);

            try
            {
                double quantity = Convert.ToDouble(qty.Text);
                total = Convert.ToString(Convert.ToDouble(qty.Text) * Price);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Invalid Quantity Number!');", true);
                qty.Text = "1";
            }

            dt.Rows[rowIndex][6] = qty.Text;
            dt.Rows[rowIndex][7] = String.Format("{0:C2}", Convert.ToDouble(total));

            ViewState["CurrentTable"] = dt;

            CartGrid.DataSource = dt;
            CartGrid.DataBind();

            SetPreviousQtyData();
        }

        protected void CartGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                _gTotal += Convert.ToDouble(Regex.Replace(e.Row.Cells[6].Text, @"[^\d.]", ""));
            }
            if(e.Row.RowType == DataControlRowType.Footer)
            {
                String grandTotal = String.Format("{0:C2}", _gTotal);
                e.Row.Cells[6].Text = "Grand Total: " + grandTotal;
                e.Row.Cells[6].Font.Bold = true;
                e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Right;

                ViewState["granTotal"] = _gTotal;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(TxtStartDate.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please select Required Date!');", true);
                return;
            }
            else if (ViewState["CurrentTable"] != null && ViewState["granTotal"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                double GrandTotal = Convert.ToDouble(ViewState["granTotal"]);

                if (dt.Rows.Count > 0)
                {
                    String strConnString = ConfigurationManager.ConnectionStrings["ColinasERPEntities"].ConnectionString;
                    SqlConnection con = new SqlConnection(strConnString);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Sales_AddSalesOrder";
                    cmd.Parameters.AddWithValue("CustomerID", Convert.ToString(Session["CustomerID"]));
                    cmd.Parameters.AddWithValue("DateIssued", DateTime.Now);
                    cmd.Parameters.AddWithValue("ReleaseDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("RequiredDate", Convert.ToDateTime(TxtStartDate.Text));
                    cmd.Parameters.AddWithValue("Subtotal", GrandTotal);
                    cmd.Parameters.AddWithValue("Total", GrandTotal);
                    cmd.Connection = con;

                    try
                    {
                        con.Open();
                        object output = cmd.ExecuteScalar();
                        string SalesOrderID = output.ToString();

                        cmd.CommandText = "Sales_AddSalesOrder_Details";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cmd.Parameters.Clear();
                            DataRow dr = dt.Rows[i];
                            double Price = Convert.ToDouble(Regex.Replace(dr["Price"].ToString(), @"[^\d.]", ""));
                            double Total = Convert.ToDouble(Regex.Replace(dr["Total"].ToString(), @"[^\d.]", ""));

                            cmd.Parameters.AddWithValue("SalesID", SalesOrderID);
                            cmd.Parameters.AddWithValue("MaterialID", Convert.ToInt32(dr["MaterialID"]));
                            cmd.Parameters.AddWithValue("ItemNumber", Convert.ToInt32(dr["ItemNumber"]));
                            cmd.Parameters.AddWithValue("PartNo", dr["PartNo"].ToString());
                            cmd.Parameters.AddWithValue("ItemDesc", dr["ItemDesc"].ToString());
                            cmd.Parameters.AddWithValue("UM", dr["UM"].ToString());
                            cmd.Parameters.AddWithValue("Price", Price);
                            cmd.Parameters.AddWithValue("Qty", Convert.ToDouble(dr["Qty"]));
                            cmd.Parameters.AddWithValue("Total", Total);

                            cmd.ExecuteNonQuery();
                        }

                        //SendEmail();

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Successfully Submitted Sales Order!');", true);
                        Response.Redirect("SalesOrderHistory.aspx", false);
                        Context.ApplicationInstance.CompleteRequest();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please add an Item before submitting!');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please add an Item before submitting!');", true);
            }
        }

        private void SendEmail()
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("jemendez4372@gmail.com");
            mail.From = new MailAddress("PjJT8YzUBEXo@colinasproducts.com", "test 2", System.Text.Encoding.UTF8);
            mail.Subject = "This mail is send from asp.net application";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "test 2";
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("PjJT8YzUBEXo@colinasproducts.com", "TTY151gzf!");
            client.Port = 25;
            client.Host = "smtp.colinasproducts.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Email Sent!');", true);
            }
            catch (Exception ex)
            {
                throw ex;
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Email Failed :( !');", true);
            }
        }

        protected void BtnOrdered_Click(object sender, EventArgs e)
        {
            String filter = "%" + TxtFilter.Text.Replace("'", "''") + "%";

            LoadItemsGrid("Sales_OrderedItems", filter);
            ViewState["Procedure"] = "Sales_OrderedItems";

            BtnOrdered.BackColor = System.Drawing.Color.FromArgb(73, 74, 84);
            BtnOther.BackColor = System.Drawing.Color.FromArgb(176, 5, 5);
        }

        protected void BtnOther_Click(object sender, EventArgs e)
        {
            String filter = "%" + TxtFilter.Text.Replace("'", "''") + "%";

            LoadItemsGrid("Sales_NonOrderedItems", filter);
            ViewState["Procedure"] = "Sales_NonOrderedItems";

            BtnOrdered.BackColor = System.Drawing.Color.FromArgb(176, 5, 5);
            BtnOther.BackColor = System.Drawing.Color.FromArgb(73, 74, 84);
        }

        protected void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            String filter = "%" + TxtFilter.Text.Replace("'", "''") + "%";
            String procedure = Convert.ToString(ViewState["Procedure"]);

            LoadItemsGrid(procedure, filter);
        }
    }
}