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
            if(obj is not Equipaje)
            {
                return false;
            }
            return ((Equipaje)obj).peso == this.peso && ((Equipaje)obj).esDeMano == this.esDeMano;
        }
    }
}
