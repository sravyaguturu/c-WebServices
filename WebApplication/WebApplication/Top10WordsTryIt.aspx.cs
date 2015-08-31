using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;


namespace WebApplication
{
    public partial class Top10words : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url1 = @"http://localhost:23106/Top10Service.svc/getTop10Words?url=" + url.Text.ToString();

            try
            {
                Task<string> result = client.GetStringAsync(url1);

                string x = await result;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(x);               
                XmlNodeList elementList = doc.GetElementsByTagName("ArrayOfstring");
                XmlNode root = elementList[0];
                topWords.InnerHtml = "";
                //Display the contents of the child nodes. 
                if (root.HasChildNodes)
                {
                    string data = "<br/><h2>Top 10 Words</h2>";

                    data += "<table cellspacing='10' cellpadding='5' border='1'>";
                    for (int i = 0; i < root.ChildNodes.Count; i++)
                    {
                        data += "<tr>";
                        data += "<td><b>" + root.ChildNodes[i].InnerText + "</b></td>";
                        data += "</tr>";                       
                    }
                    data += "</table>";
                    topWords.InnerHtml = data;
                }                            
            }
            catch (Exception ex)
            {
                topWords.InnerHtml = ex.Message;
            }           
        }
    }
}