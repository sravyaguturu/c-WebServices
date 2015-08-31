﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Top10Words
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITop10Service
    {        
        [OperationContract]         
        [WebGet(ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getTop10Words?url={url}")]             // define input format
        String[] getTop10Words(String url); 
    }
}
