<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WordFilterTryIt.aspx.cs" Inherits="WebApplication.WordFilter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Word Filter :<br />
        <br />
    
        Enter the String :
        <asp:TextBox ID="str" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Remove the stop words" OnClick="Button1_Click" />
    
        <br />
        <br />
        The String after removing Stop words and HTML tags is :</div>
    </form>
    <div id="stopwords" runat="server">

        <br />

    </div>
</body>
</html>
