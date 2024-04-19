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
        public int Id { get; private set; }
        public string Nickname { get; private set; }
        public string Nombre { get; private set; }
        private string Password { get; set; }

        protected List<Product_General> listaProductos;

        public Usuarios(List<Product_General> content)
        {
            listaProductos = content;
        }
        public Usuarios(int id, string nombre, string nickname, string password, List<Product_General> listaproductos)
        {
            Id = id;
            Nombre = nombre;
            Nickname = nickname;
            Password = password;
            listaProductos = listaproductos;
        }
        public string GetRealName()
        {
            return $"{Nombre}";
        }

        public bool Login()
        {
            Console.WriteLine("Introduce usuario:");
            string UsuarioComprobar = Console.ReadLine();
            Console.WriteLine("Introduce la contraseña:");
            string ContraseñaComprobar = Console.ReadLine();
            if (UsuarioComprobar == Nickname && ContraseñaComprobar == Password)
            {
                return true;
            }
            return false;
        }
        public void ToFile()
        {

            //Abrimos el archivo en modo append, para sobreescribir los datos existentes.
            StreamWriter sw = new StreamWriter("usuarios.txt", true);
            sw.WriteLine($"{Id};{Nickname};{Nombre};{Password}");
            sw.Close();
        }
        public abstract void Menu();
        public abstract void Salir();

    }
}
