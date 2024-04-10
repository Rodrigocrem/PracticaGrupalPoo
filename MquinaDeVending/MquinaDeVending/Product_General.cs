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
        public int Id {  get; set; }
        public string Nombre {  get; set; }
        public double Precio {  get; set; }
        public int PrecioUnidad {  get; set; }
        public string Descripcion {  get; set; }

        public Product_General(){ }
    

        public Product_General(int id, string nombre, double precio, int preciounidad, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            PrecioUnidad = preciounidad;
            Descripcion = descripcion;
        }

        protected Product_General(int id, string nombre, double precio, int precioUnidad)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            PrecioUnidad = precioUnidad;
        }

        public virtual string SInfo()
        {
            return $"Id: {Id}\n\t Nombre: {Nombre}\n\t Precio: {Precio}\n\t PrecioUnidad: {PrecioUnidad}\n\t Descripcion: {Descripcion}";
        }

        public virtual void MInfo() 
        {
            Console.WriteLine("Introduce Id:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduce Precio: ");
            Precio = double.Parse(Console.ReadLine()) ;
            Console.WriteLine("Introduce PrecioUnidad: ");
            PrecioUnidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce Descripcion: ");
            Descripcion = Console.ReadLine();
        }
        public abstract void ToInfo();
        internal abstract bool ObtenerInformacionProducto();
    }
}