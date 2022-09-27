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
        public static List<Viaje> historialViajes;
        public static List<Viaje> viajes;
        public static List<Venta> ventas;
        public static List<Puerto> puertos;
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

    }
}
