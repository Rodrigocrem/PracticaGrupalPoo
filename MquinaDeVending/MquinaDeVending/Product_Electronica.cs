﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Product_Electronica : Product_General
    {
        public string Material { get; set; }
        public bool Pilas { get; set; }
        public bool Precargado { get; set; }

        public Product_Electronica() { }
        public Product_Electronica(int id, string nombre, double precio, int cantidad, string descripcion, string material, bool pilas, bool precargado)
            : base(id, nombre, precio, cantidad, descripcion)
        {
            Pilas = pilas;
            Precargado = precargado;
            Material = material;

        }
        public override void AddProducto(ref List<Product_General> ListaProductos)
        {
            //Solicitamos los datos que se añaden al tratarse de la clase electronica.
            base.AddProducto(ref ListaProductos);
            int TPilas;

            Console.WriteLine("Introduce Material: ");
            Material = Console.ReadLine();

            Console.WriteLine("Incluye Pilas (Sí=0/No=1): ");
            TPilas = int.Parse(Console.ReadLine());

            if (TPilas == 0)
            {
                Pilas = true;
            }
            else
            {
                Pilas = false;
            }
            Console.WriteLine("Precargado (Sí=0/No=1): ");
            TPilas = int.Parse(Console.ReadLine());
            if (TPilas == 0)
            {
                Precargado = true;
            }
            else
            {
                Precargado = false;
            }

        }
         /// <summary>
         /// Comentar. 
         /// </summary>
        public void ContMPreciosos()
        {
            Thread.Sleep(1000);
            int TPilas;

            Console.WriteLine("Introduce Material: ");
            Material = Console.ReadLine();

            Console.WriteLine("Incluye Pilas (Sí=0/No=1): ");
            TPilas = int.Parse(Console.ReadLine());

            if (TPilas == 0)
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
        public override string SInfo()
        {
            return $"{base.SInfo()}\n\t Material: {Material}\n\t Pilas: {Pilas} Precargado: {Precargado}";
        }
       
        public override void ToFile()
        {
            StreamWriter sw = new StreamWriter("PMPreciosos.txt", true);
            sw.WriteLine($"{Id},{Nombre},{Precio},{Cantidad},{Descripcion},{Material},{Precargado},{Material}");
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
            bool pilas = Pilas;
            bool precargado = Precargado;
            Product_Electronica product = new Product_Electronica(Id, Nombre, Precio, Cantidad, Descripcion, Material, Pilas, Precargado);
            return product;
        }


    }
}
