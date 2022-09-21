using Parcial.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Parcial.Login
{
    public class UserManager
    {
        private List<Usuario> users;

        public List<Usuario> Users {
            get
            {
                return users;
            }
        }

        public UserManager()
        {
            this.users = new List<Usuario>();
        }

        public bool TryRegistrarUsuario(string nombreCompleto, string username, string password)
        {
            Validador.ValidarStringVacia(username);
            Validador.ValidarStringVacia(password);
            Validador.ValidarStringAlfabetica(nombreCompleto);

            if(BuscarPorUsuario(username)!=null)
            {
                throw new Exception("El nombre de usuario ingresado esta en uso.");
            }

            string hashedPassword = Hasher.HashText(password, SHA512.Create());

            Usuario newUser = new Usuario(nombreCompleto, username, hashedPassword);

            users.Add(newUser);
            return true;
        }

        public bool VerificarPassword(string username, string password)
        {
            Usuario user = BuscarPorUsuario(username);

            if (user == null)
            {
                return false;
            }

            string hashedPassword = Hasher.HashText(password, SHA512.Create());
            return hashedPassword == user.Password;
        }

        public Usuario BuscarPorUsuario(string username)
        {
            Usuario userMatch = null;
            foreach (Usuario user in this.users)
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
