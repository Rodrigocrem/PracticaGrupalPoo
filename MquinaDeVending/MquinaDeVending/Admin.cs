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
        public int Id { get; private set; }
        public string Nickname { get; private set; }
        public string Nombre { get; private set; }
        private string Password { get; set; }

        protected List<Product_General> listaroductos;


        public Admin(List<Product_General> contenidos)
        {
            listaProductos = contenidos;
        }

        public Admin(int id, string nickname, string password, List<Product_General> listaproductos)
        {
            Id = id;
            Nickname = nickname;
            Password = password;
            listaProductos = listaproductos;
        }

        

        public bool Login(string nickname, string password) //Login(string nickname, string password), que devolverá true si el usuario y contraseña es correcto, false en caso contrario
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
            //Abrimos el archivo en modo append, para sobreescribir los datos existentes.
            StreamWriter sw = new StreamWriter("usuarios.txt", true);
            sw.WriteLine($"{Nickname};{Nombre};{Password}");
            sw.Close();
        }

        public abstract void Menu();
        public abstract void Salir();
    }
}
