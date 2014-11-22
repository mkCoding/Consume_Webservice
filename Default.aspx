<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
       <!--Created 2 textboxes that take user input -->
        <h1>Add Numbers(CREATED WEBSERVICE)</h1>First Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       <br />
       Second Number:
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       <br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <!--this button calls the webservice which is triggered by onclick -->
       <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Add" 
           Width="67px" />
       <br />
       Result:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <h1> Weather (CONSUME EXTERNAL WEBSERVICE)</h1>
        Enter City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox>
        <br />
        Enter
        Country:
        <asp:TextBox ID="countryTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Get Weather" 
            onclick="Button2_Click" />
&nbsp;<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
       <br />
       <br />
       <br />
       <br />
       <br />
   
   
   
   </div>
</asp:Content>
