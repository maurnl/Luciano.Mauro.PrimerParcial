using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public abstract class PersonaBase : EntidadBase
    {
        private int dni;
        private string nombre;
        private string apellido;

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
                var nombreSeparado = value.Split(" ");
                this.nombre = nombreSeparado[0];
                this.apellido = nombreSeparado[1];
            }
        }

        public PersonaBase(string nombreCompleto, int dni)
        {
            this.NombreCompleto = nombreCompleto;
            this.dni = dni;
        }
        public override string ToString()
        {
            return $"DNI: {Dni}. Nombre: {NombreCompleto}.";
        }
    }
}
