using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication
{
    public partial class MyEventPage : System.Web.UI.Page
    {
        private List<MyEvent> myEvents;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page.IsPostBack gets a value that indicates whether the page is being rendered for the first time or being loaded in response to a postback.
            // PostBack is the name given to the process of submitting an ASP.NET page to the server for processing. PostBack is done if certain credentials of the page are to be checked against some sources (such as verification of username and password using database). This is something that a client machine is not able to accomplish and thus these details have to be 'posted back' to the server.
            if (!Page.IsPostBack)
            {
                Session["MyEvents"] = new List<MyEvent>();
                // Session is an object property of the Page of the HttpSessionState class. ASP.NET provides session-state management to enable you to store information associated with a unique browser session across multiple requests. In this case, we are storing a new, empty List of MyEvent objects as "MyEvents" into the Session object so that we can access it later in the code.
                // Session state does not persist across ASP.NET application boundaries. If a browser navigates to another application, the session information is not available to the new application.
            }
        }

        protected void btnEvent_Click(object sender, EventArgs e)
        {
            UpdateEvents();
            BindEvents();
        }

        private void UpdateEvents()
        {
            if (Session["MyEvents"] != null)
            {
                myEvents = (List<MyEvent>)Session["MyEvents"];
                // casting this as a List of MyEvent objects
            }
            else
            {
                myEvents = new List<MyEvent>();
            }
            myEvents.Add(new MyEvent(txtEvent.Text, calendarEvents.SelectedDate));
            Session["MyEvents"] = myEvents;
        }

        private void BindEvents()
        {
            rptEvents.DataSource = myEvents;
            // Gets/Sets the data source that provides data for populating the list and returns an IEnumerable Collections or a List.
            rptEvents.DataBind();
            // Binds the Repeater control and all its child controls to the specified data source.
        }
    }

    public class MyEvent
    {
        public string EventName
        {
            get;
            private set;
        }
        public string EventDate
        {
            get;
            private set;
        }

        public MyEvent(string eventName, DateTime eventDate)
        {
            EventName = eventName;
            EventDate = eventDate.ToShortDateString();
        }
    }
}