<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top10WordsTryIt.aspx.cs" Inherits="WebApplication.Top10words" Async ="true" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Top 10 words :<br />
        <br />
    
        Enter the URL :
        <asp:TextBox ID="url" runat="server" Width="149px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Top 10 Words" />
        <br />
    
    </div>
        The Top 10 words from the URL are :<br />
        <br />        
        <br />
    </form>   
    <div id="topWords" runat="server">

    </div>

</body>
</html>
