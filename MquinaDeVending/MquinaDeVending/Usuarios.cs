using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal abstract class Usuarios
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        private string Password { get; set; }

        protected List<Product_General> listaProductos;

        public Usuarios(List<Product_General>content) 
        { 
            listaProductos = content;
        }
        public Usuarios(int id, string nombre, string password, List<Product_General> listaproductos)
        {
            Id = id;
            Nombre = nombre;
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
    }
}
