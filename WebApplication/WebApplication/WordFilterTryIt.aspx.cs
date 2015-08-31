using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WordFilter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WordFilterServiceReference.WordFilterClient w = new WordFilterServiceReference.WordFilterClient();            
            String[] result = w.getWordFilter(Convert.ToString(str.Text));
            stopwords.InnerHtml = " ";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    stopwords.InnerHtml += result[i] + "\n";
                }
            }
        }
    }
}