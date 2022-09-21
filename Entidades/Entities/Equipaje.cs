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
    }
}
