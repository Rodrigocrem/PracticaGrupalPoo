﻿using System;
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
        static List<Usuarios> listaUsuarios = new List<Usuarios>();


        static void Main(string[] args)
        {
            Admin admin = new Admin(0, "admin", "Admin", listaproductos);
           
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
                switch(opcion)
                {
                    case 1:
                        AñadirContenido();
                        break;
                    case 2:
                        //
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        IniciarSesion();
                        break;
                    case 5:
                        IniciarSesion();
                        break;
                    case 6://Salir.
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != 6);
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
                    p.MInfo();
                    break;
                case 2:
                    Product_Alimentos d = new Product_Alimentos();
                    d.MInfo();
                    break;
                case 3:
                    Product_MaterialesPrecios f = new Product_MaterialesPrecios();
                    f.MInfo();
                    break;

            }

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

                            Pago_Tarjeta pagoTarjeta = new Pago_Tarjeta(numeroTarjeta, nombreTitular, fechaExpiracion, codigoSeguridad);
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

        public static void IniciarSesion()
        {
            Console.WriteLine("Introduce el usuario: ");
            string nickname = Console.ReadLine();
            Console.WriteLine("Introduce tu contraseña: ");
            string password = Console.ReadLine();
            bool usuarioEncontrado = false;
            foreach (Usuarios usuario in listaUsuarios)
            {
                if (usuario.Login(nickname, password))
                {
                    usuarioEncontrado = true;
                    usuario.Menu();
                    break;
                }
            }
            if (!usuarioEncontrado)
            {
                Console.WriteLine("Usuario o contraseña incorrectos.");
            }
        }
        


    }
}
