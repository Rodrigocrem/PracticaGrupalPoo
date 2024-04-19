using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Admin:Usuarios
    {
        public Admin(List<Product_General> content):base(content) { }

        public Admin(int id, string nombre, string password, List<Product_General> listaproductos)
        {
            Id = id;
            Nombre = nombre;
            Password = password;
            listaProductos = listaproductos;
        }

        public override void Menu()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1. Añadir producto electronico. ");
                Console.WriteLine("2. Añadir producto alimenticio");
                Console.WriteLine("3. Añadir producto material precioso");
                Console.WriteLine(" Introduzca opcion: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1: 
                        break;
                    case 2: 
                        break;
                    case 3: 
                        break;
                    case 4: 
                        break;
                    case 5: 
                        break;
                    default:
                        break;

                }
            }
            while (true) 


        }
        public void AñadirContenido()
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
                    case 1: //Añadir Producto 1.
                        

                        break;
                    case 2: //Añadir Producto 2.

                        break;
                    case 3: //Añadir Producto 2.
                        break;
                    case 4:
                        break;
                    default:
                        
                        break;
                }
            Console.WriteLine("Pulse una tecla para continuar: ");
            Console.ReadKey();

        }


    }
}
