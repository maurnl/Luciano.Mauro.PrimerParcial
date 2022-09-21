using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Viaje : EntidadBase
    {
        private static int contadorViaje;
        private static Random random;
        private Puerto origen;
        private Puerto destino;
        private Crucero crucero;
        private float precioPasaje;
        private float duracion;
        private List<Pasajero> pasajeros;
        private DateTime fechaSalida;

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
        public float Duracion
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
                return this.fechaSalida;
            }
        }
        public DateTime Llegada
        {
            get
            {
                return this.fechaSalida + TimeSpan.FromHours(duracion);
            }
        }

        static Viaje()
        {
            Viaje.random = new Random();
            Viaje.contadorViaje = 5000;
        }

        public Viaje(Puerto origen, Puerto destino, Crucero crucero, DateTime fechaSalida)
        {
            if(origen == destino)
            {
                throw new Exception("El origen y el destino no deben coincidir.");
            }
            base.id = Viaje.contadorViaje;
            Viaje.contadorViaje++;
            this.origen = origen;
            this.destino = destino;
            this.crucero = crucero;
            this.fechaSalida = fechaSalida;
            this.duracion = GenerarDuracionDeViaje(origen, destino);
        }

        private float GenerarDuracionDeViaje(Puerto origen, Puerto destino)
        {
            TimeSpan intervaloAleatorio;
            if (origen.Pais == Pais.Argentina && origen.Pais != destino.Pais)
            {
                intervaloAleatorio = TimeSpan.FromMinutes(Viaje.random.Next(480, 720));
            }
            else
            {
                intervaloAleatorio = TimeSpan.FromMinutes(Viaje.random.Next(60, 240));
            }
            return intervaloAleatorio.Hours;
        }
    }
}
