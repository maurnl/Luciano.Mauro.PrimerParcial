using Parcial.Entities;
using Parcial.Util;
using System.Security.Cryptography;

namespace Parcial.Login
{
    public class Usuario : PersonaBase
    {
        private static int contadorUsuario;
        private string username;
        private string password;

        static Usuario()
        {
            Usuario.contadorUsuario = 100;
        }
        private Usuario(string nombreCompleto) : base(nombreCompleto)
        {   
            base.id = Usuario.contadorUsuario;
            Usuario.contadorUsuario++;
        }
        public Usuario(string nombreCompleto,string username, string password) : this(nombreCompleto)
        {
            this.username = username;
            this.password = password;
        }

        public override int Id
        {
            get
            {
                return base.id;
            }
        }
        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                this.username = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                this.password = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Usuario: {this.username}";
        }
        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario is not null && usuario.id == this.id;
        }
        public override int GetHashCode()
        {
            return (this.id, this.username, this.password).GetHashCode();
        }
    }
}
