using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Puerto
    {
        private Pais pais;
        private Provincia provincia;
        private bool esDestinoRegional;
        private int cantidadPasajerosArribados;

        public Pais Pais
        {
            get
            {
                return this.pais;
            }
        }
        public Provincia Provincia
        {
            get
            {
                return this.provincia;
            }
        }
        public bool EsDestinoRegional
        {
            get
            {
                return this.esDestinoRegional;
            }
        }
        public int CantidadPasajerosArribados
        {
            get
            {
                return this.cantidadPasajerosArribados;
            }
        }

        public Puerto(Provincia provincia, Pais pais, bool esDestinoRegional)
        {
            this.provincia = provincia;
            this.pais = pais;
            this.esDestinoRegional = esDestinoRegional;
        }

        public static Puerto operator +(Puerto puerto, int pasajeros)
        {
            puerto.cantidadPasajerosArribados += pasajeros;
            return puerto;
        }

        public static bool operator ==(Puerto puertoA, Puerto puertoB)
        {
            bool returnAux;
            if (puertoA is null)
            {
                returnAux = puertoB is null;
            }
            else if (puertoB is null)
            {
                returnAux = puertoA is null;
            }
            else
            {
                returnAux = puertoA.Pais == puertoB.Pais && puertoA.Provincia == puertoB.Provincia;
            }
            return returnAux;
        }
        public static bool operator !=(Puerto puertoA, Puerto puertoB)
        {
            return !(puertoA == puertoB);
        }

        public override bool Equals(object obj)
        {
            Puerto puerto = obj as Puerto;
            return puerto is not null && this == puerto;
        }
        public override string ToString()
        {
            return $"{(EsDestinoRegional ? "Regional: " : "Extraregional: ")}{this.provincia}, {this.pais}";
        }

        public override int GetHashCode()
        {
            return (this.pais, this.provincia, this.esDestinoRegional).GetHashCode();
        }
    }
}
