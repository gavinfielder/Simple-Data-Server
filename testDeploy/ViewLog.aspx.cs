﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testDeploy.Controllers;

namespace testDeploy
{
    public partial class ViewLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogDisplay.Text = MainController.Log.ReadAll();
        }
    }
}