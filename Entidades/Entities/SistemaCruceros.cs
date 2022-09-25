﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public static class SistemaCruceros
    {
        private static List<Crucero> flota;
        private static List<Viaje> viajes;
        private static List<Venta> ventas;
        private static List<Puerto> puertos;

        public static List<Crucero> Flota
        {
            get
            {
                return SistemaCruceros.flota;
            }
        }
        public static List<Viaje> Viajes
        {
            get
            {
                return SistemaCruceros.viajes;
            }
        }
        public static List<Venta> Ventas
        {
            get
            {
                return SistemaCruceros.ventas;
            }
        }
        public static List<Puerto> Puertos
        {
            get
            {
                return SistemaCruceros.puertos;
            }
        }

        static SistemaCruceros()
        {
            SistemaCruceros.flota = new List<Crucero>();
            SistemaCruceros.viajes = new List<Viaje>();
            SistemaCruceros.ventas = new List<Venta>();
            SistemaCruceros.puertos = new List<Puerto>();
        }
    }
}