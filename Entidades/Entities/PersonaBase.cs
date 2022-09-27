using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public abstract class PersonaBase : EntidadBase
    {
        private string nombre;
        private string apellido;

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

        public PersonaBase(string nombreCompleto)
        {
            this.NombreCompleto = nombreCompleto;
        }
        public override string ToString()
        {
            return $"Nombre: {NombreCompleto}.";
        }

        public override int GetHashCode()
        {
            return (this.nombre, this.apellido).GetHashCode();
        }
    }
}
