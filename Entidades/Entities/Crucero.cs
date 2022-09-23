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
        private List<Salon> salones;

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
            private set
            {
                this.matricula = value;
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
                return (this.cantidadCamarotesPremium + this.cantidadCamarotesTurista) * 4;
            }
            set
            {
                this.cantidadCamarotesPremium = value * 35 / 100;
                this.cantidadCamarotesTurista = value * 65 / 100;
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

        static Crucero()
        {
            Crucero.contadorCrucero = 1000;
        }
        public Crucero(string matricula, string nombre, int capacidadPasajeros,
            float capacidadBodega)
        {
            base.id = Crucero.contadorCrucero;
            Crucero.contadorCrucero++;
            this.matricula = matricula;
            this.nombre = nombre;
            this.CapacidadPasajeros = capacidadPasajeros;
            this.pesoBodegaMaximo = capacidadBodega;
            this.estaEnViaje = false;
            this.salones = new List<Salon>();
            this.salones.Add(Salon.Comedor);
        }

        public static Crucero operator +(Crucero crucero, Salon salon)
        {
            crucero.salones.Add(salon);
            return crucero;
        }

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
            bool returnAux;
            if(cruceroA is null)
            {
                returnAux = cruceroB is null;
            }
            else if (cruceroB is null)
            {
                returnAux = cruceroA is null;
            }
            else
            {
                returnAux = cruceroA.Matricula == cruceroB.Matricula;
            }
            return returnAux;
        }

        public static bool operator !=(Crucero cruceroA, Crucero cruceroB)
        {
            return !(cruceroA == cruceroB);
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

        public override string ToString()
        {
            return $"[{(this.EstaEnViaje ? "EN VIAJE" : "DISPONIBLE")}] Crucero '{this.nombre}'. " +
                $"Capacidad Total: {this.CapacidadPasajeros} personas. Bodega: {this.PesoBodegaActual}/{this.PesoBodegaMaximo} kg.";
        }
    }
}
