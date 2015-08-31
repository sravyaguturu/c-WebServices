<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weatherTryIt.aspx.cs" Inherits="WebApplications.weatherTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Weather Updates :</strong><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter ZipCode:"></asp:Label>
&nbsp;
        <asp:TextBox ID="zipCode" runat="server"></asp:TextBox>
    
    </div>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Get Forecast" OnClick="Button1_Click" />
    </form>
     <div id="WeatherData" runat="server">

    </div>
</body>
</html>
