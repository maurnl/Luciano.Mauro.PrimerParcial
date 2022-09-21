using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Viaje
    {
        private static int contadorViaje;
        private static Random random;
        private int duracion;
        private float precioPasaje;
        private Puerto origen;
        private Puerto destino;
        private Crucero crucero;
        private List<Pasajero> pasajeros;
        private DateTime salida;
        private DateTime llegada;

        public Puerto Origen
        {
            get
            {
                return this.origen;
            }
        }
        public Puerto Destino
        {
            get
            {
                return this.destino;
            }
        }
        public Crucero Crucero
        {
            get
            {
                return this.crucero;
            }
        }
        public float PrecioTurista
        {
            get
            {
                return this.precioPasaje;
            }
        }
        public float PrecioPremium
        {
            get
            {
                return precioPasaje + (precioPasaje * 15 / 100);
            }
        }
        public int Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public int PasajerosABordo
        {
            get
            {
                return this.pasajeros.Count;
            }
        }
        public List<Pasajero> Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
        }
        public DateTime Salida
        {
            get
            {
                return this.salida;
            }
        }
        public DateTime Llegada
        {
            get
            {
                return this.llegada;
            }
        }

    }
}
