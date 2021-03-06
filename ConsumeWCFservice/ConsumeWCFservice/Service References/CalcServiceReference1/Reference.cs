﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeWCFservice.CalcServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcServiceReference1.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/AddNumbers", ReplyAction="http://tempuri.org/ICalculator/AddNumbersResponse")]
        double AddNumbers(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/SubtractNumbers", ReplyAction="http://tempuri.org/ICalculator/SubtractNumbersResponse")]
        double SubtractNumbers(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/MultiplyNumbers", ReplyAction="http://tempuri.org/ICalculator/MultiplyNumbersResponse")]
        double MultiplyNumbers(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/DivideNumbers", ReplyAction="http://tempuri.org/ICalculator/DivideNumbersResponse")]
        double DivideNumbers(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ConsumeWCFservice.CalcServiceReference1.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<ConsumeWCFservice.CalcServiceReference1.ICalculator>, ConsumeWCFservice.CalcServiceReference1.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double AddNumbers(double num1, double num2) {
            return base.Channel.AddNumbers(num1, num2);
        }
        
        public double SubtractNumbers(double num1, double num2) {
            return base.Channel.SubtractNumbers(num1, num2);
        }
        
        public double MultiplyNumbers(double num1, double num2) {
            return base.Channel.MultiplyNumbers(num1, num2);
        }
        
        public double DivideNumbers(double num1, double num2) {
            return base.Channel.DivideNumbers(num1, num2);
        }
    }
}
