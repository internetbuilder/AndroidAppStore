﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bonrix_App_Store.Class;

namespace Bonrix_App_Store.Store
{
    public partial class Store : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                }
            }
            catch (Exception ex)
            {
                ClsLog.LogException(ex, "Error at Page Store -->Page_Load");
                Notification("Error at Page Store ", "error");
            }            
        }
        protected void Notification(string message, string iconn)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Msg", "Notification('" + message + "','" + iconn + "');", true);
            return;
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Admin/Login.aspx");
            }
            catch (Exception ex)
            {
                ClsLog.LogException(ex, "Error at Page Store -->Login_Click");
                Notification("Error at Page Store ", "error");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Admin/Login.aspx");
            }
            catch (Exception ex)
            {
                ClsLog.LogException(ex, "Error at Page Store -->Login_Click");
                Notification("Error at Page Store ", "error");
            }
        }
    }
}