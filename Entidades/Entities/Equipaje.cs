using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Equipaje
    {
        private float peso;
        private bool esDeMano;

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public bool EsDeMano
        {
            get
            {
                return this.esDeMano;
            }
        }

        public Equipaje(float peso, bool esDeMano)
        {
            this.peso = peso;
            this.esDeMano = esDeMano;
            if (this.esDeMano)
            {
                this.peso = 0;
            }
        }

        public static explicit operator string(Equipaje equipaje)
        {
            return $"Peso: {equipaje.peso} kg. Es equipaje de mano: {(equipaje.esDeMano ? "Si" : "No")}";
        }
        public override string ToString()
        {
            return (string)this;
        }

        public static bool operator ==(Equipaje equipajeA, Equipaje equipajeB)
        {
            return equipajeA.peso == equipajeB.peso && equipajeA.esDeMano == equipajeB.esDeMano;
        }

        public static bool operator !=(Equipaje equipajeA, Equipaje equipajeB)
        {
            return !(equipajeA != equipajeB);
        }

        public override bool Equals(object obj)
        {
            Equipaje equipaje = obj as Equipaje;
            return equipaje is not null && this == equipaje;
        }

        public override int GetHashCode()
        {
            return (this.peso, this.esDeMano).GetHashCode();
        }
    }
}
