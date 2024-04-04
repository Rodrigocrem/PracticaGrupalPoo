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
                Console.WriteLine("...................................................");
                Console.WriteLine(".     Bienvenidos a nuestra maquina de vending     .");
                Console.WriteLine("...................................................");
                Console.WriteLine(".      Para comenzar seleccione una opcion:       .");
                Console.WriteLine("...................................................");
                Console.WriteLine(".      1. Comprar un producto                     .");
                Console.WriteLine("...................................................");
                Console.WriteLine("       2. Mostrar informacion de un producto      .");
                Console.WriteLine("...................................................");
                Console.WriteLine(".      3. Cargar productos de manera individual   .");
                Console.WriteLine("...................................................");
                Console.WriteLine(".      4. Cargar productos a tope                 .");
                Console.WriteLine("...................................................");
                Console.WriteLine(".      5. Salir                                   .");
                Console.WriteLine("...................................................");
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
            Console.WriteLine("Introduce el Id del producto a comprar: ");
            int Idproducto = int.Parse(Console.ReadLine());
            bool productoEncontrado = false;
            foreach (Product_General producto in listaproductos)
            {
                if(Product_General.Id ==Idproducto)
                {
                    productoEncontrado = true;

                    //Mostramos información del producto.
                    Console.WriteLine("Producto seleccionado: ");
                    Console.WriteLine(producto.ObtenerInformacionProducto());
                    xº
                    //Gestionamos la opcion de pago.
                    Console.WriteLine("Para pagar seleccione: 0");
                    int OpcionPago = int.Parse(Console.ReadLine());

                    switch(OpcionPago)
                    {
                        case 0:
                            Console.WriteLine("Seleccione metodo de pago:");
                            break;
                        case 1:
                            Console.WriteLine("Opión de pago no valida.");
                            break;
                    }
                }
                break; //Salimos del bucle al encontrarse el producto.
            }
            
            if(!productoEncontrado)
            {
                Console.WriteLine("Ha introducido un ID erróneo. Vuelva a intentarlo.");
            }
        }




    }
}
