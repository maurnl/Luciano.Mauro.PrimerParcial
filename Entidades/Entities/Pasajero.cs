using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Pasajero : PersonaBase
    {
        private static int contadorPasajero;
        private int cantidadViajesRealizados;
        private bool estaViajando;
        private Pasaporte pasaporte;
        private DateTime fechaNacimiento;
        private TipoPasajero tipoPasajero;
        private List<Equipaje> equipaje;
        private Genero genero;

        static Pasajero()
        {
            Pasajero.contadorPasajero = 1000;
        }
        private Pasajero(string nombreCompleto) : base(nombreCompleto)
        {
            base.id = Pasajero.contadorPasajero;
            Pasajero.contadorPasajero++;
        }
        public Pasajero(string nombreCompleto, Pasaporte pasaporte, DateTime fechaNacimiento, TipoPasajero tipoPasajero, Genero genero) : this(nombreCompleto)
        {
            this.pasaporte = pasaporte;
            this.fechaNacimiento = fechaNacimiento;
            this.tipoPasajero = tipoPasajero;
            this.estaViajando = false;
            this.genero = genero;
            this.equipaje = new List<Equipaje>();
        }

        /// <summary>
        /// Indexador para Pasajero. Retorna el equipaje correspondiente al indice de la lista de equipajes.
        /// </summary>
        /// <param name="indice">Indice</param>
        /// <returns></returns>
        public Equipaje this[int indice]
        {
            get
            {
                Equipaje equipajeRetorno = null;
                if(indice >= 0 && indice < this.equipaje.Count)
                {
                    equipajeRetorno = this.equipaje[indice];
                }
                return equipajeRetorno;
            }
            set
            {
                if (indice >= 0 && indice < this.equipaje.Count)
                {
                    this.equipaje[indice] = value;
                }
            }
        }
        public override int Id
        {
            get
            {
                return base.id;
            }
        }
        public int Dni
        {
            get
            {
                return this.Pasaporte.Dni;
            }
        }
        public int Edad
        {
            get
            {
                return (DateTime.Now - this.fechaNacimiento).Days / 365;
            }
        }

        public Genero Genero
        {
            get
            {
                return this.genero;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }
        public Pasaporte Pasaporte
        {
            get
            {
                return this.pasaporte;
            }
        }
        public TipoPasajero TipoPasajero
        {
            get
            {
                return this.tipoPasajero;
            }
        }
        public int CantidadEquipaje
        {
            get
            {
                return this.equipaje.Count;
            }
        }
        public bool EstaViajando
        {
            get
            {
                return this.estaViajando;
            }
            set
            {
                this.estaViajando = value;
            }
        }
        public int CantidadViajesRealizados
        {
            get
            {
                return this.cantidadViajesRealizados;
            }
        }
        public string Equipaje
        {
            get
            {
                return MostrarEquipaje();
            }
        }

        private int ContarCantidadValijas()
        {
            int cantidad = 0;
            foreach (Equipaje equipaje in this.equipaje)
            {
                if (!equipaje.EsDeMano)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        private float CalcularPesoDeValijas()
        {
            float acumuladorPeso = 0;
            foreach (Equipaje equipaje in this.equipaje)
            {
                if (!equipaje.EsDeMano)
                {
                    acumuladorPeso += equipaje.Peso;
                }
            }
            return acumuladorPeso;
        }
        private string MostrarEquipaje()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Equipaje equipaje in this.equipaje)
            {
                sb.Append(equipaje.ToString());
                sb.Append(" / ");
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return $"{base.ToString()} Edad: {Edad}. Tipo: {TipoPasajero}. DNI: {Pasaporte.Dni}.";
        }
        public override bool Equals(object obj)
        {
            Pasajero pasajero = obj as Pasajero;
            return pasajero is not null && pasajero == this;
        }
        public override int GetHashCode()
        {
            return (this.id, this.pasaporte).GetHashCode();
        }

        /// <summary>
        /// Agrega el Equipaje a la lista de equipajes del pasajero.
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="equipaje">Equipaje a agregar</param>
        /// <returns></returns>
        public static Pasajero operator +(Pasajero pasajero, Equipaje equipaje)
        {
            if (!equipaje.EsDeMano && (pasajero.TipoPasajero == TipoPasajero.Turista && pasajero.ContarCantidadValijas() >= 1
            || pasajero.TipoPasajero == TipoPasajero.Premium && pasajero.ContarCantidadValijas() >= 2))
            {
                throw new Exception($"Se ha excedido el maximo de valijas permitidos (MAX {(pasajero.tipoPasajero == TipoPasajero.Turista ? '1' : '2')})");
            }
            if (equipaje.EsDeMano && pasajero.equipaje.Count - pasajero.ContarCantidadValijas() != 0)
            {
                throw new Exception("Este pasajero ya tiene un bolso de mano. (MAX 1)");
            }
            if (!equipaje.EsDeMano)
            {
                if (pasajero.tipoPasajero == TipoPasajero.Turista && pasajero.CalcularPesoDeValijas() + equipaje.Peso > 25
                    || pasajero.tipoPasajero == TipoPasajero.Premium && pasajero.CalcularPesoDeValijas() + equipaje.Peso > 50)
                    throw new Exception("Se ha excedido del peso maximo permitido");
            }

            pasajero.equipaje.Add(equipaje);
            return pasajero;
        }

        /// <summary>
        /// Suma un valor a la cantidad de viajes realizados por el pasajero
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="cantidadViajes"></param>
        /// <returns></returns>
        public static Pasajero operator +(Pasajero pasajero, int cantidadViajes)
        {
            pasajero.cantidadViajesRealizados += cantidadViajes;
            return pasajero;
        }
        /// <summary>
        /// Elimina el equipaje de la lista de equipajes del pasajero.
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="equipaje">Equipaje a eliminar</param>
        /// <returns></returns>
        public static Pasajero operator -(Pasajero pasajero, Equipaje equipaje)
        {
            pasajero.equipaje.Remove(equipaje);
            return pasajero;
        }
        public static bool operator ==(Pasajero pasajeroA, Pasajero pasajeroB)
        {
            return pasajeroA.Pasaporte.Dni == pasajeroB.Pasaporte.Dni;
        }
        public static bool operator !=(Pasajero pasajeroA, Pasajero pasajeroB)
        {
            return !(pasajeroA == pasajeroB);
        }

    }
}
