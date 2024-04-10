using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Product_MaterialesPrecios : Product_General
    {
        public string Material { get; set; }
        public bool Pilas { get; set; }
        public bool Precargado { get; set; }

        public Product_MaterialesPrecios() { }
        public Product_MaterialesPrecios(int id, string nombre, double precio, int precioUnidad, string descripcion, string material, bool pilas, bool precargado)
            : base(id, nombre, precio, precioUnidad, descripcion)
        {
            Pilas = pilas;
            Precargado = precargado;
            Material = material;

        }
        public void ContMPreciosos ()
        {
            Console.WriteLine("Introduce el material: ");
            Console.WriteLine("¿Desea pilas?(Si/No)");
            Console.WriteLine("¿El producto esta precargado?(Si/No)");
        }
        public string SInfo()
        {
            return $"Id: {Id}\n\t Nombre: {Nombre}\n\t Precio: {Precio}\n\t PrecioUnidad: {PrecioUnidad}\n\t Descripcion: {Descripcion}\n\t Material: {Material}\n\t Pilas: {Pilas} Precargado: {Precargado} ";
        }

        public override void ToFile()
        {
            StreamWriter sw = new StreamWriter("PMPreciosos.txt", true);
            sw.WriteLine($"{Id},{Nombre},{Precio},{PrecioUnidad},{Descripcion},{Material},{Precargado},{Material}");
            sw.Close();
        }

    }

}
