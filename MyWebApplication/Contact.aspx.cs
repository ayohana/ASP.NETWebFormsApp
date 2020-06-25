using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divMessage.Attributes.Add("style", "color:red;");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = string.Format("You said your name is {0} and your age is {1} and your email address is {2}. Your favorite color is {3}.", txtName.Text, txtAge.Text, txtEmail.Text, ddlColor.SelectedValue);
            ltMessage.Text = message;
        }

        // This is a Web Server Control Event. A text appears (something happens) upon selection of a drop down list item (when the user does something).
        protected void ddlColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = string.Format("You just chose the color {0}", ddlColor.SelectedValue);
            ltMessage.Text = message;
        }
    }
}