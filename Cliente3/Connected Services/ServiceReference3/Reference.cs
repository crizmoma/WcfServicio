﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente3.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Peliculas", Namespace="http://schemas.datacontract.org/2004/07/WcfServicio")]
    [System.SerializableAttribute()]
    public partial class Peliculas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClasificaciónField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DuraciónField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public int Clasificación {
            get {
                return this.ClasificaciónField;
            }
            set {
                if ((this.ClasificaciónField.Equals(value) != true)) {
                    this.ClasificaciónField = value;
                    this.RaisePropertyChanged("Clasificación");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Duración {
            get {
                return this.DuraciónField;
            }
            set {
                if ((this.DuraciónField.Equals(value) != true)) {
                    this.DuraciónField = value;
                    this.RaisePropertyChanged("Duración");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumnos", Namespace="http://schemas.datacontract.org/2004/07/WcfServicio")]
    [System.SerializableAttribute()]
    public partial class Alumnos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NocontrolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PromedioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float SemestreField;
        
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
        public string Nocontrol {
            get {
                return this.NocontrolField;
            }
            set {
                if ((object.ReferenceEquals(this.NocontrolField, value) != true)) {
                    this.NocontrolField = value;
                    this.RaisePropertyChanged("Nocontrol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Promedio {
            get {
                return this.PromedioField;
            }
            set {
                if ((this.PromedioField.Equals(value) != true)) {
                    this.PromedioField = value;
                    this.RaisePropertyChanged("Promedio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Semestre {
            get {
                return this.SemestreField;
            }
            set {
                if ((this.SemestreField.Equals(value) != true)) {
                    this.SemestreField = value;
                    this.RaisePropertyChanged("Semestre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Libros", Namespace="http://schemas.datacontract.org/2004/07/WcfServicio")]
    [System.SerializableAttribute()]
    public partial class Libros : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServicio")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CrearPeliculas", ReplyAction="http://tempuri.org/IService1/CrearPeliculasResponse")]
        Cliente3.ServiceReference3.Peliculas CrearPeliculas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CrearAlumnos", ReplyAction="http://tempuri.org/IService1/CrearAlumnosResponse")]
        Cliente3.ServiceReference3.Alumnos CrearAlumnos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CrearLibros", ReplyAction="http://tempuri.org/IService1/CrearLibrosResponse")]
        Cliente3.ServiceReference3.Alumnos CrearLibros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertirDolares", ReplyAction="http://tempuri.org/IService1/ConvertirDolaresResponse")]
        double ConvertirDolares(double pesos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDatosPeliculas", ReplyAction="http://tempuri.org/IService1/GetDatosPeliculasResponse")]
        Cliente3.ServiceReference3.Peliculas GetDatosPeliculas(Cliente3.ServiceReference3.Peliculas pelicula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDatosAlumnos", ReplyAction="http://tempuri.org/IService1/GetDatosAlumnosResponse")]
        Cliente3.ServiceReference3.Alumnos GetDatosAlumnos(Cliente3.ServiceReference3.Alumnos alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDatosLibros", ReplyAction="http://tempuri.org/IService1/GetDatosLibrosResponse")]
        Cliente3.ServiceReference3.Libros GetDatosLibros(Cliente3.ServiceReference3.Libros libro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Cliente3.ServiceReference3.CompositeType GetDataUsingDataContract(Cliente3.ServiceReference3.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Cliente3.ServiceReference3.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Cliente3.ServiceReference3.IService1>, Cliente3.ServiceReference3.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Cliente3.ServiceReference3.Peliculas CrearPeliculas() {
            return base.Channel.CrearPeliculas();
        }
        
        public Cliente3.ServiceReference3.Alumnos CrearAlumnos() {
            return base.Channel.CrearAlumnos();
        }
        
        public Cliente3.ServiceReference3.Alumnos CrearLibros() {
            return base.Channel.CrearLibros();
        }
        
        public double ConvertirDolares(double pesos) {
            return base.Channel.ConvertirDolares(pesos);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public Cliente3.ServiceReference3.Peliculas GetDatosPeliculas(Cliente3.ServiceReference3.Peliculas pelicula) {
            return base.Channel.GetDatosPeliculas(pelicula);
        }
        
        public Cliente3.ServiceReference3.Alumnos GetDatosAlumnos(Cliente3.ServiceReference3.Alumnos alumno) {
            return base.Channel.GetDatosAlumnos(alumno);
        }
        
        public Cliente3.ServiceReference3.Libros GetDatosLibros(Cliente3.ServiceReference3.Libros libro) {
            return base.Channel.GetDatosLibros(libro);
        }
        
        public Cliente3.ServiceReference3.CompositeType GetDataUsingDataContract(Cliente3.ServiceReference3.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }

        internal object GetIdProducto()
        {
            throw new NotImplementedException();
        }

        internal object GetProducto(object lista)
        {
            throw new NotImplementedException();
        }

        internal object GetData(string text)
        {
            throw new NotImplementedException();
        }
    }
}
