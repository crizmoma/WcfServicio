using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public double ConvertirDolares(double pesos)
        {

            return pesos * 20.52;
        }
        public Peliculas GetDatosPeliculas(Peliculas pelicula)
        {
            return pelicula;
        }
        public Peliculas CrearPeliculas()
        {
            Peliculas pelicula = new Peliculas
            {
                Nombre = "Norbit",
                Clasificación = 7,
                Director = "Alejandro",
                Duración = 2
            };
            return pelicula;
        }
        public Alumnos CrearAlumnos()
        {
            Alumnos alumno = new Alumnos
            {
                Nombre = "Cristal Montelongo",
                Nocontrol = "17030096",
                Semestre = 7,
                Promedio = 89
            };
            return alumno;
        }
        public Libros CrearLibros()
        {
            Libros libro = new Libros
            {
                Nombre = "Los sueos",
                Autor = "wiliam",
                Id = 123
            };
            return libro;
        }
        public Alumnos GetDatosAlumnos(Alumnos alumno)
        {
            return alumno;
        }
        public Libros GetDatosLibros(Libros libro)
        {
            return libro;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        Alumnos IService1.CrearLibros()
        {
            throw new NotImplementedException();
        }
        public Producto GetProducto(Producto producto)
        {

            return producto;

        }

        public Producto GetIdProducto()
        {
            Producto producto = new Producto
            {
                Nombre = "pastel",
                Id = 4676,
                Precio = 250
            };
            return producto;

        }
    }
}
