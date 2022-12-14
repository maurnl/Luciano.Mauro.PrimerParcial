using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Crucero : EntidadBase
    {
        private static int contadorCrucero;
        private string matricula;
        private string nombre;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;
        private float pesoBodegaActual;
        private float pesoBodegaMaximo;
        private bool estaEnViaje;
        private float horasDeViaje;
        private List<Salon> salones;

        static Crucero()
        {
            Crucero.contadorCrucero = 1000;
        }
        public Crucero(string matricula, string nombre, int cantidadCamarotes,
            float capacidadBodega)
        {
            base.id = Crucero.contadorCrucero;
            Crucero.contadorCrucero++;
            this.matricula = matricula;
            this.nombre = nombre;
            this.CapacidadPasajeros = cantidadCamarotes;
            this.pesoBodegaMaximo = capacidadBodega;
            this.estaEnViaje = false;
            this.salones = new List<Salon>();
            this.salones.Add(Salon.Comedor);
        }

        public override int Id
        {
            get
            {
                return base.id;
            }
        }
        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int CapacidadPasajerosTurista
        {
            get
            {
                return this.cantidadCamarotesTurista * 4;
            }
        }
        public int CapacidadPasajerosPremium
        {
            get
            {
                return this.cantidadCamarotesPremium * 4;
            }
        }
        public int CapacidadPasajeros
        {
            get
            {
                return this.CapacidadPasajerosPremium + this.CapacidadPasajerosTurista;
            }
            set
            {
                this.cantidadCamarotesTurista = value * 65 / 100;
                this.cantidadCamarotesPremium = value - this.cantidadCamarotesTurista;
            }
        }
        public int CantidadSalones
        {
            get
            {
                return this.salones.Count;
            }
        } 
        public float PesoBodegaActual
        {
            get
            {
                return this.pesoBodegaActual;
            }
        }
        public float PesoBodegaMaximo
        {
            get
            {
                return this.pesoBodegaMaximo;
            }
        }
        public bool TieneGimnasio
        {
            get
            {
                return ContarSalonesPorTipo(Salon.Gimnasio) > 0;
            }
        }
        public bool TienePiscina
        {
            get
            {
                return ContarSalonesPorTipo(Salon.Piscina) > 0;
            }
        }
        public bool EstaEnViaje
        {
            get
            {
                return this.estaEnViaje;
            }
            set
            {
                this.estaEnViaje = value;
            }
        }

        public float HorasDeViaje
        {
            get
            {
                return this.horasDeViaje;
            }
            set
            {
                this.horasDeViaje = value;
            }
        }

        private int ContarSalonesPorTipo(Salon salonParam)
        {
            int returnAux = 0;
            foreach (Salon salonDelBarco in this.salones)
            {
                if(salonDelBarco == salonParam)
                {
                    returnAux++;
                }
            }
            return returnAux;
        }
        private string MostrarSalones()
        {
            string salones = "";
            for (int i = 0; i < this.salones.Count; i++)
            {
                if(i == 0)
                {
                    salones += $"{this.salones[i]}";
                }
                else if (i < this.salones.Count - 1)
                {
                    salones += $", {this.salones[i]}";
                }
                else
                {
                    salones += $" y {this.salones[i]}.";
                }
            }
            return salones;
        }
        public override string ToString()
        {
            return $"[{(this.EstaEnViaje ? "OCUPADO" : "DISPONIBLE")}] '{this.nombre}'. " +
                $"Capacidad: {this.CapacidadPasajeros} personas. Bodega: {this.PesoBodegaActual}/{this.PesoBodegaMaximo} kg. Salones: {this.MostrarSalones()}";
        }
        public override bool Equals(object obj)
        {
            Crucero crucero = obj as Crucero;
            return crucero is not null && this == crucero;
        }
        public override int GetHashCode()
        {
            return (this.id, this.matricula, this.nombre).GetHashCode();
        }
        
        /// <summary>
        /// Agrega el Salon sumado a la lista de salones del crucero.
        /// </summary>
        /// <param name="crucero"></param>
        /// <param name="salon">El Salon a agregar</param>
        /// <returns></returns>
        public static Crucero operator +(Crucero crucero, Salon salon)
        {
            crucero.salones.Add(salon);
            return crucero;
        }
        /// <summary>
        /// Suma un peso en kg a la bodega del pasajero. Arroja una excepcion si no hay
        /// espacio para el equipaje.
        /// </summary>
        /// <param name="crucero"></param>
        /// <param name="pesoCarga"></param>
        /// <returns>El Crucero con el peso sumado</returns>
        public static Crucero operator +(Crucero crucero, float pesoCarga)
        {
            if (crucero.pesoBodegaActual + pesoCarga > crucero.pesoBodegaMaximo)
            {
                throw new Exception("El crucero no tiene mas capacidad en la bodega.");
            }
            crucero.pesoBodegaActual += pesoCarga;
            return crucero;
        }
        public static bool operator ==(Crucero cruceroA, Crucero cruceroB)
        {
            return cruceroA.matricula == cruceroB.matricula;
        }
        public static bool operator !=(Crucero cruceroA, Crucero cruceroB)
        {
            return !(cruceroA == cruceroB);
        }
    }
}
