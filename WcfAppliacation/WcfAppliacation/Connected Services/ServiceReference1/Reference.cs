﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfAppliacation.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FeedbackInfomation", Namespace="http://schemas.datacontract.org/2004/07/StockCommon")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfAppliacation.ServiceReference1.STATUS_ADAPTER))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfAppliacation.ServiceReference1.Sku))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfAppliacation.ServiceReference1.BillType))]
    public partial class FeedbackInfomation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfAppliacation.ServiceReference1.STATUS_ADAPTER ErrorStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FeedbackMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ResultField;
        
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
        public WcfAppliacation.ServiceReference1.STATUS_ADAPTER ErrorStatus {
            get {
                return this.ErrorStatusField;
            }
            set {
                if ((this.ErrorStatusField.Equals(value) != true)) {
                    this.ErrorStatusField = value;
                    this.RaisePropertyChanged("ErrorStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FeedbackMessage {
            get {
                return this.FeedbackMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FeedbackMessageField, value) != true)) {
                    this.FeedbackMessageField = value;
                    this.RaisePropertyChanged("FeedbackMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="STATUS_ADAPTER", Namespace="http://schemas.datacontract.org/2004/07/StockCommon")]
    public enum STATUS_ADAPTER : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DB_CONNECT_NORMAL = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DB_CONNECT_FAILD = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DB_ERROR = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IP_NORMAL = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IP_EMPTY = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IP_FORMAT = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QUERY_NORMAL = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QUERY_ERROR = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INSERT_NORMAL = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INSERT_ERROR = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SAVE_SUCCESS = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SAVE_FAILED = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DEl_SUCCESS = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DEL_FAILED = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QUERY_NODATA = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CHECK_SUCCESS = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CHECK_FAILED = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CANCEL_CHECK_SUCCESS = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CANCEL_CHECK_FAILED = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LOGIN_SUCCESS = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LOGIN_FAILED = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CHECK_PWD_SUCCESS = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CHECK_PWD_FAILED = 22,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BIND_SUCCESS = 23,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BIND_FAILED = 24,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TEMPORARY_SUCCESS = 25,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TEMPORARY_FAILED = 26,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REVIEW_SUCCESS = 27,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REVIEW_FAILED = 28,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CONFIRM_SUCCESS = 29,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CONFIRM_FAILED = 30,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QUERY_REPEAT = 31,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RedisCluster_CONNECT_NORMAL = 32,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RedisCluster_CONNECT_FAILD = 33,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UPDATE_SUCCESS = 34,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UPDATE_ERROR = 35,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LOGOUT_SUCCESS = 36,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LOGOUT_FAILED = 37,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REVERSE_SUCCESS = 38,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REVERSE_FAILED = 39,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ACCOUNT_PASSWORD_ERROR = 40,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DESERIALIZEPARA_FAILED = 41,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IMPORT_SUCCESS = 42,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IMPORT_FAILED = 43,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUBMIT_SUCCESS = 44,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUBMIT_FAILED = 45,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CANCELSUBMIT_SUCCESS = 46,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CANCELSUBMIT_FAILED = 47,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RETURN_SUCCESS = 48,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RETURN_FAILED = 49,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALID_SUCCESS = 50,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALID_FAILED = 51,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        END_SUCCESS = 52,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        END_FAILED = 53,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESTART_SUCCESS = 54,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESTART_FAILED = 55,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WITHDRAW_SUCCESS = 56,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WITHDRAW_FAILED = 57,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CHARGE_NORMAL = 58,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CHARGE_EMPTY = 59,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sku", Namespace="http://schemas.datacontract.org/2004/07/StockModelData")]
    [System.SerializableAttribute()]
    public partial class Sku : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AuxIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SignNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SignTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SkuIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkuNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpareField;
        
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
        public System.Nullable<int> AuxID {
            get {
                return this.AuxIDField;
            }
            set {
                if ((this.AuxIDField.Equals(value) != true)) {
                    this.AuxIDField = value;
                    this.RaisePropertyChanged("AuxID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SignNum {
            get {
                return this.SignNumField;
            }
            set {
                if ((object.ReferenceEquals(this.SignNumField, value) != true)) {
                    this.SignNumField = value;
                    this.RaisePropertyChanged("SignNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SignTypeID {
            get {
                return this.SignTypeIDField;
            }
            set {
                if ((this.SignTypeIDField.Equals(value) != true)) {
                    this.SignTypeIDField = value;
                    this.RaisePropertyChanged("SignTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SkuID {
            get {
                return this.SkuIDField;
            }
            set {
                if ((this.SkuIDField.Equals(value) != true)) {
                    this.SkuIDField = value;
                    this.RaisePropertyChanged("SkuID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SkuName {
            get {
                return this.SkuNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SkuNameField, value) != true)) {
                    this.SkuNameField = value;
                    this.RaisePropertyChanged("SkuName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Spare {
            get {
                return this.SpareField;
            }
            set {
                if ((object.ReferenceEquals(this.SpareField, value) != true)) {
                    this.SpareField = value;
                    this.RaisePropertyChanged("Spare");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BillType", Namespace="http://schemas.datacontract.org/2004/07/StockModelData")]
    [System.SerializableAttribute()]
    public partial class BillType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BillTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillTypeNameField;
        
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
        public int BillTypeID {
            get {
                return this.BillTypeIDField;
            }
            set {
                if ((this.BillTypeIDField.Equals(value) != true)) {
                    this.BillTypeIDField = value;
                    this.RaisePropertyChanged("BillTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillTypeName {
            get {
                return this.BillTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BillTypeNameField, value) != true)) {
                    this.BillTypeNameField = value;
                    this.RaisePropertyChanged("BillTypeName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.DataModelServiceProxy")]
    public interface DataModelServiceProxy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataModel/FeedbackInfomationClass", ReplyAction="http://tempuri.org/IDataModel/FeedbackInfomationClassResponse")]
        WcfAppliacation.ServiceReference1.FeedbackInfomation FeedbackInfomationClass();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataModel/FeedbackInfomationClass", ReplyAction="http://tempuri.org/IDataModel/FeedbackInfomationClassResponse")]
        System.Threading.Tasks.Task<WcfAppliacation.ServiceReference1.FeedbackInfomation> FeedbackInfomationClassAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataModel/SkuClass", ReplyAction="http://tempuri.org/IDataModel/SkuClassResponse")]
        WcfAppliacation.ServiceReference1.Sku SkuClass();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataModel/SkuClass", ReplyAction="http://tempuri.org/IDataModel/SkuClassResponse")]
        System.Threading.Tasks.Task<WcfAppliacation.ServiceReference1.Sku> SkuClassAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataModel/BillTypeClass", ReplyAction="http://tempuri.org/IDataModel/BillTypeClassResponse")]
        WcfAppliacation.ServiceReference1.BillType BillTypeClass();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataModel/BillTypeClass", ReplyAction="http://tempuri.org/IDataModel/BillTypeClassResponse")]
        System.Threading.Tasks.Task<WcfAppliacation.ServiceReference1.BillType> BillTypeClassAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataModelServiceProxyChannel : WcfAppliacation.ServiceReference1.DataModelServiceProxy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataModelServiceProxyClient : System.ServiceModel.ClientBase<WcfAppliacation.ServiceReference1.DataModelServiceProxy>, WcfAppliacation.ServiceReference1.DataModelServiceProxy {
        
        public DataModelServiceProxyClient() {
        }
        
        public DataModelServiceProxyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataModelServiceProxyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataModelServiceProxyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataModelServiceProxyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfAppliacation.ServiceReference1.FeedbackInfomation FeedbackInfomationClass() {
            return base.Channel.FeedbackInfomationClass();
        }
        
        public System.Threading.Tasks.Task<WcfAppliacation.ServiceReference1.FeedbackInfomation> FeedbackInfomationClassAsync() {
            return base.Channel.FeedbackInfomationClassAsync();
        }
        
        public WcfAppliacation.ServiceReference1.Sku SkuClass() {
            return base.Channel.SkuClass();
        }
        
        public System.Threading.Tasks.Task<WcfAppliacation.ServiceReference1.Sku> SkuClassAsync() {
            return base.Channel.SkuClassAsync();
        }
        
        public WcfAppliacation.ServiceReference1.BillType BillTypeClass() {
            return base.Channel.BillTypeClass();
        }
        
        public System.Threading.Tasks.Task<WcfAppliacation.ServiceReference1.BillType> BillTypeClassAsync() {
            return base.Channel.BillTypeClassAsync();
        }
    }
}