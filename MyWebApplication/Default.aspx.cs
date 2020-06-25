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

// WEB SERVER CONTROL EVENTS =====================
// One of the most powerful features of ASP.NET Web Forms is the ability to map Server Side Events to controls that users interact with on the client. For example, if a user clicks on a button, selects a box, or selects an option from a drop down list (and much more), you can perform server-side logic!
// In ASP.NET Web Forms Application, the majority of your application logic will exist in your Server Side code. Your presentation markup with exist in your .aspx page and your application in your codeBehind.

// VIEW STATE ====================================
// Without a methodology for tracking page state, a web application by default is stateless.
// In ASP.NET, when we submit, we aren't submitting data from one page to another page, we are submitting a page to itself. This is called a "POST BACK", since the page is posting data back to itself.
// View State makes forms "sticky" - field values don't disappear after submitting the form so user input is not lost. Each of the server controls on the page, their state is encoded and sent to the server every time the page is submitted.
// View State can affect performance. If you have a large number of controls, you'll have a large number of ViewStates being stored.
// View States can be useful especially when a user has to fill in a very long form. Just in case something happens, the info doesn't get lost.

// PAGE LIFE CYCLE & EVENTS =======================
// ASP.NET Web Forms Page Life Cycle is important to understand in order to implement events and initialize controls.
// Here's the Life Cycle:
// 1. The Page Request
// 2. Start
// 3. Page Initialization
// 4. Page Load
// 5. Page Validation
// 6. PostBack Event Handling
// 7. Rendering
// 8. Unload
// Note that Page_Load (stage 4) comes before the PostBack event (e.g. btnSubmit_Click event; stage 6)!
// In most of your development cycle, you'll be concerned with stages #4-6: Page Load, Page Validation, and PostBack Event Handling.
//
// The 8 Stages of the Life Cycle:
// 1. The Page Request
// When the page is requested by a user (client makes a request to the server), the caching, parsing and compiling is determined by ASP.NET.
// 2. Start
// In the start page, the page properties are set. In ASP.NET, Page is an object with properties such as "Request" and "IsPostBack". The "Request" property would consist of an HTTP request data such as query string parameters and headers. The "IsPostBack" property tells you whether the page has been loaded for the first time or if the user is posting the page. These are the properties you can access in the CodeBehind of aspx pages.
// 3. Page Initialization
// In this phase, page controls become available and themes are applied. If this is a PostBack, the properties of the controls will not yet have the data from the PostBack.
// 4. Page Load
// The control properties are set from the View State. This means that any user  select values are now avaialble in the properties of the controls.
// 5. Page Validation
// The Validate() method is called for all of the validation controls of the page. The validation control properties are also set, such as "IsValid".
// 6. PostBack Event Handling
// If the user is submitting data and the page is "posting back" to itself, then events are handled. For example, when a user clicks on a button, the "OnClick" method will be called during this stage.
// 7. Rendering
// View State is saved for the page and makes field values "sticky". This phase calls the render method for each control that renders the HTML to be returned in the response.
// 8. Unload
// The cleanup stage. This stage occurs after the response is sent to the client. Page properties are unloaded. The page life cycle is now complete.



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