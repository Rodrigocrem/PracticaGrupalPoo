using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Product_General
    {
        public static int Id { get; set; }
        public string Nombre {  get; set; }
        public double Precio { get; set; }
        public int PrecioUnidad { get; set; }
        public string Descripcion { get; set; }
        

        public Product_General() { }

        public Product_General(int id, string nombre, double precio, int precioUnidad, string descripcion) 
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            PrecioUnidad = precioUnidad;
            Descripcion = descripcion;
        }

        public virtual string ObtenerInforamcionProducto()
        {
            return $"Id: {Id}\n\t Nombre: {Nombre}\n\t Precio: {Precio}\n\t PrecioUnidad: {PrecioUnidad}\n\t Descripcion: {Descripcion} ";
        }

        public virtual void SolicitarDetalles()
        {
            Console.WriteLine("Introduce el Id: ");
            Id  = int.Parse(Console.ReadLine());
            Console.WriteLine("Intruduce el nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduca el precio: ");
            Precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduca la descripcion: ");
            Descripcion = Console.ReadLine();      
        }


    }
}
