using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                    Produc_MaterialesPreciosos product_MaterialesPrecios = new Produc_MaterialesPreciosos();
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

        public void CargarProductosFichero()
        {
            FileStream fs = new FileStream($"example_vending_file_practical_work_i.csv", FileMode.Open, FileAccess.Read); //Abrimos el fichero. 
            int id = 0;
            StreamReader streamReader = new StreamReader(fs);
            while (streamReader.Peek() != -1)
            {
                id++;
                string line = streamReader.ReadLine();
                string[] parts = line.Split(';');
                int product_type = int.Parse(parts[0]);
                string product_name = parts[1];
                int product_units = int.Parse(parts[2]);
                double product_unit_prize = double.Parse(parts[3]);
                string product_description = parts[4];
                string Materiales = parts[5];
                int Peso = int.Parse(parts[6]);
                string nutritional_information = parts[7];
                bool has_battery = bool.Parse(parts[8]);
                bool charged_by_default = bool.Parse(parts[9]);


                switch (product_type)
                {
                    case 1:
                        Produc_MaterialesPreciosos product_MaterialesPreciosos = new Produc_MaterialesPreciosos(id, product_name, product_unit_prize, product_units, product_description, Materiales, Peso);
                        break;
                    case 2:
                        Product_Alimentos product_Alimentos = new Product_Alimentos(id, product_name, product_unit_prize, product_units, product_description, nutritional_information);
                        break;
                    case 3:
                        Product_Electronica product_Electronica = new Product_Electronica(id, product_name, product_unit_prize, product_units, product_description, Materiales, has_battery, charged_by_default);
                        break;

                }







            }
        }


    }
}

