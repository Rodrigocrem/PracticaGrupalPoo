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


        public void Menu()
        {


            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Ver favoritos");
                Console.WriteLine("2. Añadir favoritos.");
                Console.WriteLine("3. Eliminar favoritos.");
                Console.WriteLine("4. Salir");
                Console.Write("Opcion: ");
                try
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Favoritos: ");
                            foreach (Product_General c in Favoritos)
                            {
                                Console.WriteLine(c.SInfo());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Añadir favoritos: ");
                            Console.WriteLine("Id del producto a añadir a favoritos: ");
                            int id = int.Parse(Console.ReadLine());


                            Product_General foundProduct = listaProductos.Find(c => c.Id == id);

                            if (foundProduct != null)
                            {
                                Favoritos.Add(foundProduct);
                                Console.WriteLine($"{foundProduct.Nombre} se ha añadido a favoritos.");
                            }
                            else
                            {
                                Console.WriteLine("No se ha encontrado un producto con el ID introducido.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Id del producto a eliminar de favoritos: ");
                            int idcontenido = int.Parse(Console.ReadLine());
                            Product_General contenido = Favoritos.Find(c => c.Id == idcontenido);
                            if (contenido != null)
                            {
                                Favoritos.Remove(contenido);
                                Console.WriteLine("Producto eliminado de favoritos.");
                            }
                            else
                            {
                                Console.WriteLine("Producto no encontrado.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Opción inválida. Por favor, ingrese un número valido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

            } while (opcion != 4);
        }


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

