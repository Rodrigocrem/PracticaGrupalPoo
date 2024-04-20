using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Admin
    {
        public string NickName { get; set; }
        public string Password { get; set; }

        public Admin() { }

        public Admin(string nickName, string password)
        {
            NickName = nickName;
            Password = password;
        }

        public void Menu()
        {

        }
        public void AñadirContenido(ref List<Product_General> ListaProductos)
        {

            int opcion = 0;
            Console.Clear();
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1. Añadir producto electronico. ");
            Console.WriteLine("2. Añadir producto alimenticio");
            Console.WriteLine("3. Añadir producto material precioso");
            Console.WriteLine(" Introduzca opcion: ");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Product_Electronica product_Electronica = new Product_Electronica();
                    product_Electronica.AddProducto();
                    ListaProductos.Add(product_Electronica);
                    break;

                case 2:
                    Product_Alimentos product_Alimentos = new Product_Alimentos();
                    product_Alimentos.AddProducto();
                    ListaProductos.Add(product_Alimentos);
                    break;

                case 3:
                    Product_MaterialesPrecios product_MaterialesPrecios = new Product_MaterialesPrecios();
                    product_MaterialesPrecios.AddProducto();
                    ListaProductos.Add(product_MaterialesPrecios);
                    break;


                default:

                    break;
            }
            Console.WriteLine("Pulse una tecla para continuar: ");
            Console.ReadKey();
        }

        public bool IniciarSesion()
        {
            Console.WriteLine("Introduce el usuario: ");
            string nickname = Console.ReadLine();
            Console.WriteLine("Introduce tu contraseña: ");
            string password = Console.ReadLine();

            if (NickName == nickname && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}

