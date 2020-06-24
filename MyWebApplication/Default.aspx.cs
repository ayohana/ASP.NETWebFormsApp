﻿using System;
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