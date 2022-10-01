﻿    using System;
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
        private DateTime fechaActual;
        private Puerto origen;
        private Puerto destino;
        private Crucero crucero;
        private float precioPasajePorHora;
        private float duracionEnHoras;
        private List<Pasajero> pasajeros;
        private DateTime fechaSalida;
        private EstadoDeViaje estadoDeViaje;

        static Viaje()
        {
            Viaje.random = new Random();
            Viaje.contadorViaje = 5000;
        }
        public Viaje(Puerto origen, Puerto destino, Crucero crucero, DateTime fechaSalida)
        {
            if (origen.Equals(destino))
            {
                throw new Exception("El origen y el destino no deben coincidir.");
            }
            if (crucero.EstaEnViaje)
            {
                throw new Exception("El crucero elegido esta en viaje.");
            }
            base.id = Viaje.contadorViaje;
            Viaje.contadorViaje++;
            this.estadoDeViaje = EstadoDeViaje.Abordando;
            this.origen = origen;
            this.destino = destino;
            this.crucero = crucero;
            this.crucero.EstaEnViaje = true;
            this.fechaSalida = fechaSalida;
            this.fechaActual = SistemaCruceros.fechaDelSistema;
            this.pasajeros = new List<Pasajero>();
            this.precioPasajePorHora = CalcularPrecioDeViaje(destino);
            this.duracionEnHoras = CalcularDuracionDeViaje(destino);
        }

        /// <summary>
        /// Indexador para Viaje. Retorna el pasajero correspondiente al indice de la lista de pasajeros.
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public Pasajero this[int indice]
        {
            get
            {
                Pasajero pasajero = null;
                if (indice >= 0 && indice < this.pasajeros.Count)
                {
                    pasajero = this.pasajeros[indice];
                }
                return pasajero;
            }
        }
        public override int Id
        {
            get
            {
                return base.id;
            }
        }
        public EstadoDeViaje EstadoDeViaje
        {
            get
            {
                return this.estadoDeViaje;
            }
            set
            {
                this.estadoDeViaje = value;
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
            set
            {
                this.destino = value;
                this.precioPasajePorHora = CalcularPrecioDeViaje(this.destino);
                this.duracionEnHoras = CalcularDuracionDeViaje(this.destino);
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
                return this.precioPasajePorHora * this.duracionEnHoras;
            }
        }
        public float PrecioPremium
        {
            get
            {
                return this.PrecioTurista + (this.PrecioTurista * 20 / 100);
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
        public DateTime FechaSalida
        {
            get
            {
                return this.fechaSalida;
            }
            set
            {
                this.fechaSalida = value;
            }
        }
        public DateTime FechaLlegada
        {
            get
            {
                return this.fechaSalida + TimeSpan.FromHours(duracionEnHoras);
            }
        }
        public string OfreceGimnasio
        {
            get
            {
                return this.crucero.TieneGimnasio ? "SI" : "NO";
            }
        }
        public string OfrecePiscina
        {
            get
            {
                return this.crucero.TienePiscina ? "SI" : "NO";
            }
        }

        /// <summary>
        /// Suma un lapso de tiempo a la instancia de Viaje y actualiza la informacion del viaje
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="tiempo">Lapso de tiempo a sumar</param>
        /// <returns></returns>
        public static Viaje operator +(Viaje viaje, TimeSpan tiempo)
        {
            viaje.fechaActual += tiempo;
            if (viaje.fechaActual >= viaje.fechaSalida && viaje.fechaActual < viaje.FechaLlegada)
            {
                viaje.estadoDeViaje = EstadoDeViaje.EnCurso;
            }
            else if (viaje.fechaActual >= viaje.FechaLlegada)
            {
                viaje.EstadoDeViaje = EstadoDeViaje.Finalizado;
                viaje.crucero.EstaEnViaje = false;
                int cantidadPasajeros = viaje.pasajeros.Count;
                for (int i = cantidadPasajeros - 1; i >= 0; i--)
                {
                    Pasajero pasajero = viaje.pasajeros[i];
                    for (int j = pasajero.CantidadEquipaje - 1; j >= 0; j--)
                    {
                        viaje.crucero += (-pasajero[j].Peso);
                        pasajero -= pasajero[j];
                    }
                    pasajero.EstaViajando = false;
                }
                viaje.destino += viaje.PasajerosABordo;
            }
            return viaje;
        }
        /// <summary>
        /// Agrega el Pasajero a la lista de pasajeros del viaje.
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="pasajero"></param>
        /// <returns></returns>
        public static Viaje operator +(Viaje viaje, Pasajero pasajero)
        {
            if (viaje == pasajero)
            {
                throw new Exception("Este pasajero ya esta a bordo.");
            }

            if (viaje.PasajerosABordo + 1 > viaje.crucero.CapacidadPasajeros)
            {
                throw new Exception("Este crucero esta lleno.");
            }

            if (pasajero.TipoPasajero == TipoPasajero.Premium
                && viaje.PasajerosPremiumABordo + 1 > viaje.crucero.CapacidadPasajerosPremium)
            {
                throw new Exception("No hay mas asientos Premium");
            }

            if (pasajero.TipoPasajero == TipoPasajero.Turista
                && viaje.PasajerosTuristasABordo + 1 > viaje.crucero.CapacidadPasajerosTurista)
            {
                throw new Exception("No hay mas asientos Turista");
            }

            for (int i = 0; i < pasajero.CantidadEquipaje; i++)
            {
                viaje.crucero += pasajero[i].Peso;
            }

            pasajero += 1;
            viaje.pasajeros.Add(pasajero);
            return viaje;
        }
        /// <summary>
        /// Elimina el pasajero de la lista de pasajeros del viaje.
        /// </summary>
        /// <param name="viaje"></param>
        /// <param name="pasajero">El pasajero a eliminar</param>
        /// <returns></returns>
        public static Viaje operator -(Viaje viaje, Pasajero pasajero)
        {
            viaje.pasajeros.RemoveAt(viaje.ObtenerIndicePasajero(pasajero));
            return viaje;
        }
        public static bool operator ==(Viaje viajeA, Viaje viajeB)
        {
            return viajeA.id == viajeB.id;
        }
        public static bool operator ==(Viaje viaje, Pasajero pasajero)
        {
            return viaje.ObtenerIndicePasajero(pasajero) != -1;
        }
        public static bool operator !=(Viaje viajeA, Viaje viajeB)
        {
            return !(viajeA == viajeB);
        }
        public static bool operator !=(Viaje viaje, Pasajero pasajero)
        {
            return !(viaje == pasajero);
        }

        private int ContarPasajerosPorTipo(TipoPasajero tipoParam)
        {
            int contador = 0;
            foreach (Pasajero pasajero in this.pasajeros)
            {
                if (pasajero.TipoPasajero == tipoParam)
                {
                    contador++;
                }
            }
            return contador;
        }
        private int ObtenerIndicePasajero(Pasajero pasajero)
        {
            int returnAux = -1;
            for (int i = 0; i < this.pasajeros.Count; i++)
            {
                if (pasajero == this.pasajeros[i])
                {
                    returnAux = i;
                    break;
                }

            }
            return returnAux;
        }
        private float CalcularPrecioDeViaje(Puerto destino)
        {
            float precioViaje;
            if (destino.EsDestinoRegional)
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
            float cantidadHorasAleatoria;
            if (destino.EsDestinoRegional)
            {
                cantidadHorasAleatoria = Viaje.random.Next(72, 360);
            }
            else
            {
                cantidadHorasAleatoria = Viaje.random.Next(480, 720);
            }
            return cantidadHorasAleatoria;
        }

        public override string ToString()
        {
            return $"Viaje Id {this.id}. De {this.origen} a {this.destino} el dia {this.fechaSalida}";
        }
        public override bool Equals(object obj)
        {
            Viaje viaje = obj as Viaje;
            return viaje is not null && this == viaje;
        }
        public override int GetHashCode()
        {
            return (this.crucero, this.id, this.origen, this.destino, this.precioPasajePorHora).GetHashCode();
        }
    }   
}
