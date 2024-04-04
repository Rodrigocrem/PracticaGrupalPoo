using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Program
    {
        static List<Product_General> listaproductos = new List<Product_General>();
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Bienvenidos a nuestra maquina de vending :)");
                Console.WriteLine("Para comenzar seleccione una opcion:");
                Console.WriteLine("1. Comprar un producto.");
                Console.WriteLine("2. Mostrar informacion de un producto.");
                Console.WriteLine("3. Cargar productos de manera individual.");
                Console.WriteLine("4. Cargar productos a tope.");
                Console.WriteLine("6. Salir.");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(opcion)
                {
                    case 1:
                        //
                        break;
                    case 2:
                        //
                        break;
                    case 3:
                        //
                        break;
                    case 4:
                        //
                        break;
                    case 5:
                        //
                        break;
                    case 6://Salir.
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != 6);
        }

        public static void ComprarProducto()
        {
            List<int> productoseleccionados = new List<int>();
            Console.WriteLine("Introduce el Id del producto a comprar: ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Para pagar seleccione: 0");
            int pagar = int.Parse(Console.ReadLine());
            foreach(int id in productoseleccionados)
            {
                if(id == Id)
                { Console.WriteLine("")} ///Terminar ahora centrarnos en otras cosas. 
            }
            
        }


    }
}
