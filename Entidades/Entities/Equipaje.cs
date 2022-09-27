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

        public override string ToString()
        {
            return $"Peso: {this.peso} kg. Es equipaje de mano: {(this.esDeMano ? "Si" : "No")}";
        }

        public override bool Equals(object obj)
        {
            Equipaje equipaje = obj as Equipaje;
            return equipaje is not null && equipaje.peso == this.peso && equipaje.esDeMano == this.esDeMano;
        }

        public override int GetHashCode()
        {
            return (this.peso, this.esDeMano).GetHashCode();
        }
    }
}
