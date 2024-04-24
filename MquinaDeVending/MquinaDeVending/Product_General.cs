﻿using System;
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

        public virtual void AddProducto(ref List<Product_General> ListaProductos)
        {
           
            int cantidades = 0;
            int cant1 = 0;
            Console.WriteLine("Introduce Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduce Precio (Euros): ");
            Precio = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("¿Cuantas unidades desea?: ");
                cant1 = int.Parse(Console.ReadLine());
                foreach(Product_General produc in ListaProductos)
                {
                    cantidades += produc.Cantidad;
                }
                cantidades += cant1;
            } while (cantidades > 12);
            Cantidad = cantidades;
            Console.WriteLine("Introduce Descripcion: ");
            Descripcion = Console.ReadLine();

        }

        public abstract Product_General Copiar();

        public abstract void ToFile();

    }
}
