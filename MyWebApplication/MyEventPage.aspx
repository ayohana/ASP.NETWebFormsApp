<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyEventPage.aspx.cs" Inherits="MyWebApplication.MyEventPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Advanced ASP.NET Web Server Controls</h2>
    <h3>Create a list of events in a repeater from a calendar control.</h3>
    <div class="form-group">
        <label>Event Name:</label>
        <asp:TextBox ID="txtEvent" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label>Event Date:</label>
        <asp:Calendar ID="calendarEvents" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnEvent" runat="server" CssClass="btn btn-primary btn-large" Text="Add Event" OnClick="btnEvent_Click"/>
    </div>

    <h3>Events Repeater</h3>
    <div>
        <%-- Declare this div as a Repeater with the ID name "rptEvents" and an attribute runat="server" so that we can use it in the CodeBehind. --%>
        <asp:Repeater ID="rptEvents" runat="server">
            <ItemTemplate>
                <h3><%# DataBinder.Eval(Container.DataItem, "EventDate") %><small><%# DataBinder.Eval(Container.DataItem, "EventName") %></small></h3>
                <%-- DataBinder.Eval(Object, String) evaluates data-binding expressions at run time and returns an object instance that results from the evaluation of the data-binding expression. --%>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
