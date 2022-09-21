﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public sealed class Pasajero : PersonaBase
    {
        private static int contadorPasajero;
        private DateTime fechaNacimiento;
        private TipoPasajero tipoPasajero;
        private List<Equipaje> equipaje;

        public int Edad
        {
            get
            {
                return (DateTime.Now - this.fechaNacimiento).Days / 365;
            }
        }
        public TipoPasajero TipoPasajero
        {
            get
            {
                return this.tipoPasajero;
            }
        }

        static Pasajero()
        {
            Pasajero.contadorPasajero = 1000;
        }

        private Pasajero(string nombreCompleto, int dni) : base(nombreCompleto, dni)
        {
            base.id = Pasajero.contadorPasajero;
            Pasajero.contadorPasajero++;
        }

        public Pasajero(string nombreCompleto, int dni, DateTime fechaNacimiento, TipoPasajero tipoPasajero) : this(nombreCompleto, dni)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.tipoPasajero = tipoPasajero;
            this.equipaje = new List<Equipaje>();
        }

        public static Pasajero operator +(Pasajero pasajero, Equipaje equipaje)
        {
            if (pasajero.TipoPasajero == TipoPasajero.Turista && pasajero.ContarCantidadValijas() >= 1
            || pasajero.TipoPasajero == TipoPasajero.Premium && pasajero.ContarCantidadValijas() >= 2)
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

        public static bool operator ==(Pasajero pasajeroA, Pasajero pasajeroB)
        {
            bool returnAux;
            if (pasajeroA is null)
            {
                returnAux = pasajeroB is null;
            }
            else if (pasajeroB is null)
            {
                returnAux = pasajeroA is null;
            }
            else
            {
                returnAux = pasajeroA.Dni == pasajeroB.Dni;
            }
            return returnAux;
        }

        public static bool operator !=(Pasajero pasajeroA, Pasajero pasajeroB)
        {
            return !(pasajeroA == pasajeroB);
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
                if(!equipaje.EsDeMano)
                {
                    acumuladorPeso += equipaje.Peso;
                }
            }
            return acumuladorPeso;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Edad: {Edad}. Tipo: {TipoPasajero}.";
        }
    }
}
