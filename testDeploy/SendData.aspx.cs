using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testDeploy.Controllers;

namespace testDeploy
{
    public partial class SendData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Preprocess a send data request and pass request to controller
        protected void SendButtonClick(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;
            float value;
            bool success = float.TryParse(ValueTextBox.Text, out value);
            if (!(success))
            {
                DisplayStatus("Data not sent: Value is not a valid float.");
                return;
            }
            success = MainController.SendData(id, value);
            if (success)
                DisplayStatus("Data sent successfully.");
            else
                DisplayStatus("Data sending was unsuccessful.");
            
        }

        //Displays a message
        protected void DisplayStatus(string status)
        {
            StatusDisplay.Text = status + " Current time is " + DateTime.Now.ToLongTimeString();
        }
    }
}