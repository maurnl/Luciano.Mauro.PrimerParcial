using Parcial.Entities;

namespace Parcial.Login
{
    public class Usuario : PersonaBase
    {
        private static int contadorUsuario;
        private string username;
        private string password;
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

        public override string ToString()
        {
            return $"{base.ToString()} Usuario: {this.username}";
        }
    }
}
