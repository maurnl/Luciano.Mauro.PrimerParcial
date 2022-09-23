using Parcial.Entities;
using Parcial.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Util
{
    public static class Hardcoder
    {
        public static void HardcodearUsuarios(SistemaUsuarios userManager)
        {
            userManager.TryCrearUsuario("Mauro Luciano", "maurnl", "contrasenia123");
        }

        public static void HardcodearFlota(List<Crucero> flota)
        {
            flota.Add(new Crucero("AXCK1000", "Popeye", 100, 1000));
            flota[0] += Salon.Gimnasio;
            flota.Add(new Crucero("CLKF1349", "Barba Negra", 100, 1000));
            flota[1] += Salon.Piscina;
            flota.Add(new Crucero("VOLF4931", "La Sirena", 100, 1000));
            flota[2] += Salon.Gimnasio;
            flota[2] += Salon.Piscina;
            flota.Add(new Crucero("CSBV1593", "Alto Barco", 100, 1000));
            flota.Add(new Crucero("GGHB3555", "El choca puertos", 100, 1000));
            flota.Add(new Crucero("CASC1314", "La langosta", 100, 1000));
            flota.Add(new Crucero("TITAN1C0", "El Titanic", 1000, 1000));
        }

        public static void HardcodearPuertos(List<Puerto> puertos)
        {
            puertos.Add(new Puerto(Provincia.BuenosAires, Pais.Argentina, true));
            puertos.Add(new Puerto(Provincia.PuertoMadryn, Pais.Argentina, true));
            puertos.Add(new Puerto(Provincia.Ushuaia, Pais.Argentina, true));
            puertos.Add(new Puerto(Provincia.Recife, Pais.Brasil, true));
            puertos.Add(new Puerto(Provincia.RioDeJaneiro, Pais.Brasil, true));
            puertos.Add(new Puerto(Provincia.IslaDePascua, Pais.Chile, true));
            puertos.Add(new Puerto(Provincia.Santiago, Pais.Chile, true));
            puertos.Add(new Puerto(Provincia.Cartagena, Pais.Colombia, true));
            puertos.Add(new Puerto(Provincia.IslaGalapagos, Pais.Ecuador, true));
            puertos.Add(new Puerto(Provincia.Lima, Pais.Peru, true));
            puertos.Add(new Puerto(Provincia.Montevideo, Pais.Uruguay, true));

            puertos.Add(new Puerto(Provincia.LaHabana, Pais.Cuba, false));
            puertos.Add(new Puerto(Provincia.Miami, Pais.EEUU, false));
            puertos.Add(new Puerto(Provincia.NuevaYork, Pais.EEUU, false));
            puertos.Add(new Puerto(Provincia.Taipei, Pais.Taiwan, false));
            puertos.Add(new Puerto(Provincia.Venecia, Pais.Italia, false));
            puertos.Add(new Puerto(Provincia.Atenas, Pais.Grecia, false));
            puertos.Add(new Puerto(Provincia.Acapulco, Pais.Mexico, false));
            puertos.Add(new Puerto(Provincia.Bangkok, Pais.Tailandia, false));
        }

        public static void HardcodearPasajeros(Viaje viaje, TipoPasajero tipo, int cantidad)
        {
            Random random = new Random();
            int dni;
            for (int i = 0; i < cantidad; i++)
            {
                dni = random.Next(2000000, 5000000);
                viaje += new Pasajero("Pepito Pepe", new Pasaporte(dni, DateTime.Parse("12/07/2020")), DateTime.Parse("12/07/1970"), tipo);
            }
        }

        public static void HardcodearViajes(List<Viaje> viajes, List<Puerto> puertos, List<Crucero> cruceros)
        {
            viajes.Add(new Viaje(puertos[0], puertos[1], cruceros[0], DateTime.Now));
            viajes.Add(new Viaje(puertos[1], puertos[2], cruceros[1], DateTime.Now));
            viajes.Add(new Viaje(puertos[1], puertos[3], cruceros[2], DateTime.Now));
            viajes.Add(new Viaje(puertos[0], puertos[6], cruceros[3], DateTime.Now));
            viajes.Add(new Viaje(puertos[4], puertos[3], cruceros[4], DateTime.Now));
            viajes.Add(new Viaje(puertos[2], puertos[1], cruceros[5], DateTime.Now));
        }
    }
}
