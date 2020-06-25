using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// NOTES ========================================
// ASP.NET Web Forms are event driven pages with server code, server controls and server events.

// MASTER PAGES =================================
// ASP.NET Web Forms applications utilize Master Templates which are a centralized file where you can manage the header, footer and body of your site all in one place.
// The final rendered HTML of the page is a combination of the Master Template and the Active Server Page
// The Master Page contains the <html>, <head>, and <body> tags that will be rendered out to for the final HTML document. The Master Page can also include server side code, user controls, and server controls, allowing dynamic content.

// ASP.NET Web Forms active server pages utilize a "code behind" approach that provides a clean break of the presentation markup from the page logic.
// They also feature controls which are objects on the ASP.NET pages that render HTML to the browser when the page is requested.
// You can also create your own, reusable controls that can be used on multiple pages. These are called "User Controls".

// BASIC SERVER CONTROLS =========================
// There are 3 different types of Server Controls in ASP.NET Web Forms:
// 1. HTML Server Controls
// 2. Web Server Controls
// 3. Validation Server Controls

// In order to be a Server Control, regardless of type, the tag must contain the runat="server" attribute
// Server Controls are named things like button, textbox, dropdownlist, and allow you to interact with and create events for these controls. You can also bind data to these controls, for dynamic content.

// ADVANCED SERVER CONTROLS ======================
// In addition to Web Server Controls (e.g. TextBox, Button, DropDownList) that map up to common HTML elements like input and select, there are more complex server controls that provide advanced functionality and/or display of dynamic data.

namespace MyWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact");
        }
    }
}