using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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
            Admin admin = new Admin("Admin", "Admin");

            Cliente cliente = new Cliente();
            int opcion = 0;
            do
            {


                Console.WriteLine(".      Para comenzar seleccione una opcion:");
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║            Máquina expendedora             ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("║  1 | Comprar un producto                   ║");
                Console.WriteLine("║  2 | Mostrar informacion de un producto    ║");
                Console.WriteLine("║  3 | Cargar productos de manera individual ║");
                Console.WriteLine("║  4 | Cargar productos a tope               ║");
                Console.WriteLine("║  5 | Salir                                 ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        AñadirContenido();
                        break;

                    case 2:
                        cliente.VerProductos(listaproductos);
                        break;

                    case 3:
                        bool Respusta = admin.IniciarSesion();
                        if (Respusta == true)
                        {
                            Console.WriteLine("Contraseña correcta !!!!");
                            admin.AñadirContenido(ref listaproductos);

                        }
                        else if (Respusta == false)
                        {
                            Console.WriteLine("Contraseña incorrecta !!!!");
                        }
                        break;


                    case 4:
                        bool respusta = admin.IniciarSesion();
                        if (respusta == true)
                        {
                            Console.WriteLine("Contraseña correcta !!!!");


                        }
                        else if (respusta == false)
                        {
                            Console.WriteLine("Contraseña incorrecta !!!!");
                        }
                        break;

                    default:
                        Console.WriteLine("Tu eres tonto? (jose manuel)");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
            if (opcion == 5)
            {
                Console.WriteLine("Gracias por todo gilipollas :)");
                Console.ReadKey();
            }
        }
        public static void AContIndividual()
        {

        }

        public static void AñadirContenido()
        {
            int opcion = 0;
            Console.Clear();
            Console.WriteLine("¿Que desea comprar?: ");
            Console.WriteLine("1. Producto Electronico. ");
            Console.WriteLine("2. Producto Alimenticio");
            Console.WriteLine("3. Producto Material Precioso");
            Console.WriteLine(" Introduzca opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Product_Electronica p = new Product_Electronica();
                    p.AddProducto();
                    break;
                case 2:
                    Product_Alimentos d = new Product_Alimentos();
                    d.AddProducto();
                    break;
                case 3:
                    Product_MaterialesPrecios f = new Product_MaterialesPrecios();
                    f.AddProducto();
                    break;

            }

        }

        static void Salir()
        {
            FileStream fs = new FileStream($"Productos.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Product_General c in listaproductos)
            {

            }
            sw.Close();
        }

        public static void ComprarProducto()
        {
            Console.WriteLine("Introduce el Id del producto a comprar: ");
            int Idproducto = int.Parse(Console.ReadLine());
            bool productoEncontrado = false;

            foreach (Product_General producto in listaproductos)
            {
                if (producto.Id == Idproducto)
                {
                    productoEncontrado = true;

                    // Mostramos información del producto.
                    Console.WriteLine("Producto seleccionado: ");
                    Console.WriteLine(producto.SInfo());

                    // Gestionamos la opción de pago.
                    Console.WriteLine("Seleccione método de pago:");
                    Console.WriteLine("1 - Efectivo");
                    Console.WriteLine("2 - Tarjeta");
                    int OpcionPago = int.Parse(Console.ReadLine());

                    switch (OpcionPago)
                    {
                        case 1:
                            Pago_Efectivo pagoEfectivo = new Pago_Efectivo();
                            pagoEfectivo.RealizarPago(producto.Precio);
                            break;
                        case 2:
                            Console.WriteLine("Introduce el número de tarjeta:");
                            string numeroTarjeta = Console.ReadLine();
                            Console.WriteLine("Introduce el nombre del titular:");
                            string nombreTitular = Console.ReadLine();
                            Console.WriteLine("Introduce la fecha de expiración (MM/YY):");
                            string fechaExpiracion = Console.ReadLine();
                            Console.WriteLine("Introduce el código de seguridad:");
                            int codigoSeguridad = int.Parse(Console.ReadLine());

                            Pago_Tarjeta pagoTarjeta = new Pago_Tarjeta();
                            pagoTarjeta.RealizarPago(producto.Precio);
                            break;
                        default:
                            Console.WriteLine("Opción de pago no válida.");
                            break;
                    }
                }
                break; // Salimos del bucle al encontrar el producto.
            }

            if (!productoEncontrado)
            {
                Console.WriteLine("Ha introducido un ID erróneo. Vuelva a intentarlo.");
            }
        }





    }
}
