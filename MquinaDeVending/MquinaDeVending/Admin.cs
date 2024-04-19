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

        protected List<Product_General> listaProductos;


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

        

        public bool Login() //Login(string nickname, string password), que devolverá true si el usuario y contraseña es correcto, false en caso contrario
        {
            Console.WriteLine("Introduce usuario:");
            string UsuarioComprobar = Console.ReadLine();
            Console.WriteLine("Introduce la contraseña:");
            string ContraseñaComprobar = Console.ReadLine();
            if(UsuarioComprobar==Nickname && ContraseñaComprobar==Password)
            {
                return true;
            }
            return false;
        }
    }
}
