using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class PersonBase
    {
        protected int id;
        private string name;
        private string lastName;

        public int Id
        {
            get
            {
                return this.id;
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

        public PersonBase(string fullName)
        {
            this.FullName = fullName;
        }
        public override string ToString()
        {
            return $"Nombre completo: {FullName}.";
        }
    }
}
