using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
    public static class Essentials
    {
        private static String username;
        private static String password;
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
    }

    public static class Cipher
    {
        public static String GetUniqueSessionID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}