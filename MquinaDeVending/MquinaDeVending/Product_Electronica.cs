﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Product_Electronica : Product_General
    {
        public string Material { get; set; }
        public int Peso { get; set; }

        public Product_Electronica() { }

        public Product_Electronica(int id, string nombre, double precio, int precioUnidad, string descripcion, string material, int peso)
         : base(id, nombre, precio, precioUnidad, descripcion)
        {
            Material = material;
            Peso = peso;
        }
        public override void AddProducto()
        {
            base.AddProducto();
            Console.WriteLine("Tipo de Material");
            Material = Console.ReadLine();
            Console.WriteLine("Introduce Preso ");
            Peso = int.Parse(Console.ReadLine());
        }
        public string SInfo()
        {
            return $"{base.SInfo()}\n\t Material: {Material}\n\t Peso: {Peso} ";
        }
        public override void ToFile()
        {
            StreamWriter sw = new StreamWriter("PElectronicos.txt", true);
            sw.WriteLine($"{Id}{Nombre} {Precio} {PrecioUnidad} {Descripcion} {Material} {Peso}");
            sw.Close();
        }


    }
}
