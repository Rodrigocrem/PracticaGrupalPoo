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
        public int Calorias { get; set; }
        public int Grasa { get; set; }
        public int Azucar { get; set; }

        public Product_Alimentos() { }

        public Product_Alimentos(int id, string nombre, double precio, int preciounidad, string descripcion, int calorias, int grasa, int azucar)
            : base(id, nombre, precio, preciounidad, descripcion)
        {
            Calorias = calorias;
            Azucar = azucar;
            Grasa = grasa;
        }
        public void ContAlimentacion()
        {
            Console.WriteLine("Introduce las calorias:");
            Calorias = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la grasa: ");
            Grasa = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el azucar:");
            Azucar = int.Parse(Console.ReadLine());
        }
        public override string SInfo()
        {
            return $"{base.SInfo()}\n\t Calorias: {Calorias}\n\t Grasa: {Grasa} \n\t Azucar: {Azucar}";
        }
        public override void ToFile()
        {
            StreamWriter sw = new StreamWriter("PAlimentos.txt", true);
            sw.WriteLine($"{Id},{Nombre},{Precio},{PrecioUnidad},{Descripcion},{Calorias},{Grasa},{Azucar}");
            sw.Close();
        }

    }





}
