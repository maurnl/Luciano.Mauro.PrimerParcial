using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Pasaporte
    {
        private int numeroPasaporte;
        private DateTime fechaExpedido;

        private Pasaporte(int numeroPasaporte, DateTime fechaExpedido)
        {
            this.numeroPasaporte = numeroPasaporte;
            this.fechaExpedido = fechaExpedido;
        }

        public int NumeroPasaporte
        {
            get
            {
                return this.numeroPasaporte;
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
            return (this.numeroPasaporte, this.fechaExpedido).GetHashCode();
        }

        /// <summary>
        /// Convierte implicitamente un valor entero a un objeto Pasaporte.
        /// </summary>
        /// <param name="numeroPasaporte">Valor de numero del pasaporte a crear</param>
        public static implicit operator Pasaporte(int numeroPasaporte)
        {
            return new Pasaporte(numeroPasaporte, DateTime.Now);
        }
    }
}
