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

        public void Menu(ref List<Product_General> ListaProductos)
        {
            int opcion;
            Console.WriteLine("1-Agregar un tipo de producto a la maquina");
            Console.WriteLine("2-Eliminar un tipo de producto de la maquina");
            Console.WriteLine("3-Eliminar una unidad de un tipo de producto");
            Console.WriteLine("4-Agregar una unidad a un tipo de producto");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion){

                case 1:
                    AñadirContenido(ref ListaProductos);
                break;

                case 2:
                    EliminarUnProducto(ref ListaProductos);
                break;  

                case 3:

                break;

                case 4:
                    int ComprobacionUds = ComprobarCantidad(ListaProductos);
                    if(ComprobacionUds < 12){
                        AgregarUnidad(ref ListaProductos);
                    }else{
                        Console.WriteLine("La maquina esta llena, lo siento");
                    }
                break;

                default:
                    Console.WriteLine("Opcion introducida incorrecta, pulsa una tecla para continuar");
                    Console.ReadKey();
                break;
            }

            
        }

        public void AgregarUnidad(ref List<Product_General> ListaProductos){
            int UdsAdd;
            int cantidadTotal;
            Console.WriteLine("Introduce el Id del producto del que quieres agregar una unidad: ");
            int idAgrego = int.Parse(Console.ReadLine());
            foreach(Product_General p in ListaProductos){
                if(p.Id == idAgrego){

                    do{
                        Console.WriteLine("Introduce el numero de unidades que quieres agregar");
                        UdsAdd = int.Parse(Console.ReadLine());
                        cantidadTotal = ComprobarCantidad(ListaProductos);
                        if(UdsAdd + cantidadTotal >12){
                            Console.WriteLine("Lo siento, no podemos agregar esa cantidad a la maquina, no entrarian los productos!!!");
                        }else{
                            Console.WriteLine("Unidades agregadas con exito");
                        }
                    }while(UdsAdd + cantidadTotal >12);

                }
            }
        }

        public int ComprobarCantidad(List<Product_General> ListaProductos)
        {
            int cantidades = 0;
            foreach(Product_General produc in ListaProductos)
                {
                cantidades += produc.Cantidad;
            }
            return cantidades;
        }

        public void AñadirContenido(ref List<Product_General> ListaProductos)
        {
            int cantidades=0;
            cantidades=ComprobarCantidad(ListaProductos);

            if(cantidades<12)
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
                        product_Electronica.AddProducto(ref ListaProductos);
                        ListaProductos.Add(product_Electronica);
                        break;

                    case 2:
                        Product_Alimentos product_Alimentos = new Product_Alimentos();
                        product_Alimentos.AddProducto(ref ListaProductos);
                        ListaProductos.Add(product_Alimentos);
                        break;

                    case 3:
                        Produc_MaterialesPreciosos product_MaterialesPrecios = new Produc_MaterialesPreciosos();
                        product_MaterialesPrecios.AddProducto(ref ListaProductos);
                        ListaProductos.Add(product_MaterialesPrecios);
                        break;


                    default:

                        break;
                }
            }
            else
            {
                Console.WriteLine("Maquina llena, no se pueden añadir mas productos");
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
        /*La funcion CargarProductosFichero recuperara los datos del fichero productos.csv y segun el tipo de producto lo creara y lo añadira a la lista de productos pasada por referencia*/
        public void CargarProductosFichero(ref List<Product_General> ListaProductos)
        {
            HashSet<int> ids = new HashSet<int>();
            string Materiales="";
            double Peso=0;
            string nutritional_information="";
            bool has_battery=false;
            bool charged_by_default=false;
            int id = 0;
            using (FileStream fs = new FileStream($"Productos.csv", FileMode.Open, FileAccess.ReadWrite))
            using (StreamReader streamReader = new StreamReader(fs))
            {
                while (streamReader.Peek() != -1)
                {
                    string line = streamReader.ReadLine();
                    string[] parts = line.Split(';');
                    int product_type = int.Parse(parts[0]);
                    string product_name = parts[1];
                    int product_units = int.Parse(parts[2]);
                    double product_unit_prize = double.Parse(parts[3]);
                    string product_description = parts[4];
                    if (parts[5] != "")
                    {
                        Materiales = parts[5];
                    }
                    if (parts[6] != "")
                    {
                        Peso = double.Parse(parts[6]);
                    }
                    if (parts[7] != "")
                    {
                        nutritional_information = parts[7];
                    }
                    if (parts[8] != "")
                    {
                        charged_by_default = bool.Parse(parts[8]);
                    }
                    if (parts[9] != "")
                    {
                        has_battery = bool.Parse(parts[9]);
                    }

                    id++; 
                    

                    try
                    {
                        switch (product_type)
                        {
                            case 1:
                                Produc_MaterialesPreciosos product_MaterialesPreciosos = new Produc_MaterialesPreciosos(id, product_name, product_unit_prize, product_units, product_description, Materiales, Peso);
                                ListaProductos.Add(product_MaterialesPreciosos);
                                break;
                            case 2:
                                Product_Alimentos product_Alimentos = new Product_Alimentos(id, product_name, product_unit_prize, product_units, product_description, nutritional_information);
                                ListaProductos.Add(product_Alimentos);
                                break;
                            case 3:
                                Product_Electronica product_Electronica = new Product_Electronica(id, product_name, product_unit_prize, product_units, product_description, Materiales, has_battery, charged_by_default);
                                ListaProductos.Add(product_Electronica);
                                break;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
        }


        public void EliminarUnProducto(ref List<Product_General> ListaProductos)
        {
            int id = 0;
            Console.WriteLine("Introduce el id del producto que quieres eliminar: ");
            id = int.Parse(Console.ReadLine());
            foreach (Product_General produc in ListaProductos)
            {
                if (produc.Id == id)
                {
                    ListaProductos.Remove(produc);
                    break;
                }
            }
        }


    }
}

