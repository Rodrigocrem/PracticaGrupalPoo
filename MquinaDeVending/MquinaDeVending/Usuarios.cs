using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal abstract class Usuarios
    {
        public int Id { get; private set; }
        public string Nickname { get; private set; }
        private string Password { get; set; }
        public string Nombre { get; private set;}
       

        protected List<Product_General> listaProductos;


        public Usuarios(List<Product_General> Productos)
        {
            listaProductos = Productos;
        }

        public Usuarios(int id, string nickname, string nombre, string password, List<Product_General> contenidos)
        {
            Id = id;
            Nickname = nickname;
            Nombre = nombre;
            Password = password;
            listaProductos = contenidos;
        }

        public string GetRealName()
        {
            return $"{Nombre}";
        }

        public bool Login(string nickname, string password) 
        {
            if (Nickname == nickname && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ToFile()
        {
            
            StreamWriter sw = new StreamWriter("usuarios.txt", true);
            sw.WriteLine($"{Id};{Nickname};{Nombre};{Password}");
            sw.Close();
        }

        public abstract void Menu();
        public abstract void Salir();
    }
}
