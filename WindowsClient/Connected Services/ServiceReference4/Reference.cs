﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsClient.ServiceReference4 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Building", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Building : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Office", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Office : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OfficeNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BuildingAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VentilationSettingField;
        
        private int TemperatureSettingField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string OfficeNumber {
            get {
                return this.OfficeNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.OfficeNumberField, value) != true)) {
                    this.OfficeNumberField = value;
                    this.RaisePropertyChanged("OfficeNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string BuildingAddress {
            get {
                return this.BuildingAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.BuildingAddressField, value) != true)) {
                    this.BuildingAddressField = value;
                    this.RaisePropertyChanged("BuildingAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string VentilationSetting {
            get {
                return this.VentilationSettingField;
            }
            set {
                if ((object.ReferenceEquals(this.VentilationSettingField, value) != true)) {
                    this.VentilationSettingField = value;
                    this.RaisePropertyChanged("VentilationSetting");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int TemperatureSetting {
            get {
                return this.TemperatureSettingField;
            }
            set {
                if ((this.TemperatureSettingField.Equals(value) != true)) {
                    this.TemperatureSettingField = value;
                    this.RaisePropertyChanged("TemperatureSetting");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference4.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name ShowBuildingsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowBuildings", ReplyAction="*")]
        WindowsClient.ServiceReference4.ShowBuildingsResponse ShowBuildings(WindowsClient.ServiceReference4.ShowBuildingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowBuildings", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsClient.ServiceReference4.ShowBuildingsResponse> ShowBuildingsAsync(WindowsClient.ServiceReference4.ShowBuildingsRequest request);
        
        // CODEGEN: Generating message contract since element name ShowOfficesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowOffices", ReplyAction="*")]
        WindowsClient.ServiceReference4.ShowOfficesResponse ShowOffices(WindowsClient.ServiceReference4.ShowOfficesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowOffices", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsClient.ServiceReference4.ShowOfficesResponse> ShowOfficesAsync(WindowsClient.ServiceReference4.ShowOfficesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowBuildingsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowBuildings", Namespace="http://tempuri.org/", Order=0)]
        public WindowsClient.ServiceReference4.ShowBuildingsRequestBody Body;
        
        public ShowBuildingsRequest() {
        }
        
        public ShowBuildingsRequest(WindowsClient.ServiceReference4.ShowBuildingsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ShowBuildingsRequestBody {
        
        public ShowBuildingsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowBuildingsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowBuildingsResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsClient.ServiceReference4.ShowBuildingsResponseBody Body;
        
        public ShowBuildingsResponse() {
        }
        
        public ShowBuildingsResponse(WindowsClient.ServiceReference4.ShowBuildingsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ShowBuildingsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsClient.ServiceReference4.Building[] ShowBuildingsResult;
        
        public ShowBuildingsResponseBody() {
        }
        
        public ShowBuildingsResponseBody(WindowsClient.ServiceReference4.Building[] ShowBuildingsResult) {
            this.ShowBuildingsResult = ShowBuildingsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowOfficesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowOffices", Namespace="http://tempuri.org/", Order=0)]
        public WindowsClient.ServiceReference4.ShowOfficesRequestBody Body;
        
        public ShowOfficesRequest() {
        }
        
        public ShowOfficesRequest(WindowsClient.ServiceReference4.ShowOfficesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ShowOfficesRequestBody {
        
        public ShowOfficesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowOfficesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowOfficesResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsClient.ServiceReference4.ShowOfficesResponseBody Body;
        
        public ShowOfficesResponse() {
        }
        
        public ShowOfficesResponse(WindowsClient.ServiceReference4.ShowOfficesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ShowOfficesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsClient.ServiceReference4.Office[] ShowOfficesResult;
        
        public ShowOfficesResponseBody() {
        }
        
        public ShowOfficesResponseBody(WindowsClient.ServiceReference4.Office[] ShowOfficesResult) {
            this.ShowOfficesResult = ShowOfficesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsClient.ServiceReference4.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsClient.ServiceReference4.WebService1Soap>, WindowsClient.ServiceReference4.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsClient.ServiceReference4.ShowBuildingsResponse WindowsClient.ServiceReference4.WebService1Soap.ShowBuildings(WindowsClient.ServiceReference4.ShowBuildingsRequest request) {
            return base.Channel.ShowBuildings(request);
        }
        
        public WindowsClient.ServiceReference4.Building[] ShowBuildings() {
            WindowsClient.ServiceReference4.ShowBuildingsRequest inValue = new WindowsClient.ServiceReference4.ShowBuildingsRequest();
            inValue.Body = new WindowsClient.ServiceReference4.ShowBuildingsRequestBody();
            WindowsClient.ServiceReference4.ShowBuildingsResponse retVal = ((WindowsClient.ServiceReference4.WebService1Soap)(this)).ShowBuildings(inValue);
            return retVal.Body.ShowBuildingsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsClient.ServiceReference4.ShowBuildingsResponse> WindowsClient.ServiceReference4.WebService1Soap.ShowBuildingsAsync(WindowsClient.ServiceReference4.ShowBuildingsRequest request) {
            return base.Channel.ShowBuildingsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsClient.ServiceReference4.ShowBuildingsResponse> ShowBuildingsAsync() {
            WindowsClient.ServiceReference4.ShowBuildingsRequest inValue = new WindowsClient.ServiceReference4.ShowBuildingsRequest();
            inValue.Body = new WindowsClient.ServiceReference4.ShowBuildingsRequestBody();
            return ((WindowsClient.ServiceReference4.WebService1Soap)(this)).ShowBuildingsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsClient.ServiceReference4.ShowOfficesResponse WindowsClient.ServiceReference4.WebService1Soap.ShowOffices(WindowsClient.ServiceReference4.ShowOfficesRequest request) {
            return base.Channel.ShowOffices(request);
        }
        
        public WindowsClient.ServiceReference4.Office[] ShowOffices() {
            WindowsClient.ServiceReference4.ShowOfficesRequest inValue = new WindowsClient.ServiceReference4.ShowOfficesRequest();
            inValue.Body = new WindowsClient.ServiceReference4.ShowOfficesRequestBody();
            WindowsClient.ServiceReference4.ShowOfficesResponse retVal = ((WindowsClient.ServiceReference4.WebService1Soap)(this)).ShowOffices(inValue);
            return retVal.Body.ShowOfficesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsClient.ServiceReference4.ShowOfficesResponse> WindowsClient.ServiceReference4.WebService1Soap.ShowOfficesAsync(WindowsClient.ServiceReference4.ShowOfficesRequest request) {
            return base.Channel.ShowOfficesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsClient.ServiceReference4.ShowOfficesResponse> ShowOfficesAsync() {
            WindowsClient.ServiceReference4.ShowOfficesRequest inValue = new WindowsClient.ServiceReference4.ShowOfficesRequest();
            inValue.Body = new WindowsClient.ServiceReference4.ShowOfficesRequestBody();
            return ((WindowsClient.ServiceReference4.WebService1Soap)(this)).ShowOfficesAsync(inValue);
        }
    }
}
