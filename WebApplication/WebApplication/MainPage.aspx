<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplication.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table border="1">
        <tr>
            <th>Provider Name</th>
            <th>Service Name , Inputs , Outputs</th>
            <th>Try It</th>
            <th>Service Description</th>
            <th>API's</th>
        </tr>
        <tr>
            <td>Sai Sravya Guturu</td>
            <td><b>Top 10 Words</b><br />
                <b>Input:</b> URL <br />
                <b>Output:</b> Top 10 words from the content of the web page
            </td>
            <td><a href="http://localhost:3848/Top10WordsTryIt.aspx">Top 10 Words Try It</a></td>
            <td>This service will take the url as input and parse the web page content
                and finds out the top 10 words and print them in the descending order
            </td>
            <td>
                No API's are used.
            </td>

        </tr>
         <tr>
            <td>Sai Sravya Guturu</td>
            <td><b>Word Filter</b><br />
                <b>Input:</b> String <br />
                <b>Output:</b> String with stop words and html tags removed
            </td>
            <td><a href="http://localhost:3848/WordFilterTryIt.aspx">Word Filter Try It</a></td>
            <td>A String is taken as input and is removed from html tags and stop words and the remaining string is returned.
            </td>
            <td>No API's used. Used this site to get the stop words
                <a href ="http://www.webconfs.com/stop-words.php">http://www.webconfs.com/stop-words.php</a></td>
        </tr>                
    </table>
    </div>
    </form>
</body>
</html>
