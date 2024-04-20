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

        public Admin(int id, string nombre, string nickname, string password, List<Product_General> listaproductos)
            :base( id,  nombre,  nickname,  password, listaproductos)
        {
            
        }

        public override void Menu()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Que desea hacer?");    
                Console.WriteLine("1. Añadir Productos");
                Console.WriteLine("2. Eliminar Producto");
                Console.WriteLine("3. Ver Productos");              
                Console.WriteLine(" Introduzca opcion: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        AñadirContenido();
                        break;
                    case 2:
                        Console.WriteLine("--- P.Electronicos ---");
                        AddElectronicos();
                        Console.WriteLine("--- P.Alimenticios ---");
                        AddAlimenticios();
                        Console.WriteLine("--- M.Preciosos ---");
                        AddMPreciosos();
                        Console.WriteLine("Introduce el ID del contenido que quieres eliminar: ");
                        int id = int.Parse(Console.ReadLine());

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
            while (opcion != 5); 


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
        public Product_General BuscarProducto(int id)
        {
            Product_General  contenidoTemp = null;
            foreach (Product_General c in listaProductos)
            {
                if (c.Id == id)
                {
                    contenidoTemp = c; 
                    break;
                }
            }
            return contenidoTemp; 
        }
        public void EliminarProducto(Product_General c)
        {
            if (c != null) 
            {
               listaProductos.Remove(c);
               Console.WriteLine("Contenido eliminado");
            }
            else  
            {
              Console.WriteLine("No se ha encontrado un contenido con el ID introducido.");
            }
        }
        public void AddElectronicos()
        {
            Console.Clear();
            Console.WriteLine("--- Productos Electronicos ---");
            Console.WriteLine();
            foreach (Product_General c in listaProductos)
            {
                if ( c is Product_Electronica ) 
                {
                    Console.WriteLine(c.SInfo());
                }
            }
        }
        public void AddAlimenticios()
        {
            Console.Clear();
            Console.WriteLine("--- Productos Alimenticios ---");
            Console.WriteLine();
            foreach (Product_General c in listaProductos)
            {
                if (c is Product_Alimentos) 
                {
                    Console.WriteLine(c.SInfo());
                }
            }
        }
        public void AddMPreciosos()
        {
            Console.Clear();
            Console.WriteLine("--- Materiales preciosos ---");
            Console.WriteLine();
            foreach (Product_General c in listaProductos)
            {
                if (c is Product_MaterialesPrecios) 
                    Console.WriteLine(c.SInfo());
                
            }
        }     
    }   
}

