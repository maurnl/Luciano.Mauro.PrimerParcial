using Parcial.Login;
using Parcial.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public static class SistemaCruceros
    {
        private static DateTime fechaDelSistema;
        private static List<Crucero> flota;
        private static List<Venta> ventas;
        private static List<Puerto> puertos;
        private static List<Viaje> viajes;
        private static List<Viaje> historialViajes;
        private static Dictionary<Puerto, float> diccionarioRecaudacionPorDestino;

        public static DateTime FechaDelSistema
        {
            get
            {
                return SistemaCruceros.fechaDelSistema;
            }
            set
            {
                SistemaCruceros.fechaDelSistema = value;
            }
        }

        public static List<Crucero> Flota
        {
            get
            {
                return SistemaCruceros.flota;
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

        public static List<Viaje> Viajes
        {
            get
            {
                return SistemaCruceros.viajes;
            }
        }

        public static List<Viaje> HistorialViajes
        {
            get
            {
                return SistemaCruceros.historialViajes;
            }
        }

        public static Dictionary<Puerto, float> DiccionarioRecaudacionPorDestino
        {
            get
            {
                return SistemaCruceros.diccionarioRecaudacionPorDestino;
            }
        }
        static SistemaCruceros()
        {
            SistemaCruceros.flota = new List<Crucero>();
            SistemaCruceros.viajes = new List<Viaje>();
            SistemaCruceros.ventas = new List<Venta>();
            SistemaCruceros.puertos = new List<Puerto>();
            SistemaCruceros.historialViajes = new List<Viaje>();
            SistemaCruceros.diccionarioRecaudacionPorDestino = new Dictionary<Puerto, float>();
            SistemaCruceros.fechaDelSistema = DateTime.Now;
            Hardcoder.HardcodearFlota(SistemaCruceros.flota);
            Hardcoder.HardcodearPuertos(SistemaCruceros.puertos);
            Hardcoder.HardcodearViajes(SistemaCruceros.viajes, SistemaCruceros.puertos, SistemaCruceros.flota);
            try
            {
                Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[0], 300, true);
            }
            catch (Exception)
            {
            }

            try
            {
                Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[0], 300, false);
            }
            catch (Exception)
            {
            }
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[1], 10, true);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[1], 5, false);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[2], 12, true);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[2], 41, false);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[3], 22, true);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[3], 3, false);
        }

        public static List<Pasajero> BaseDeDatosPasajeros
        {
            get
            {
                List<Pasajero> baseDeDatosPasajeros = new List<Pasajero>();
                foreach (Viaje viaje in SistemaCruceros.viajes)
                {
                    for (int i = 0; i < viaje.PasajerosABordo; i++)
                    {
                        baseDeDatosPasajeros.Add(viaje[i]);
                    }
                }
                foreach (Viaje viaje in SistemaCruceros.historialViajes)
                {
                    for (int i = 0; i < viaje.PasajerosABordo; i++)
                    {
                        baseDeDatosPasajeros.Add(viaje[i]);
                    }
                }
                return baseDeDatosPasajeros;
            }
        }

        public static void ActualizarViajesActivos()
        {
            int cantidad = SistemaCruceros.viajes.Count;
            int j = 1;
            for (int i = cantidad - j; i >= 0; i--)
            {
                if (SistemaCruceros.viajes[i].EstadoDeViaje == EstadoDeViaje.Finalizado)
                {
                    SistemaCruceros.historialViajes.Add(SistemaCruceros.viajes[i]);
                    SistemaCruceros.viajes.Remove(SistemaCruceros.viajes[i]);
                    j++;
                }
            }
        }

        public static Pasajero ObtenerPasajeroEnSistema(int dni)
        {
            Pasajero pasajeroEncontrado = null;
            foreach (Pasajero pasajero in SistemaCruceros.BaseDeDatosPasajeros)
            {
                if(pasajero.Dni == dni)
                {
                    pasajeroEncontrado = pasajero;
                    break;
                }
            }
            return pasajeroEncontrado;
        }

        public static Puerto ObtenerDestinoMasDemandado()
        {
            Puerto puertoMasDemandado = null;
            int cantidadActual = 0;
            int cantidadMaxima = 0;
            bool banderaPrimero = true;
            foreach (Puerto puerto in SistemaCruceros.puertos)
            {
                cantidadActual = puerto.CantidadPasajerosArribados;
                if((banderaPrimero || cantidadActual > cantidadMaxima) && puerto != SistemaCruceros.puertos[0])
                {
                    puertoMasDemandado = puerto;
                    banderaPrimero = false;
                    cantidadMaxima = cantidadActual;
                }
            }
            return puertoMasDemandado;
        }

        public static Venta AltaDeVenta(Viaje viaje, List<Pasajero> pasajerosPosibles)
        {
            List<Pasajero> clientes = new List<Pasajero>();
            foreach (Pasajero pasajeroPosible in pasajerosPosibles)
            {
                viaje += pasajeroPosible;
                clientes.Add(pasajeroPosible);
            }
            Venta venta = new Venta(viaje, clientes);
            if (SistemaCruceros.diccionarioRecaudacionPorDestino.ContainsKey(viaje.Destino))
            {
                SistemaCruceros.diccionarioRecaudacionPorDestino[viaje.Destino] += venta.PrecioNeto;
            }
            else
            {
                SistemaCruceros.diccionarioRecaudacionPorDestino.Add(viaje.Destino, venta.PrecioNeto);
            }
            SistemaCruceros.ventas.Add(venta);
            return venta;
        }

        public static Viaje AltaDeViaje(Puerto origen, Puerto destino, Crucero crucero, DateTime fechaSalida)
        {
            if (origen.Equals(destino))
            {
                throw new Exception("El origen y el destino no deben coincidir.");
            }
            if (crucero.EstaEnViaje)
            {
                throw new Exception("El crucero elegido esta en viaje.");
            }

            Viaje viaje = new Viaje(origen, destino, crucero, fechaSalida);
            return viaje;
        }
    }
}
