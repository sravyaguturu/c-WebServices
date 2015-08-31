<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplications.MainPage" %>

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
            <td><b>Weather Service</b><br />
                <b>Input:</b> ZipCode <br />
                <b>Output:</b> Weather Forecast for five days of that zipCode
            </td>
            <td><a href="http://localhost:10368/weatherTryIt">Weather Forecast Try It</a></td>
            <td>Weather Service will get the zipcode entered fetch the latitude and longitude of that zipcode.
                Outputs the weather forecast for five days
            </td>
            <td><a href ="http://maps.googleapis.com/maps/api/geocode/xml?address=85281">http://maps.googleapis.com/maps/api/geocode/xml?address=85281</a> 
               <a href ="http://developer.nrel.gov/api/solar/solar_resource/v1.xml?api_key=DEMO_KEY&lat33=&lon=-111">http://developer.nrel.gov/api/solar/solar_resource/v1.xml?api_key=DEMO_KEY&lat33=&lon=-111</a>
           
            </td>

        </tr>
         <tr>
            <td>Sai Sravya Guturu</td>
            <td><b>Crime Data</b><br />
                <b>Input:</b> ZipCode <br />
                <b>Output:</b> Crime data for that zipCode
            </td>
            <td><a href="http://localhost:10368/crimeTryIt">Crime Data Try It</a></td>
            <td>Crime Service will get the zipcode entered fetch the number of crime happening
                in that area.
            </td>
            <td><a href ="https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=85281">https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=85281</a></td>
        </tr>                
    </table>
    </div>
    </form>
</body>
</html>
