using Parcial.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Parcial.Login
{
    public class SistemaUsuarios
    {
        private List<Usuario> users;

        public List<Usuario> Users {
            get
            {
                return users;
            }
        }

        public SistemaUsuarios()
        {
            this.users = new List<Usuario>();
        }

        public Usuario TryCrearUsuario(string nombreCompleto, string username, string password)
        {
            Validador.ValidarStringVacia(username);
            Validador.ValidarStringVacia(password);
            Validador.ValidarStringAlfabetica(nombreCompleto);

            if(BuscarPorNombreDeUsuario(username)!=null)
            {
                throw new Exception("El nombre de usuario ingresado esta en uso.");
            }

            string hashedPassword = Hasher.HashText(password, SHA512.Create());

            Usuario nuevoUsuario = new Usuario(nombreCompleto, username, hashedPassword);

            this.users.Add(nuevoUsuario);

            return nuevoUsuario;
        }

        public bool VerificarPassword(string username, string password)
        {
            Usuario user = BuscarPorNombreDeUsuario(username);

            if (user == null)
            {
                return false;
            }

            string hashedPassword = Hasher.HashText(password, SHA512.Create());
            return hashedPassword == user.Password;
        }

        public Usuario BuscarPorNombreDeUsuario(string username)
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
