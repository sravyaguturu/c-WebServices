﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.WordFilterServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WordFilterServiceReference.IWordFilter")]
    public interface IWordFilter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordFilter/getWordFilter", ReplyAction="http://tempuri.org/IWordFilter/getWordFilterResponse")]
        string[] getWordFilter(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordFilter/getWordFilter", ReplyAction="http://tempuri.org/IWordFilter/getWordFilterResponse")]
        System.Threading.Tasks.Task<string[]> getWordFilterAsync(string str);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWordFilterChannel : WebApplication.WordFilterServiceReference.IWordFilter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WordFilterClient : System.ServiceModel.ClientBase<WebApplication.WordFilterServiceReference.IWordFilter>, WebApplication.WordFilterServiceReference.IWordFilter {
        
        public WordFilterClient() {
        }
        
        public WordFilterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WordFilterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WordFilterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WordFilterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getWordFilter(string str) {
            return base.Channel.getWordFilter(str);
        }
        
        public System.Threading.Tasks.Task<string[]> getWordFilterAsync(string str) {
            return base.Channel.getWordFilterAsync(str);
        }
    }
}