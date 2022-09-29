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
        public static DateTime fechaDelSistema;
        public static List<Crucero> flota;
        public static List<Venta> ventas;
        public static List<Puerto> puertos;
        public static List<Viaje> viajes;
        public static List<Viaje> historialViajes;
        public static Dictionary<Puerto, float> contadorRecaudacionDestinos;

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
                return baseDeDatosPasajeros;
            }
        }

        static SistemaCruceros()
        {
            SistemaCruceros.flota = new List<Crucero>();
            SistemaCruceros.viajes = new List<Viaje>();
            SistemaCruceros.ventas = new List<Venta>();
            SistemaCruceros.puertos = new List<Puerto>();
            SistemaCruceros.historialViajes = new List<Viaje>();
            SistemaCruceros.contadorRecaudacionDestinos = new Dictionary<Puerto, float>();
            SistemaCruceros.fechaDelSistema = DateTime.Now;
            Hardcoder.HardcodearFlota(SistemaCruceros.flota);
            Hardcoder.HardcodearPuertos(SistemaCruceros.puertos);
            Hardcoder.HardcodearViajes(SistemaCruceros.viajes, SistemaCruceros.puertos, SistemaCruceros.flota);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[0], 10);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[0], 10);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[1], 10);
            Hardcoder.HardcodearPasajeros(SistemaCruceros.ventas, SistemaCruceros.viajes[1], 30);
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
    }
}
