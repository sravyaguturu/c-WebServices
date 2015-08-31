using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace WordFilter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IWordFilter
    {      

        public String[] getWordFilter(String str)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://www.webconfs.com/stop-words.php"); // This url contains the stop words
            // Getting the stop words list from the url
            String result = Regex.Replace(downloadString, @"<[^>]*>", String.Empty);
            int fromIndex = result.IndexOf("able");
            int toIndex = result.IndexOf("zero");            
            result = result.Substring(fromIndex, toIndex - fromIndex).Replace('\n',' ');

            //Removes the html tags from the list
            String[] inputString = Regex.Replace(str, @"<[^>]*>",String.Empty).Split(' ');

            String[] filterWords = new String[inputString.Length];

            int k = 0;
            // Each input word is checked in the stopwords list or if the word is empty or word is digit or the word has special char
            foreach(String i in inputString){
                if (result.IndexOf(i, StringComparison.OrdinalIgnoreCase) >= 0 || i.Equals("") || Regex.IsMatch(i, @"[\%\/\\\&\?\,\'\;\:\!\-]+") || Regex.IsMatch(i,@"[0-9]+")) 
                {
                    continue; // If so continue
                }
                else
                {
                    filterWords[k++] = i; //Else store it in another array called filterwords
                }                                 
            }
            return filterWords;
        }
    }
}
