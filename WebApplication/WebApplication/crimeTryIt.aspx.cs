using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class WeatherServiceApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CrimeReference.CrimeClient c = new CrimeReference.CrimeClient();        
            IDictionary<String, String> crimeData = new Dictionary<String, String>();
            crimeData = c.getCrimeData(zipcode.Text);
            
            string data = "<br/><h2>Crime Analysis</h2>";

            data += "<table cellspacing='10' cellpadding='5' border='1'>";

            foreach (KeyValuePair<String, String> entry in crimeData)
            {
                CrimeData.InnerHtml = "";

                if(entry.Key == "City"){
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }
                if (entry.Key == "ViolentCrime")
                {
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }

                 if (entry.Key == "MurderAndManslaughter")
                {
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }

                 if (entry.Key == "Robbery")
                {
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }

                 if (entry.Key == "AggravatedAssault")
                {
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }

                 if (entry.Key == "Burglary")
                {
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }

                 if (entry.Key == "MotorVehicleTheft")
                {
                    data += "<tr>";
                    data += "<td><b>" + entry.Key + "</b></td><td>" + entry.Value + "</td>";
                    data += "</tr>";
                }                       
            }

            data += "</table>";
            CrimeData.InnerHtml = data;
        }
    }
}