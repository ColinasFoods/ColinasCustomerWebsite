﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColinasFoods
{
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