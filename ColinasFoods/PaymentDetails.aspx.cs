using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class PaymentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ColinasFoods.Essentials.HomeSeen = true;
        }
    }
}