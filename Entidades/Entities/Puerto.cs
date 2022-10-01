using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Puerto
    {
        private int cantidadPasajerosArribados;
        private bool esDestinoRegional;
        private Pais pais;
        private Provincia provincia;

        public Puerto(Provincia provincia, Pais pais, bool esDestinoRegional)
        {
            this.provincia = provincia;
            this.pais = pais;
            this.esDestinoRegional = esDestinoRegional;
        }

        public int CantidadPasajerosArribados
        {
            get
            {
                return this.cantidadPasajerosArribados;
            }
        }
        public bool EsDestinoRegional
        {
            get
            {
                return this.esDestinoRegional;
            }
        }
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

        /// <summary>
        /// Suma una cantidad de pasajeros al total de pasajeros arribados en este puerto.
        /// </summary>
        /// <param name="puerto"></param>
        /// <param name="pasajerosArribados">Cantidad de pasajeros a sumar</param>
        /// <returns></returns>
        public static Puerto operator +(Puerto puerto, int pasajerosArribados)
        {
            puerto.cantidadPasajerosArribados += pasajerosArribados;
            return puerto;
        }
        public static bool operator ==(Puerto puertoA, Puerto puertoB)
        {
            return puertoA.Pais == puertoB.Pais && puertoA.Provincia == puertoB.Provincia;
        }
        public static bool operator !=(Puerto puertoA, Puerto puertoB)
        {
            return !(puertoA == puertoB);
        }
    }
}
