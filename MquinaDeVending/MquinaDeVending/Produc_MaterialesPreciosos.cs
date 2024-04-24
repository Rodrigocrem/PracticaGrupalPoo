using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Produc_MaterialesPreciosos : Product_General
    {
        public string Material { get; set; }
        public double Peso { get; set; }

        public Produc_MaterialesPreciosos() { }

        // Constructor parametrizado que inicializa todas las propiedades, incluyendo Material y Peso
        public Produc_MaterialesPreciosos(int id, string nombre, double precio, int cantidad, string descripcion, string material, double peso)
         : base(id, nombre, precio, cantidad, descripcion)
        {
            Material = material;
            Peso = peso;
        }
        // Método para agregar un producto a la lista, solicitando al admin el tipo de material y el peso
        public override void AddProducto(ref List<Product_General> ListaProductos)
        {
            base.AddProducto(ref ListaProductos);
            Console.WriteLine("Tipo de Material");
            Material = Console.ReadLine();
            Console.WriteLine("Introduce Peso ");
            Peso = double.Parse(Console.ReadLine());
        }
        public override string SInfo()
        {
            return $"{base.SInfo()}\n\t Material: {Material}\n\t Peso: {Peso} ";
        }

        // Método para escribir la información del producto en un archivo de texto
        public override void ToFile()
        {
            StreamWriter sw = new StreamWriter("PElectronicos.txt", true);
            sw.WriteLine($"{Id}{Nombre} {Precio} {Cantidad} {Descripcion} {Material} {Peso}");
            sw.Close();
        }
        public override Product_General Copiar()
        {
            int id = Id;
            string nombre = Nombre;
            double precio = Precio;
            int cantidad = Cantidad;
            string descripcion = Descripcion;
            string material = Material;
            double peso = Peso;
            Produc_MaterialesPreciosos product = new Produc_MaterialesPreciosos(Id, Nombre, Precio, Cantidad, Descripcion, Material, Peso);
            return product;
        }

    }

}
