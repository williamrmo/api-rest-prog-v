﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestASMX.ReferenciaServicioSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        private int CodigoField;
        
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
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaServicioSoap.EjemploSoap")]
    public interface EjemploSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        TestASMX.ReferenciaServicioSoap.HelloWorldResponse HelloWorld(TestASMX.ReferenciaServicioSoap.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.HelloWorldResponse> HelloWorldAsync(TestASMX.ReferenciaServicioSoap.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        int Sumar(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sumar", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SumarAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name ObtenerPersonaResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPersona", ReplyAction="*")]
        TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponse ObtenerPersona(TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPersona", ReplyAction="*")]
        System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponse> ObtenerPersonaAsync(TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest request);
        
        // CODEGEN: Generating message contract since element name ObtenerPersonasResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPersonas", ReplyAction="*")]
        TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponse ObtenerPersonas(TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPersonas", ReplyAction="*")]
        System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponse> ObtenerPersonasAsync(TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public TestASMX.ReferenciaServicioSoap.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(TestASMX.ReferenciaServicioSoap.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestASMX.ReferenciaServicioSoap.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(TestASMX.ReferenciaServicioSoap.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPersonaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPersona", Namespace="http://tempuri.org/", Order=0)]
        public TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequestBody Body;
        
        public ObtenerPersonaRequest() {
        }
        
        public ObtenerPersonaRequest(TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPersonaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int codigo;
        
        public ObtenerPersonaRequestBody() {
        }
        
        public ObtenerPersonaRequestBody(int codigo) {
            this.codigo = codigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPersonaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPersonaResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponseBody Body;
        
        public ObtenerPersonaResponse() {
        }
        
        public ObtenerPersonaResponse(TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPersonaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestASMX.ReferenciaServicioSoap.Persona ObtenerPersonaResult;
        
        public ObtenerPersonaResponseBody() {
        }
        
        public ObtenerPersonaResponseBody(TestASMX.ReferenciaServicioSoap.Persona ObtenerPersonaResult) {
            this.ObtenerPersonaResult = ObtenerPersonaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPersonasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPersonas", Namespace="http://tempuri.org/", Order=0)]
        public TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequestBody Body;
        
        public ObtenerPersonasRequest() {
        }
        
        public ObtenerPersonasRequest(TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerPersonasRequestBody {
        
        public ObtenerPersonasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPersonasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPersonasResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponseBody Body;
        
        public ObtenerPersonasResponse() {
        }
        
        public ObtenerPersonasResponse(TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPersonasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestASMX.ReferenciaServicioSoap.Persona[] ObtenerPersonasResult;
        
        public ObtenerPersonasResponseBody() {
        }
        
        public ObtenerPersonasResponseBody(TestASMX.ReferenciaServicioSoap.Persona[] ObtenerPersonasResult) {
            this.ObtenerPersonasResult = ObtenerPersonasResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EjemploSoapChannel : TestASMX.ReferenciaServicioSoap.EjemploSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EjemploSoapClient : System.ServiceModel.ClientBase<TestASMX.ReferenciaServicioSoap.EjemploSoap>, TestASMX.ReferenciaServicioSoap.EjemploSoap {
        
        public EjemploSoapClient() {
        }
        
        public EjemploSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EjemploSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EjemploSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EjemploSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestASMX.ReferenciaServicioSoap.HelloWorldResponse TestASMX.ReferenciaServicioSoap.EjemploSoap.HelloWorld(TestASMX.ReferenciaServicioSoap.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            TestASMX.ReferenciaServicioSoap.HelloWorldRequest inValue = new TestASMX.ReferenciaServicioSoap.HelloWorldRequest();
            inValue.Body = new TestASMX.ReferenciaServicioSoap.HelloWorldRequestBody();
            TestASMX.ReferenciaServicioSoap.HelloWorldResponse retVal = ((TestASMX.ReferenciaServicioSoap.EjemploSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.HelloWorldResponse> TestASMX.ReferenciaServicioSoap.EjemploSoap.HelloWorldAsync(TestASMX.ReferenciaServicioSoap.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.HelloWorldResponse> HelloWorldAsync() {
            TestASMX.ReferenciaServicioSoap.HelloWorldRequest inValue = new TestASMX.ReferenciaServicioSoap.HelloWorldRequest();
            inValue.Body = new TestASMX.ReferenciaServicioSoap.HelloWorldRequestBody();
            return ((TestASMX.ReferenciaServicioSoap.EjemploSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Sumar(int a, int b) {
            return base.Channel.Sumar(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumarAsync(int a, int b) {
            return base.Channel.SumarAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponse TestASMX.ReferenciaServicioSoap.EjemploSoap.ObtenerPersona(TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest request) {
            return base.Channel.ObtenerPersona(request);
        }
        
        public TestASMX.ReferenciaServicioSoap.Persona ObtenerPersona(int codigo) {
            TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest inValue = new TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest();
            inValue.Body = new TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequestBody();
            inValue.Body.codigo = codigo;
            TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponse retVal = ((TestASMX.ReferenciaServicioSoap.EjemploSoap)(this)).ObtenerPersona(inValue);
            return retVal.Body.ObtenerPersonaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponse> TestASMX.ReferenciaServicioSoap.EjemploSoap.ObtenerPersonaAsync(TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest request) {
            return base.Channel.ObtenerPersonaAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.ObtenerPersonaResponse> ObtenerPersonaAsync(int codigo) {
            TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest inValue = new TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequest();
            inValue.Body = new TestASMX.ReferenciaServicioSoap.ObtenerPersonaRequestBody();
            inValue.Body.codigo = codigo;
            return ((TestASMX.ReferenciaServicioSoap.EjemploSoap)(this)).ObtenerPersonaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponse TestASMX.ReferenciaServicioSoap.EjemploSoap.ObtenerPersonas(TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest request) {
            return base.Channel.ObtenerPersonas(request);
        }
        
        public TestASMX.ReferenciaServicioSoap.Persona[] ObtenerPersonas() {
            TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest inValue = new TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest();
            inValue.Body = new TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequestBody();
            TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponse retVal = ((TestASMX.ReferenciaServicioSoap.EjemploSoap)(this)).ObtenerPersonas(inValue);
            return retVal.Body.ObtenerPersonasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponse> TestASMX.ReferenciaServicioSoap.EjemploSoap.ObtenerPersonasAsync(TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest request) {
            return base.Channel.ObtenerPersonasAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestASMX.ReferenciaServicioSoap.ObtenerPersonasResponse> ObtenerPersonasAsync() {
            TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest inValue = new TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequest();
            inValue.Body = new TestASMX.ReferenciaServicioSoap.ObtenerPersonasRequestBody();
            return ((TestASMX.ReferenciaServicioSoap.EjemploSoap)(this)).ObtenerPersonasAsync(inValue);
        }
    }
}
