﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.IWeatherService")]
    public interface IWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetCurrentWeather", ReplyAction="http://tempuri.org/IWeatherService/GetCurrentWeatherResponse")]
        string GetCurrentWeather();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetCurrentWeather", ReplyAction="http://tempuri.org/IWeatherService/GetCurrentWeatherResponse")]
        System.Threading.Tasks.Task<string> GetCurrentWeatherAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : ConsoleApplication1.WeatherService.IWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<ConsoleApplication1.WeatherService.IWeatherService>, ConsoleApplication1.WeatherService.IWeatherService {
        
        public WeatherServiceClient() {
        }
        
        public WeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCurrentWeather() {
            return base.Channel.GetCurrentWeather();
        }
        
        public System.Threading.Tasks.Task<string> GetCurrentWeatherAsync() {
            return base.Channel.GetCurrentWeatherAsync();
        }
    }
}
