﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ConvertoWords {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConvertoWords.IConvertNumberToWords")]
    public interface IConvertNumberToWords {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertNumberToWords/ConvertToWords", ReplyAction="http://tempuri.org/IConvertNumberToWords/ConvertToWordsResponse")]
        string ConvertToWords(double Number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertNumberToWords/ConvertToWords", ReplyAction="http://tempuri.org/IConvertNumberToWords/ConvertToWordsResponse")]
        System.Threading.Tasks.Task<string> ConvertToWordsAsync(double Number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConvertNumberToWordsChannel : Client.ConvertoWords.IConvertNumberToWords, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConvertNumberToWordsClient : System.ServiceModel.ClientBase<Client.ConvertoWords.IConvertNumberToWords>, Client.ConvertoWords.IConvertNumberToWords {
        
        public ConvertNumberToWordsClient() {
        }
        
        public ConvertNumberToWordsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConvertNumberToWordsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertNumberToWordsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertNumberToWordsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ConvertToWords(double Number) {
            return base.Channel.ConvertToWords(Number);
        }
        
        public System.Threading.Tasks.Task<string> ConvertToWordsAsync(double Number) {
            return base.Channel.ConvertToWordsAsync(Number);
        }
    }
}
