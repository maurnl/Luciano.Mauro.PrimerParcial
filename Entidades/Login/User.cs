namespace Parcial.Login
{
    public class User
    {
        private static int entityCounter;
        private int id;
        private string username;
        private string password;
        private string name;
        private string lastName;
        public int Id { 
            get
            {
                return this.id;
            }
            private set 
            { 
                this.id = value; 
            } 
        }
        public string FullName
        {
            get
            { 
                return $"{this.name} {this.lastName}"; 
            }
            private set
            {
                string[] splitName = value.Split(" ");
                name = splitName[0];
                lastName = splitName[1];
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

        static User()
        {
            User.entityCounter = 100;
        }
        public User()
        {
            this.Id = User.entityCounter;
            User.entityCounter++;
            this.FullName = "unnamed user";
        }

        public User(string username, string password) : this()
        {
            this.username = username;
            this.password = password;
        }
        public User(string username, string password, string fullName) : this(username, password)
        {
            this.FullName = fullName;
        }

        public override string ToString()
        {
            return $"NOMBRE Y APELLIDO: {FullName}";
        }
    }
}
