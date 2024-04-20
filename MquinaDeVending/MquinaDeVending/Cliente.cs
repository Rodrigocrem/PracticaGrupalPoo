using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Cliente: Usuarios
    {
        private List<Product_General> Favoritos;

        public Cliente(List<Product_General> listProducto) : base(listProducto)
        {
            Favoritos = new List<Product_General>();
        }

        public Cliente(int id, string nickname, string nombre, string password, List<Product_General> listaProducto)
          : base(id, nickname, nombre, password, listaProducto)
        {
            Favoritos = new List<Product_General>();
        }

        public override void Menu()
        {
            Favoritos.Clear();
            CargarFavoritos();

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
                                Console.WriteLine("producto eliminado de favoritos.");
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
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (opcion != 4);
        }

        public override void Salir()
        {
            
            StreamWriter sw = new StreamWriter($"favoritos_{Nickname}.txt");
            foreach (Product_General c in Favoritos)
            {
                sw.WriteLine(c.Id); 
            }
            sw.Close();
        }

        public void CargarFavoritos()
        {
           
            if (File.Exists($"favoritos_{Nickname}.txt"))
            {
                StreamReader sr = new StreamReader($"favoritos_{Nickname}.txt");
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    int id = int.Parse(linea);
                    Product_General producto = listaProductos.Find(c => c.Id == id);
                    if (producto != null)
                    {
                        Favoritos.Add(producto);
                    }
                }
                sr.Close();
            }
        }   
    }
}

