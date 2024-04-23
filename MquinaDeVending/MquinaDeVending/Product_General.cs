using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal abstract class Product_General
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public Product_General() { }


        public Product_General(int id, string nombre, double precio, int cantidad, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Descripcion = descripcion;

        }

        public virtual string SInfo()
        {
            return $"Id: {Id}\n\t Nombre: {Nombre}\n\t Precio: {Precio}\n\t Cantidad: {Cantidad}\n\t Descripcion: {Descripcion}\n\t";
        }
        public virtual void AddProducto()
        {

            Console.WriteLine("Introduce Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduce Precio: ");
            Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantas unidades desea?: ");
            Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce Descripcion: ");
            Descripcion = Console.ReadLine();

        }

        public abstract Product_General Copiar();

        public abstract void ToFile();

    }
}
