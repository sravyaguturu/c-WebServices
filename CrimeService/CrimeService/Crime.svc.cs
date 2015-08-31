using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace CrimeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICrime
    {
      /*  public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/

        public IDictionary<string, string> getCrimeData(String zipCode)
        {
            XmlDataDocument doc = new XmlDataDocument();
            IDictionary<String, String> data = new Dictionary<String, String>();
            String url = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=" + zipCode ;
            doc.Load(url);
            
            XmlNodeList elementList = doc.GetElementsByTagName("element");
            XmlNode root = elementList[0];
            //Display the contents of the child nodes. 
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    data.Add(root.ChildNodes[i].Name,root.ChildNodes[i].InnerText);
                }
            }
                
            return data;
        }
    }
}
