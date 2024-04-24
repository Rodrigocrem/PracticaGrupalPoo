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

        // Método para ver los productos en la lista
        public void VerProductos(List<Product_General> ListaProductos)
        {
            foreach (Product_General p in ListaProductos)
            {
                // Comprobamos el tipo de producto y muestra su información

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
                else if (p is Produc_MaterialesPreciosos)
                {
                    Console.WriteLine(p.SInfo());
                    Console.ReadKey();
                }
            }
        }
    }
}


