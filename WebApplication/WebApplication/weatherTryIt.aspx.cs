using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class weatherTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WeatherData.InnerHtml = "";

            String zip = zipCode.Text;
            WeatherServiceReference.WeatherClient ws = new WeatherServiceReference.WeatherClient();
         

            IDictionary<String, String> foreCast = new Dictionary<String, String>();
            foreCast = ws.getLatLong(zip);

            string data = "<br/><h2>Forecast</h2>";

            data += "<table cellspacing='10' cellpadding='5'>";
            foreach (KeyValuePair<string, string> entry in foreCast)
            {
                data += "<tr>";
                data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                data += "</tr>";
            }

            data += "</table>";
            WeatherData.InnerHtml = data;
        }
    }
}