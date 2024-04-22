using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MquinaDeVending
{
    internal class Program
    {
        static List<Product_General> listaproductos = new List<Product_General>();
        static List<Product_General> Carrito = new List<Product_General>();


        static void Main(string[] args)
        {
            Admin admin = new Admin("Admin", "Admin");

            Cliente cliente = new Cliente();
            int opcion = 0;
            do
            {
                Console.Clear();

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
                        ComprarProducto();
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
                            Console.WriteLine("Pulse INTRO para continuar...");
                            Console.ReadKey();
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
                            Console.WriteLine("Pulse INTRO para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
            if (opcion == 5)
            {
                Console.WriteLine("Gracias por todo");
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
                    Produc_MaterialesPreciosos f = new Produc_MaterialesPreciosos();
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
            bool productoEncontrado = false;
            int opcion = 0;
            bool pago = false;
            double preciocarrito = 0;
            do
            {
                Console.Clear();
                productoEncontrado = false;
                if (listaproductos.Count != 0)
                {
                    //Muestra la informacion de todos los productos para que el cliente elija el id a comprar
                    foreach (Product_General prod2 in listaproductos)
                    {
                        Console.WriteLine(prod2.SInfo());
                    }

                    Console.WriteLine("Introduce el Id del producto a comprar: ");
                    int Idproducto = int.Parse(Console.ReadLine());

                    foreach (Product_General producto in listaproductos)
                    {
                        if (producto.Id == Idproducto)
                        {
                            productoEncontrado = true;
                            Carrito.Add(producto);

                            // Mostramos información del producto.
                            Console.WriteLine("Producto seleccionado: ");
                            Console.WriteLine(producto.SInfo());

                            //Preguntamos si desea introducir otro id
                            Console.WriteLine("Desea seguir comprando");
                            Console.WriteLine("1- Si, desea añadir mas productos");
                            Console.WriteLine("2- No, pasar a proceso de pago");
                            Console.WriteLine("3- Cancela compra");
                            opcion = int.Parse(Console.ReadLine());

                            switch (opcion)
                            {
                                case 1:
                                    break;
                                case 2:
                                    // Gestionamos la opción de pago.
                                    Console.WriteLine("Seleccione método de pago:");
                                    Console.WriteLine("1 - Efectivo");
                                    Console.WriteLine("2 - Tarjeta");
                                    int OpcionPago = int.Parse(Console.ReadLine());
                                    foreach (Product_General carrito in Carrito)
                                    {
                                        preciocarrito += carrito.Precio;
                                    }
                                    switch (OpcionPago)
                                    {
                                        case 1:
                                            Pago_Efectivo pagoEfectivo = new Pago_Efectivo();
                                            pago = pagoEfectivo.RealizarPago(preciocarrito);
                                            if (pago == true)
                                            {

                                                foreach (Product_General productocarrito in listaproductos)
                                                {
                                                    foreach (Product_General carrito in Carrito)
                                                    {
                                                        if (carrito == producto)
                                                        {
                                                            productocarrito.Cantidad--;
                                                        }
                                                    }
                                                    if (productocarrito.Cantidad == 0)
                                                    {
                                                        listaproductos.Remove(producto);
                                                    }
                                                }

                                            }
                                            break;
                                        case 2:
                                            Pago_Tarjeta pagoTarjeta = new Pago_Tarjeta();
                                            pago = pagoTarjeta.RealizarPago(preciocarrito);
                                            foreach (Product_General productocarrito in listaproductos)
                                            {
                                                foreach (Product_General carrito in Carrito)
                                                {
                                                    if (carrito == producto)
                                                    {
                                                        productocarrito.Cantidad--;
                                                    }
                                                }
                                                if (productocarrito.Cantidad == 0)
                                                {
                                                    listaproductos.Remove(producto);
                                                }
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Opción de pago no válida.");
                                            break;
                                    }
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;

                            }
                        }
                    }

                    if (!productoEncontrado)
                    {
                        Console.WriteLine("Ha introducido un ID erróneo. Vuelva a intentarlo.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay productos disponibles");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadKey();
                    opcion = 3;
                }

            } while (opcion != 3);
            Carrito.Clear();

        }





    }
}
