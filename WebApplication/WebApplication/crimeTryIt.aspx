<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crimeTryIt.aspx.cs" Inherits="WebApplications.WeatherServiceApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Crime Analysis :</strong><br />
        <br />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Enter ZipCode :"></asp:Label>
&nbsp;
        <asp:TextBox ID="zipcode" runat="server"></asp:TextBox>
    
    </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Crime Data" Width="100px" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
    <div id="CrimeData" runat="server">

    </div>

</body>
</html>
