using Parcial.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Parcial.Login
{
    public class UserManager
    {
        private List<User> users;

        public List<User> Users {
            get
            {
                return users;
            }
        }

        public UserManager()
        {
            this.users = new List<User>();
        }

        public bool TryRegisterUser(string fullName, string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Datos ingresados invalidos.");
            }

            if(FindByUsername(username)!=null)
            {
                throw new Exception("El nombre de usuario ingresado esta en uso.");
            }

            string hashedPassword = Hasher.HashText(password, SHA512.Create());

            User newUser = new User(username, hashedPassword, fullName);

            users.Add(newUser);
            return true;
        }

        public bool CheckPassword(string username, string password)
        {
            User user = FindByUsername(username);

            if (user == null)
            {
                return false;
            }

            string hashedPassword = Hasher.HashText(password, SHA512.Create());
            return hashedPassword == user.Password;
        }

        public User FindByUsername(string username)
        {
            User userMatch = null;
            if (!string.IsNullOrEmpty(username))
            {
                foreach (User user in this.users)
                {
                    if (user.Username == username)
                    {
                        userMatch = user;
                        break;
                    }
                }
            }
            return userMatch;
        }
    }
}
