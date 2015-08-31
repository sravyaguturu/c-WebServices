using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Top10Words
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ITop10Service
    {
        public String[] getTop10Words(String url)
        {
             HttpWebRequest myRequest ;
            // Gets the URL. It should be of the form http://www.webpage
            if (url.StartsWith("http://"))
            {
                myRequest = (HttpWebRequest)WebRequest.Create(url);               
            }
            else
            {
                 myRequest = (HttpWebRequest)WebRequest.Create("http://" + url);                             
            }
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string body = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();      
            // This regular expression is used to remove the html tags
            String regex = Regex.Replace(body, @"<[^>]*>", " ").Trim();
            String[] outputArray = regex.Split(' ');
            String[] newOutputArray = new String[outputArray.Length];

            // Considers only the alphabets and puts into a newArray
            for (int i = 0,j = 0; i < outputArray.Length; i++)
            {                
                if (Regex.IsMatch(outputArray[i], @"^[a-zA-Z]+$") && outputArray[i]!= null)
                {
                    newOutputArray[j++] = outputArray[i];
                }
            }

            //A Key value pair is maintained for each word and its count
            IDictionary<String, int> wordCount = new Dictionary<String, int>();           
            int cnt = 0;
            for (int i = 0; i < newOutputArray.Length; i++)
            {
                if (newOutputArray[i] != null)
                {
                    if (!wordCount.ContainsKey(newOutputArray[i]))
                    {
                        wordCount.Add(newOutputArray[i], 1); // For the first time , the count of the word is 1
                    }
                    else
                    {
                        cnt = wordCount[newOutputArray[i]];
                        wordCount[newOutputArray[i]] = cnt + 1; // Increments the count by 1 if the same word is found next time
                    }
                }
            }

            int k = 0;
            String[] result = new String[10];
            foreach (var item in wordCount.OrderByDescending(key => key.Value)) // The wordCount array which contains the words-count will be ordered in descending order                    
            {
                if (k < 10)
                {
                    result[k++] = item.Key + ":" + item.Value; // The output will be of the form word:count
                }
                else
                {
                    break;
                }
            }

            wordCount.Clear();
            return result;
            
        }
    }
}
