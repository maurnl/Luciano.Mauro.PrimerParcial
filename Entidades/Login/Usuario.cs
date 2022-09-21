using Parcial.Entities;

namespace Parcial.Login
{
    public class Usuario : PersonaBase
    {
        private static int contadorEntidad;
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
            Usuario.contadorEntidad = 100;
        }
        private Usuario(string nombreCompleto, int dni) : base(nombreCompleto, dni)
        {   
            base.id = Usuario.contadorEntidad;
            Usuario.contadorEntidad++;
        }

        public Usuario(string nombreCompleto,int dni, string username, string password) : this(nombreCompleto, dni)
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
