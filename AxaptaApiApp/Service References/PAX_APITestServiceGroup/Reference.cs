﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxaptaApiApp.PAX_APITestServiceGroup {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CallContext", Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class CallContext : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogonAsUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartitionKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> PropertyBagField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogonAsUser {
            get {
                return this.LogonAsUserField;
            }
            set {
                if ((object.ReferenceEquals(this.LogonAsUserField, value) != true)) {
                    this.LogonAsUserField = value;
                    this.RaisePropertyChanged("LogonAsUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageId {
            get {
                return this.MessageIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIdField, value) != true)) {
                    this.MessageIdField = value;
                    this.RaisePropertyChanged("MessageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartitionKey {
            get {
                return this.PartitionKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PartitionKeyField, value) != true)) {
                    this.PartitionKeyField = value;
                    this.RaisePropertyChanged("PartitionKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> PropertyBag {
            get {
                return this.PropertyBagField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyBagField, value) != true)) {
                    this.PropertyBagField = value;
                    this.RaisePropertyChanged("PropertyBag");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class AifFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomDetailXmlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AxaptaApiApp.PAX_APITestServiceGroup.FaultMessageList[] FaultMessageListArrayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AxaptaApiApp.PAX_APITestServiceGroup.InfologMessage[] InfologMessageListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XppExceptionTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomDetailXml {
            get {
                return this.CustomDetailXmlField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomDetailXmlField, value) != true)) {
                    this.CustomDetailXmlField = value;
                    this.RaisePropertyChanged("CustomDetailXml");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AxaptaApiApp.PAX_APITestServiceGroup.FaultMessageList[] FaultMessageListArray {
            get {
                return this.FaultMessageListArrayField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageListArrayField, value) != true)) {
                    this.FaultMessageListArrayField = value;
                    this.RaisePropertyChanged("FaultMessageListArray");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AxaptaApiApp.PAX_APITestServiceGroup.InfologMessage[] InfologMessageList {
            get {
                return this.InfologMessageListField;
            }
            set {
                if ((object.ReferenceEquals(this.InfologMessageListField, value) != true)) {
                    this.InfologMessageListField = value;
                    this.RaisePropertyChanged("InfologMessageList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int XppExceptionType {
            get {
                return this.XppExceptionTypeField;
            }
            set {
                if ((this.XppExceptionTypeField.Equals(value) != true)) {
                    this.XppExceptionTypeField = value;
                    this.RaisePropertyChanged("XppExceptionType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessageList", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class FaultMessageList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentOperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AxaptaApiApp.PAX_APITestServiceGroup.FaultMessage[] FaultMessageArrayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceOperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceOperationParameterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlPositionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Document {
            get {
                return this.DocumentField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentField, value) != true)) {
                    this.DocumentField = value;
                    this.RaisePropertyChanged("Document");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentOperation {
            get {
                return this.DocumentOperationField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentOperationField, value) != true)) {
                    this.DocumentOperationField = value;
                    this.RaisePropertyChanged("DocumentOperation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AxaptaApiApp.PAX_APITestServiceGroup.FaultMessage[] FaultMessageArray {
            get {
                return this.FaultMessageArrayField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageArrayField, value) != true)) {
                    this.FaultMessageArrayField = value;
                    this.RaisePropertyChanged("FaultMessageArray");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Field {
            get {
                return this.FieldField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldField, value) != true)) {
                    this.FieldField = value;
                    this.RaisePropertyChanged("Field");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Service {
            get {
                return this.ServiceField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceField, value) != true)) {
                    this.ServiceField = value;
                    this.RaisePropertyChanged("Service");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperation {
            get {
                return this.ServiceOperationField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceOperationField, value) != true)) {
                    this.ServiceOperationField = value;
                    this.RaisePropertyChanged("ServiceOperation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperationParameter {
            get {
                return this.ServiceOperationParameterField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceOperationParameterField, value) != true)) {
                    this.ServiceOperationParameterField = value;
                    this.RaisePropertyChanged("ServiceOperationParameter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XPath {
            get {
                return this.XPathField;
            }
            set {
                if ((object.ReferenceEquals(this.XPathField, value) != true)) {
                    this.XPathField = value;
                    this.RaisePropertyChanged("XPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlLine {
            get {
                return this.XmlLineField;
            }
            set {
                if ((object.ReferenceEquals(this.XmlLineField, value) != true)) {
                    this.XmlLineField = value;
                    this.RaisePropertyChanged("XmlLine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlPosition {
            get {
                return this.XmlPositionField;
            }
            set {
                if ((object.ReferenceEquals(this.XmlPositionField, value) != true)) {
                    this.XmlPositionField = value;
                    this.RaisePropertyChanged("XmlPosition");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologMessage", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    [System.SerializableAttribute()]
    public partial class InfologMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AxaptaApiApp.PAX_APITestServiceGroup.InfologMessageType InfologMessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AxaptaApiApp.PAX_APITestServiceGroup.InfologMessageType InfologMessageType {
            get {
                return this.InfologMessageTypeField;
            }
            set {
                if ((this.InfologMessageTypeField.Equals(value) != true)) {
                    this.InfologMessageTypeField = value;
                    this.RaisePropertyChanged("InfologMessageType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessage", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class FaultMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologMessageType", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    public enum InfologMessageType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="PAX_APITestServiceGroup.PAX_APITestService")]
    public interface PAX_APITestService {
        
        // CODEGEN: Generating message contract since the wrapper name (PAX_APITestServiceTestConnectionRequest) of message PAX_APITestServiceTestConnectionRequest does not match the default value (testConnection)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PAX_APITestService/testConnection", ReplyAction="http://tempuri.org/PAX_APITestService/testConnectionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AxaptaApiApp.PAX_APITestServiceGroup.AifFault), Action="http://tempuri.org/PAX_APITestService/testConnectionAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionResponse testConnection(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PAX_APITestService/testConnection", ReplyAction="http://tempuri.org/PAX_APITestService/testConnectionResponse")]
        System.Threading.Tasks.Task<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionResponse> testConnectionAsync(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest request);
        
        // CODEGEN: Generating message contract since the wrapper name (PAX_APITestServiceJokeRequest) of message PAX_APITestServiceJokeRequest does not match the default value (joke)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PAX_APITestService/joke", ReplyAction="http://tempuri.org/PAX_APITestService/jokeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AxaptaApiApp.PAX_APITestServiceGroup.AifFault), Action="http://tempuri.org/PAX_APITestService/jokeAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeResponse joke(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PAX_APITestService/joke", ReplyAction="http://tempuri.org/PAX_APITestService/jokeResponse")]
        System.Threading.Tasks.Task<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeResponse> jokeAsync(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PAX_APITestServiceTestConnectionRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PAX_APITestServiceTestConnectionRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
        public AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext;
        
        public PAX_APITestServiceTestConnectionRequest() {
        }
        
        public PAX_APITestServiceTestConnectionRequest(AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext) {
            this.CallContext = CallContext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PAX_APITestServiceTestConnectionResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PAX_APITestServiceTestConnectionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string response;
        
        public PAX_APITestServiceTestConnectionResponse() {
        }
        
        public PAX_APITestServiceTestConnectionResponse(string response) {
            this.response = response;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PAX_APITestServiceJokeRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PAX_APITestServiceJokeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
        public AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string _a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=1)]
        public string _b;
        
        public PAX_APITestServiceJokeRequest() {
        }
        
        public PAX_APITestServiceJokeRequest(AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext, string _a, string _b) {
            this.CallContext = CallContext;
            this._a = _a;
            this._b = _b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PAX_APITestServiceJokeResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class PAX_APITestServiceJokeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public string response;
        
        public PAX_APITestServiceJokeResponse() {
        }
        
        public PAX_APITestServiceJokeResponse(string response) {
            this.response = response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PAX_APITestServiceChannel : AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PAX_APITestServiceClient : System.ServiceModel.ClientBase<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService>, AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService {
        
        public PAX_APITestServiceClient() {
        }
        
        public PAX_APITestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PAX_APITestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PAX_APITestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PAX_APITestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionResponse AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService.testConnection(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest request) {
            return base.Channel.testConnection(request);
        }
        
        public string testConnection(AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext) {
            AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest inValue = new AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest();
            inValue.CallContext = CallContext;
            AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionResponse retVal = ((AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService)(this)).testConnection(inValue);
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionResponse> AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService.testConnectionAsync(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest request) {
            return base.Channel.testConnectionAsync(request);
        }
        
        public System.Threading.Tasks.Task<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionResponse> testConnectionAsync(AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext) {
            AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest inValue = new AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceTestConnectionRequest();
            inValue.CallContext = CallContext;
            return ((AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService)(this)).testConnectionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeResponse AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService.joke(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest request) {
            return base.Channel.joke(request);
        }
        
        public string joke(AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext, string _a, string _b) {
            AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest inValue = new AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest();
            inValue.CallContext = CallContext;
            inValue._a = _a;
            inValue._b = _b;
            AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeResponse retVal = ((AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService)(this)).joke(inValue);
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeResponse> AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService.jokeAsync(AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest request) {
            return base.Channel.jokeAsync(request);
        }
        
        public System.Threading.Tasks.Task<AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeResponse> jokeAsync(AxaptaApiApp.PAX_APITestServiceGroup.CallContext CallContext, string _a, string _b) {
            AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest inValue = new AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestServiceJokeRequest();
            inValue.CallContext = CallContext;
            inValue._a = _a;
            inValue._b = _b;
            return ((AxaptaApiApp.PAX_APITestServiceGroup.PAX_APITestService)(this)).jokeAsync(inValue);
        }
    }
}
