using Parcial.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Parcial.Login
{
    public static class SistemaUsuarios
    {
        private static List<Usuario> users;

        static SistemaUsuarios()
        {
            SistemaUsuarios.users = new List<Usuario>();
            SistemaUsuarios.AgregarUsuario(new Usuario("Mauro Luciano", "maurnl", "contrasenia123"));
        }

        public static void AgregarUsuario(Usuario user)
        {
            if(BuscarPorNombreDeUsuario(user.Username) != null)
            {
                throw new Exception("El nombre de usuario ingresado esta en uso.");
            }
            SistemaUsuarios.users.Add(user);
        }
        public static bool VerificarPassword(string username, string password)
        {
            Usuario user = BuscarPorNombreDeUsuario(username);

            if (user == null)
            {
                return false;
            }

            return password == user.Password;
        }
        public static Usuario BuscarPorNombreDeUsuario(string username)
        {
            Usuario userMatch = null;
            foreach (Usuario user in SistemaUsuarios.users)
            {
                if (user.Username == username)
                {
                    userMatch = user;
                    break;
                }
            }
            return userMatch;
        }
    }
}
