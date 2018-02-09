﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIS_lab5.OurEnegryService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Energys", Namespace="http://tempuri.org/")]
    public enum Energys : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        joule = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        kilojoule = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        megajoule = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gigajoule = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        calorie = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        watthour = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        electronvolt = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        footpound = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OurEnegryService.OurEnergyServiceSoap")]
    public interface OurEnergyServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeEnergyUnit", ReplyAction="*")]
        double ChangeEnergyUnit(double value, AIS_lab5.OurEnegryService.Energys from, AIS_lab5.OurEnegryService.Energys to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeEnergyUnit", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ChangeEnergyUnitAsync(double value, AIS_lab5.OurEnegryService.Energys from, AIS_lab5.OurEnegryService.Energys to);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OurEnergyServiceSoapChannel : AIS_lab5.OurEnegryService.OurEnergyServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OurEnergyServiceSoapClient : System.ServiceModel.ClientBase<AIS_lab5.OurEnegryService.OurEnergyServiceSoap>, AIS_lab5.OurEnegryService.OurEnergyServiceSoap {
        
        public OurEnergyServiceSoapClient() {
        }
        
        public OurEnergyServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OurEnergyServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OurEnergyServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OurEnergyServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ChangeEnergyUnit(double value, AIS_lab5.OurEnegryService.Energys from, AIS_lab5.OurEnegryService.Energys to) {
            return base.Channel.ChangeEnergyUnit(value, from, to);
        }
        
        public System.Threading.Tasks.Task<double> ChangeEnergyUnitAsync(double value, AIS_lab5.OurEnegryService.Energys from, AIS_lab5.OurEnegryService.Energys to) {
            return base.Channel.ChangeEnergyUnitAsync(value, from, to);
        }
    }
}