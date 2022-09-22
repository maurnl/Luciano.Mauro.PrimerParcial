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
        private float duracionEnHoras;
        private List<Pasajero> pasajeros;
        private DateTime fechaSalida;
        private bool viajeFinalizado;

        public bool ViajeFinalizado
        {
            get
            {
                return this.viajeFinalizado;
            }
            set
            {
                this.viajeFinalizado = value;
            }
        }
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
                return precioPasaje + (precioPasaje * 20 / 100);
            }
        }
        public float DuracionEnHoras
        {
            get
            {
                return this.duracionEnHoras;
            }
        }
        public int PasajerosABordo
        {
            get
            {
                return this.pasajeros.Count;
            }
        }
        public int PasajerosTuristasABordo
        {
            get
            {
                return ContarPasajerosPorTipo(TipoPasajero.Turista);
            }
        }
        public int PasajerosPremiumABordo
        {
            get
            {
                return ContarPasajerosPorTipo(TipoPasajero.Premium);
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
                return this.fechaSalida + TimeSpan.FromHours(duracionEnHoras);
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
            if (crucero.EstaEnViaje)
            {
                throw new Exception("El crucero elegido esta en viaje.");
            }
            base.id = Viaje.contadorViaje;
            Viaje.contadorViaje++;
            this.viajeFinalizado = false;
            this.origen = origen;
            this.destino = destino;
            this.crucero = crucero;
            this.crucero.EstaEnViaje = true;
            this.fechaSalida = fechaSalida;
            this.pasajeros = new List<Pasajero>();
            this.precioPasaje = CalcularPrecioDeViaje(destino);
            this.duracionEnHoras = CalcularDuracionDeViaje(destino);
        }

        public static Viaje operator +(Viaje viaje, Pasajero pasajero)
        {
            if(viaje.PasajerosABordo + 1 > viaje.crucero.CapacidadPasajeros)
            {
                throw new Exception("Este crucero esta lleno.");
            } 

            if(pasajero.TipoPasajero == TipoPasajero.Premium
                && viaje.PasajerosPremiumABordo + 1 > viaje.crucero.CapacidadPasajerosPremium)
            {
                throw new Exception("No hay mas asientos Premium");
            }

            if(pasajero.TipoPasajero == TipoPasajero.Turista
                && viaje.PasajerosTuristasABordo + 1 > viaje.crucero.CapacidadPasajerosTurista)
            {
                throw new Exception("No hay mas asientos Turista");
            }

            foreach (Equipaje valija in pasajero.Equipaje)
            {
                viaje.crucero += valija.Peso;
            }

            return viaje;
        }

        private int ContarPasajerosPorTipo(TipoPasajero tipoParam)
        {
            int contador = 0;
            foreach (Pasajero pasajero in this.pasajeros)
            {
                if(pasajero.TipoPasajero == tipoParam)
                {
                    contador++;
                }
            }
            return contador;
        }

        private float CalcularPrecioDeViaje(Puerto destino)
        {
            float precioViaje;
            if(destino.EsDestinoRegional)
            {
                precioViaje = 57;
            }
            else
            {
                precioViaje = 120;
            }
            return precioViaje;
        }
        private float CalcularDuracionDeViaje(Puerto destino)
        {
            TimeSpan intervaloAleatorio;
            if (destino.EsDestinoRegional)
            {
                intervaloAleatorio = TimeSpan.FromHours(Viaje.random.Next(72, 360));
            }
            else
            {
                intervaloAleatorio = TimeSpan.FromHours(Viaje.random.Next(480, 720));
            }
            return intervaloAleatorio.Hours;
        }

        public override string ToString()
        {
            return $"Viaje Id {this.id}. De {this.origen} a {this.destino} el dia {this.fechaSalida}";
        }
    }
}
