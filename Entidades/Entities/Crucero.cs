﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Crucero
    {
        private string matricula; // Identificador
        private string nombre;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;
        private float capacidadBodega;
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
        public float CapacidadBodega
        {
            get
            {
                return this.capacidadBodega;
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

        public Crucero(string matricula, string nombre, int capacidadPasajeros,
            float capacidadBodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.CapacidadPasajeros = capacidadPasajeros;
            this.capacidadBodega = capacidadBodega;
            this.estaEnViaje = false;
            this.salones = new List<Salon>();
            this.salones.Add(Salon.Comedor);
        }
        public Crucero(string matricula, string nombre,int capacidadPasajeros,
            float capacidadBodega, List<Salon> salones) : this(matricula, nombre, capacidadPasajeros, capacidadBodega)
        {
            this.salones = salones;
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
            return $"Crucero '{this.nombre}'.";
        }
    }
}