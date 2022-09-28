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

        private Pasaporte(int dni, DateTime fechaExpedido)
        {
            this.dni = dni;
            this.fechaExpedido = fechaExpedido;
        }

        public static implicit operator Pasaporte(int dni)
        {
            return new Pasaporte(dni, DateTime.Now);
        }

        public override string ToString()
        {
            return $"Fecha de vencimiento: {this.FechaVencimiento}";
        }

        public override int GetHashCode()
        {
            return (this.dni, this.fechaExpedido).GetHashCode();
        }
    }
}
