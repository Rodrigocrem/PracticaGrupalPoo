using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Product_Alimentos : Product_General
    {
        public string InformacionNutricional { get; set; }

        public Product_Alimentos() { }

        public Product_Alimentos(int id, string nombre, double precio, int cantidad, string descripcion, string informacionnutricional)
            : base(id, nombre, precio, cantidad, descripcion)
        {
            InformacionNutricional = informacionnutricional;
        }
        public override void AddProducto(ref List<Product_General> ListaProductos)
        {
            base.AddProducto(ref ListaProductos);
            Console.WriteLine("Introduce informacion nutricional: ");
            InformacionNutricional = Console.ReadLine();
        }
        public void ContAlimentacion()
        {
            Console.WriteLine("Introduce informacion nutricional: ");
            InformacionNutricional = Console.ReadLine();
        }
        public override string SInfo()
        {
            return $"{base.SInfo()}\n\t Información nutricional  {InformacionNutricional}";
        }
        public override void ToFile()
        {
            StreamWriter sw = new StreamWriter("PAlimentos.txt", true);
            sw.WriteLine($"{Id},{Nombre},{Precio},{Cantidad},{Descripcion},{InformacionNutricional}");
            sw.Close();
        }
        public override Product_General Copiar()
        {
            int id = Id;
            string nombre = Nombre;
            double precio = Precio;
            int cantidad = Cantidad;
            string descripcion = Descripcion;
            string infonutricional = InformacionNutricional;
            Product_Alimentos product = new Product_Alimentos(Id, Nombre, Precio, Cantidad, Descripcion, InformacionNutricional);
            return product;
        }
    }





}
