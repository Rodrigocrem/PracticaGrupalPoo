using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Cliente
    {
        public Cliente() { }
        public void VerProductos(List<Product_General> ListaProductos)
        {
            foreach (Product_General p in ListaProductos)
            {
                if (p is Product_Alimentos)
                {

                    Console.WriteLine(p.SInfo());
                    Console.ReadKey();

                }
                else if (p is Product_Electronica)
                {

                    Console.WriteLine(p.SInfo());
                    Console.ReadKey();

                }
                else if (p is Product_MaterialesPrecios)
                {
                    Console.WriteLine(p.SInfo());
                    Console.ReadKey();
                }
            }
        }
    }
} 


