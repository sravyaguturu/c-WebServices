using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace WeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IWeather
    {
        public IDictionary<String, String> getLatLong(String zipCode)
        {
            XmlDataDocument doc = new XmlDataDocument();    
            List<String> data = new List<String>();
            String url = "http://maps.googleapis.com/maps/api/geocode/xml?address=" + zipCode;
            doc.Load(url);

            XmlNodeList status = doc.GetElementsByTagName("status");
            String res_status = status[0].InnerText;
            if (!res_status.Equals("OK"))
            {
                data.Add("No Result");                
            }

            XmlNodeList result = doc.GetElementsByTagName("result");
            XmlNodeList list = null,location = null;

            String latitude = null, longitude = null;

            for (int i = 0; i < result.Count; i++)
            {
                list = doc.GetElementsByTagName("geometry");
            }
            for (int i = 0; i < list.Count; i++)
            {
                location = doc.GetElementsByTagName("location");
            }

            latitude = location[0].SelectSingleNode("lat").InnerText;
            longitude = location[0].SelectSingleNode("lng").InnerText;             
            return  getWeatherData(latitude,longitude);                            
        }
        public IDictionary<String, String> getWeatherData(String lat, String lon)
        {
            XmlDataDocument doc = new XmlDataDocument();
            IDictionary<String, String> data = new Dictionary<String, String>();
            String url ="http://api.openweathermap.org/data/2.5/forecast/daily?lat=" + lat + "&lon=" + lon + "&cnt=5&mode=xml";
            doc.Load(url);

            XmlNodeList locationList = doc.GetElementsByTagName("location");
            XmlNodeList foreCastList = doc.GetElementsByTagName("time");

            data["City"] = locationList[0].SelectSingleNode("name").InnerText;
            data["Country"] = locationList[0].SelectSingleNode("country").InnerText;

            String temperature,wind,clouds;

            for (int i = 0; i < 5; i++)
            {
                temperature = "Temperature : Morn = " + foreCastList[i].SelectSingleNode("temperature").Attributes["morn"].Value +
                            ",Evening = " + foreCastList[i].SelectSingleNode("temperature").Attributes["eve"].Value + ",Night = " + foreCastList[i].SelectSingleNode("temperature").Attributes["night"].Value;
                wind = "Wind : " + foreCastList[i].SelectSingleNode("windSpeed").Attributes["name"].Value;
                clouds = "Clouds : " + foreCastList[i].SelectSingleNode("clouds").Attributes["value"].Value;

                data[foreCastList[i].Attributes["day"].Value] = temperature + " | " + wind + " | " + clouds;
            }
            return data;
        }
    }
}
