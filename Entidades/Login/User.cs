using Parcial.Entities;

namespace Parcial.Login
{
    public class User : PersonBase
    {
        private static int entityCounter;
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

        static User()
        {
            User.entityCounter = 100;
        }
        private User(string fullName) : base(fullName)
        {   
            base.id = User.entityCounter;
            User.entityCounter++;
        }

        public User(string fullName, string username, string password) : this(fullName)
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
