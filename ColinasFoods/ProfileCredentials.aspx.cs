using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public partial class ProfileCredentials : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if(Essentials.Password == null)
            {
                Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            ((SiteMaster)Master).logOutVisible = false;
            ((SiteMaster)Master).HeaderTitle = "Profile Credentials";
            Title = "Profile Credentials";
            loadAsteriskPassword();


        }
        protected void loadAsteriskPassword()
        {
            if (ColinasFoods.Essentials.UserName != null && ColinasFoods.Essentials.UserName.Length > 0)
            {
                int passwordLength = ColinasFoods.Essentials.Password.Length;
                for (int i = 0; i < passwordLength; i++)
                {
                    passwordLabel.Text += '*';
                }
            }

        }
    }
}