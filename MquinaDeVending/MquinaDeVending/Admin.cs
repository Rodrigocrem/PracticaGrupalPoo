using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Admin
    {
        public string Nickname { get; set; }
        public string Password { get; set; }

        public Admin( string nickname, string password)
        {
            Nickname = nickname;
            Password = password;
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
    }
}
