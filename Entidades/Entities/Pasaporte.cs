using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Pasaporte
    {
        private int dni;
        private DateTime fechaExpedido;

        private Pasaporte(int dni, DateTime fechaExpedido)
        {
            this.dni = dni;
            this.fechaExpedido = fechaExpedido;
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public DateTime FechaVencimiento
        {
            get
            {
                return this.fechaExpedido + TimeSpan.FromDays(1460);
            }
        }

        public override string ToString()
        {
            return $"Fecha de vencimiento: {this.FechaVencimiento}";
        }
        public override int GetHashCode()
        {
            return (this.dni, this.fechaExpedido).GetHashCode();
        }

        /// <summary>
        /// Convierte implicitamente un valor entero a un objeto Pasaporte.
        /// </summary>
        /// <param name="dni">Valor de dni del pasaporte a crear</param>
        public static implicit operator Pasaporte(int dni)
        {
            return new Pasaporte(dni, DateTime.Now);
        }
    }
}
