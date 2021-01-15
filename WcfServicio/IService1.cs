using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Peliculas CrearPeliculas();

        [OperationContract]
        Alumnos CrearAlumnos();

        [OperationContract]
        Alumnos CrearLibros();

        [OperationContract]
        double ConvertirDolares(double pesos);
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Producto GetIdProducto();

        [OperationContract]
        Producto GetProducto(Producto producto);


        [OperationContract]
        Peliculas GetDatosPeliculas(Peliculas pelicula);
        [OperationContract]
        Alumnos GetDatosAlumnos(Alumnos alumno);
        [OperationContract]
        Libros GetDatosLibros(Libros libro);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Peliculas
    {
        string nombre;
        string director;
        float duracion;
        int clasificacion;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        [DataMember]
        public float Duración
        {
            get { return duracion; }
            set { duracion = value; }
        }
        [DataMember]
        public int Clasificación
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
    }
    [DataContract]
    public class Producto
    {
        string nombre;
        int id;
        int precio;


        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }

    [DataContract]
    public class Alumnos
    {
        string nombre;
        string nocontrol;
        float semestre;
        int promedio;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public string Nocontrol
        {
            get { return nocontrol; }
            set { nocontrol = value; }
        }
        [DataMember]
        public float Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        [DataMember]
        public int Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
    }
    public class Libros
    {
        string nombre;
        string autor;
        float id;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        [DataMember]
        public float Id
        {
            get { return id; }
            set { id = value; }
        }
    }
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
