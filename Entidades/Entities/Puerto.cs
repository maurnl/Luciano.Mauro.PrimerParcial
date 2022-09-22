﻿using System;
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

        public Puerto(Provincia provincia, Pais pais, bool esDestinoRegional)
        {
            this.provincia = provincia;
            this.pais = pais;
            this.esDestinoRegional = esDestinoRegional;
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
        public override string ToString()
        {
            return $"{this.provincia}, {this.pais}";
        }
    }
}
