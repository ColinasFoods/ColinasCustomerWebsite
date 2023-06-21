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
using System.Windows.Forms;

    namespace ColinasFoods
{
    public partial class PDFDownloads : System.Web.UI.Page
    {
        private Decimal _totalInvoice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {


          
            ((SiteMaster)Master).logOutVisible = false;
            ((SiteMaster)Master).HeaderTitle = "PDF Download";
            Title = "PDF Download";


        }
    }
}