﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFReferenceServiceClient.WCFRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PLCDataPacketConfiguration", Namespace="http://schemas.datacontract.org/2004/07/WCFReferenceService")]
    [System.SerializableAttribute()]
    public partial class PLCDataPacketConfiguration : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFReferenceServiceClient.WCFRef.DataByte[] BytesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsDecoderField;
        
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
        public WCFReferenceServiceClient.WCFRef.DataByte[] Bytes {
            get {
                return this.BytesField;
            }
            set {
                if ((object.ReferenceEquals(this.BytesField, value) != true)) {
                    this.BytesField = value;
                    this.RaisePropertyChanged("Bytes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDecoder {
            get {
                return this.IsDecoderField;
            }
            set {
                if ((this.IsDecoderField.Equals(value) != true)) {
                    this.IsDecoderField = value;
                    this.RaisePropertyChanged("IsDecoder");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataByte", Namespace="http://schemas.datacontract.org/2004/07/WCFReferenceService")]
    [System.SerializableAttribute()]
    public partial class DataByte : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFReferenceServiceClient.WCFRef.DataBit[] BitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ByteIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ContainsBitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsHeaderOrFooterField;
        
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
        public WCFReferenceServiceClient.WCFRef.DataBit[] Bits {
            get {
                return this.BitsField;
            }
            set {
                if ((object.ReferenceEquals(this.BitsField, value) != true)) {
                    this.BitsField = value;
                    this.RaisePropertyChanged("Bits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ByteIndex {
            get {
                return this.ByteIndexField;
            }
            set {
                if ((this.ByteIndexField.Equals(value) != true)) {
                    this.ByteIndexField = value;
                    this.RaisePropertyChanged("ByteIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ContainsBits {
            get {
                return this.ContainsBitsField;
            }
            set {
                if ((this.ContainsBitsField.Equals(value) != true)) {
                    this.ContainsBitsField = value;
                    this.RaisePropertyChanged("ContainsBits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsHeaderOrFooter {
            get {
                return this.IsHeaderOrFooterField;
            }
            set {
                if ((this.IsHeaderOrFooterField.Equals(value) != true)) {
                    this.IsHeaderOrFooterField = value;
                    this.RaisePropertyChanged("IsHeaderOrFooter");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataBit", Namespace="http://schemas.datacontract.org/2004/07/WCFReferenceService")]
    [System.SerializableAttribute()]
    public partial class DataBit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] AGVTagsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BitIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
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
        public int[] AGVTags {
            get {
                return this.AGVTagsField;
            }
            set {
                if ((object.ReferenceEquals(this.AGVTagsField, value) != true)) {
                    this.AGVTagsField = value;
                    this.RaisePropertyChanged("AGVTags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BitIndex {
            get {
                return this.BitIndexField;
            }
            set {
                if ((this.BitIndexField.Equals(value) != true)) {
                    this.BitIndexField = value;
                    this.RaisePropertyChanged("BitIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFRef.IPLCDataServiceContract")]
    public interface IPLCDataServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPLCDataServiceContract/StorePLCDataPacketConfiguration", ReplyAction="http://tempuri.org/IPLCDataServiceContract/StorePLCDataPacketConfigurationRespons" +
            "e")]
        bool StorePLCDataPacketConfiguration(WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration PLCPacket, string configurationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPLCDataServiceContract/StorePLCDataPacketConfiguration", ReplyAction="http://tempuri.org/IPLCDataServiceContract/StorePLCDataPacketConfigurationRespons" +
            "e")]
        System.Threading.Tasks.Task<bool> StorePLCDataPacketConfigurationAsync(WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration PLCPacket, string configurationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPLCDataServiceContract/GetPLCDataPacketConfiguration", ReplyAction="http://tempuri.org/IPLCDataServiceContract/GetPLCDataPacketConfigurationResponse")]
        WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration GetPLCDataPacketConfiguration(string configurationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPLCDataServiceContract/GetPLCDataPacketConfiguration", ReplyAction="http://tempuri.org/IPLCDataServiceContract/GetPLCDataPacketConfigurationResponse")]
        System.Threading.Tasks.Task<WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration> GetPLCDataPacketConfigurationAsync(string configurationName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPLCDataServiceContractChannel : WCFReferenceServiceClient.WCFRef.IPLCDataServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PLCDataServiceContractClient : System.ServiceModel.ClientBase<WCFReferenceServiceClient.WCFRef.IPLCDataServiceContract>, WCFReferenceServiceClient.WCFRef.IPLCDataServiceContract {
        
        public PLCDataServiceContractClient() {
        }
        
        public PLCDataServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PLCDataServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PLCDataServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PLCDataServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool StorePLCDataPacketConfiguration(WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration PLCPacket, string configurationName) {
            return base.Channel.StorePLCDataPacketConfiguration(PLCPacket, configurationName);
        }
        
        public System.Threading.Tasks.Task<bool> StorePLCDataPacketConfigurationAsync(WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration PLCPacket, string configurationName) {
            return base.Channel.StorePLCDataPacketConfigurationAsync(PLCPacket, configurationName);
        }
        
        public WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration GetPLCDataPacketConfiguration(string configurationName) {
            return base.Channel.GetPLCDataPacketConfiguration(configurationName);
        }
        
        public System.Threading.Tasks.Task<WCFReferenceServiceClient.WCFRef.PLCDataPacketConfiguration> GetPLCDataPacketConfigurationAsync(string configurationName) {
            return base.Channel.GetPLCDataPacketConfigurationAsync(configurationName);
        }
    }
}
