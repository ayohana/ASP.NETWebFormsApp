<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MyWebApplication.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <%-- In order to use an HTML element in the server, make sure to add attributes runat="server and id="{yourIdName}" to the HTML element that you'd like to use in the server.--%>
    <div runat="server" id="divMessage" class="message"> Hey, you! Welcome to the Contact page! </div>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <h3>Tell us a little bit about yourself!</h3>
    <div>
        <label>Name</label>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="txtName" ErrorMessage="Name is Required" Display="Dynamic" />
        <%-- The RequiredFieldValidator control makes sure that the user enters a value into the text box before submission. --%>
    </div>
    <div>
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" />
        <%-- <asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="txtEmail" ValidationExpression="" ErrorMessage="Please enter a valid email address." Display="Dynamic" /> --%>
        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtEmail" ErrorMessage="Email Required" Display="Dynamic" />
    </div>
    <div>
        <label>Age</label>
        <asp:TextBox ID="txtAge" runat="server" />
        <asp:RequiredFieldValidator runat="server" ID="rvfAge" ControlToValidate="txtAge" ErrorMessage="Age Required" Display="Dynamic" />
    </div>
    <div>
        <label>Favorite Color</label>
        <asp:DropDownList ID="ddlColor" runat="server">
            <asp:ListItem Text="Select a color" Value="" />
            <asp:ListItem Text="Blue" Value="Blue" />
            <asp:ListItem Text="Red" Value="Red" />
            <asp:ListItem Text="Green" Value="Green" />
            <asp:ListItem Text="Yellow" Value="Yellow" />
        </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" ID="rvfColor" ControlToValidate="ddlColor" ErrorMessage="Please select a color." Display="Dynamic" />
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Info" OnClick="btnSubmit_Click"/>
    </div>
    <div class="message">
        <%-- Literal renders static text on a web page. It is similar to the Label control, except the Literal control does not allow you to apply a style to the displayed text. --%>
        <asp:Literal ID="ltMessage" runat="server" />
    </div>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
