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
            Thread.Sleep(1000);
            int TPilas;
            
            //REVISAR
            Console.WriteLine("Introduce Material: ");
            Material = Console.ReadLine();

            Console.WriteLine("Incluye Pilas (Sí=0/No=1): ");
            TPilas = int.Parse(Console.ReadLine());

            if(TPilas == 0)
            {
                Pilas = true;
            }
            else
            {
                Pilas = false;
            }
            Console.WriteLine("Precargado (Sí=0/No=1): ");
            if (TPilas == 0)
            {
                Precargado = true;
            }
            else
            {
                Precargado = false;
            }

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
