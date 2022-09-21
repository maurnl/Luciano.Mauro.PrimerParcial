using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class PersonaBase
    {
        protected int id;
        private int dni;
        private string nombre;
        private string apellido;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return $"{this.nombre} {this.apellido}";
            }
            private set
            {
                var splitName = value.Split(" ");
                this.nombre = splitName[0];
                this.apellido = splitName[1];
            }
        }

        public PersonaBase(string fullName, int dni)
        {
            this.NombreCompleto = fullName;
            this.dni = dni;
        }
        public override string ToString()
        {
            return $"DNI: {Dni}. Nombre completo: {NombreCompleto}.";
        }
    }
}
