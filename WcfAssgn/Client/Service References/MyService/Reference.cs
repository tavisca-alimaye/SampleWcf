﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MyService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeRemarks", Namespace="http://schemas.datacontract.org/2004/07/WcgAssgn")]
    [System.SerializableAttribute()]
    public partial class EmployeeRemarks : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeRemarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime GetDateTimeField;
        
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
        public string EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeIdField, value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeRemark {
            get {
                return this.EmployeeRemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeRemarkField, value) != true)) {
                    this.EmployeeRemarkField = value;
                    this.RaisePropertyChanged("EmployeeRemark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime GetDateTime {
            get {
                return this.GetDateTimeField;
            }
            set {
                if ((this.GetDateTimeField.Equals(value) != true)) {
                    this.GetDateTimeField = value;
                    this.RaisePropertyChanged("GetDateTime");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeData", Namespace="http://schemas.datacontract.org/2004/07/WcgAssgn")]
    [System.SerializableAttribute()]
    public partial class EmployeeData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
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
        public string EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeIdField, value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.ICreateEmployeeAddRemarks")]
    public interface ICreateEmployeeAddRemarks {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAddRemarks/CreateEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAddRemarks/CreateEmployeeResponse")]
        int CreateEmployee(string empId, string empName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAddRemarks/CreateEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAddRemarks/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<int> CreateEmployeeAsync(string empId, string empName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAddRemarks/EmployeeRemark", ReplyAction="http://tempuri.org/ICreateEmployeeAddRemarks/EmployeeRemarkResponse")]
        Client.MyService.EmployeeRemarks EmployeeRemark(string empId, string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAddRemarks/EmployeeRemark", ReplyAction="http://tempuri.org/ICreateEmployeeAddRemarks/EmployeeRemarkResponse")]
        System.Threading.Tasks.Task<Client.MyService.EmployeeRemarks> EmployeeRemarkAsync(string empId, string remark);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAddRemarks/DeleteEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAddRemarks/DeleteEmployeeResponse")]
        int DeleteEmployee(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAddRemarks/DeleteEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAddRemarks/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<int> DeleteEmployeeAsync(string empId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreateEmployeeAddRemarksChannel : Client.MyService.ICreateEmployeeAddRemarks, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateEmployeeAddRemarksClient : System.ServiceModel.ClientBase<Client.MyService.ICreateEmployeeAddRemarks>, Client.MyService.ICreateEmployeeAddRemarks {
        
        public CreateEmployeeAddRemarksClient() {
        }
        
        public CreateEmployeeAddRemarksClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreateEmployeeAddRemarksClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeAddRemarksClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeAddRemarksClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CreateEmployee(string empId, string empName) {
            return base.Channel.CreateEmployee(empId, empName);
        }
        
        public System.Threading.Tasks.Task<int> CreateEmployeeAsync(string empId, string empName) {
            return base.Channel.CreateEmployeeAsync(empId, empName);
        }
        
        public Client.MyService.EmployeeRemarks EmployeeRemark(string empId, string remark) {
            return base.Channel.EmployeeRemark(empId, remark);
        }
        
        public System.Threading.Tasks.Task<Client.MyService.EmployeeRemarks> EmployeeRemarkAsync(string empId, string remark) {
            return base.Channel.EmployeeRemarkAsync(empId, remark);
        }
        
        public int DeleteEmployee(string empId) {
            return base.Channel.DeleteEmployee(empId);
        }
        
        public System.Threading.Tasks.Task<int> DeleteEmployeeAsync(string empId) {
            return base.Channel.DeleteEmployeeAsync(empId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.ICreateEmployeeDetails")]
    public interface ICreateEmployeeDetails {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployees", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployeesResponse")]
        System.Collections.Generic.List<Client.MyService.EmployeeData> GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployees", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.MyService.EmployeeData>> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeNameFromId", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeNameFromIdResponse")]
        string GetEmployeeNameFromId(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeNameFromId", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeNameFromIdResponse")]
        System.Threading.Tasks.Task<string> GetEmployeeNameFromIdAsync(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeRemarkFromId", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeRemarkFromIdResponse")]
        System.Collections.Generic.List<Client.MyService.EmployeeRemarks> GetEmployeeRemarkFromId(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeRemarkFromId", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetEmployeeRemarkFromIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.MyService.EmployeeRemarks>> GetEmployeeRemarkFromIdAsync(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployeeRemarks", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployeeRemarksResponse")]
        System.Collections.Generic.List<Client.MyService.EmployeeRemarks> GetAllEmployeeRemarks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployeeRemarks", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/GetAllEmployeeRemarksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.MyService.EmployeeRemarks>> GetAllEmployeeRemarksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/SearchById", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/SearchByIdResponse")]
        Client.MyService.EmployeeData SearchById(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/SearchById", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/SearchByIdResponse")]
        System.Threading.Tasks.Task<Client.MyService.EmployeeData> SearchByIdAsync(string empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/SearchByName", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/SearchByNameResponse")]
        Client.MyService.EmployeeData SearchByName(string empName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeDetails/SearchByName", ReplyAction="http://tempuri.org/ICreateEmployeeDetails/SearchByNameResponse")]
        System.Threading.Tasks.Task<Client.MyService.EmployeeData> SearchByNameAsync(string empName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreateEmployeeDetailsChannel : Client.MyService.ICreateEmployeeDetails, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateEmployeeDetailsClient : System.ServiceModel.ClientBase<Client.MyService.ICreateEmployeeDetails>, Client.MyService.ICreateEmployeeDetails {
        
        public CreateEmployeeDetailsClient() {
        }
        
        public CreateEmployeeDetailsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreateEmployeeDetailsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeDetailsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeDetailsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Client.MyService.EmployeeData> GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.MyService.EmployeeData>> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public string GetEmployeeNameFromId(string empId) {
            return base.Channel.GetEmployeeNameFromId(empId);
        }
        
        public System.Threading.Tasks.Task<string> GetEmployeeNameFromIdAsync(string empId) {
            return base.Channel.GetEmployeeNameFromIdAsync(empId);
        }
        
        public System.Collections.Generic.List<Client.MyService.EmployeeRemarks> GetEmployeeRemarkFromId(string empId) {
            return base.Channel.GetEmployeeRemarkFromId(empId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.MyService.EmployeeRemarks>> GetEmployeeRemarkFromIdAsync(string empId) {
            return base.Channel.GetEmployeeRemarkFromIdAsync(empId);
        }
        
        public System.Collections.Generic.List<Client.MyService.EmployeeRemarks> GetAllEmployeeRemarks() {
            return base.Channel.GetAllEmployeeRemarks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.MyService.EmployeeRemarks>> GetAllEmployeeRemarksAsync() {
            return base.Channel.GetAllEmployeeRemarksAsync();
        }
        
        public Client.MyService.EmployeeData SearchById(string empId) {
            return base.Channel.SearchById(empId);
        }
        
        public System.Threading.Tasks.Task<Client.MyService.EmployeeData> SearchByIdAsync(string empId) {
            return base.Channel.SearchByIdAsync(empId);
        }
        
        public Client.MyService.EmployeeData SearchByName(string empName) {
            return base.Channel.SearchByName(empName);
        }
        
        public System.Threading.Tasks.Task<Client.MyService.EmployeeData> SearchByNameAsync(string empName) {
            return base.Channel.SearchByNameAsync(empName);
        }
    }
}