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
        public static void HardcodearFlota(List<Crucero> flota)
        {
            flota.Add(new Crucero("AXCK1000", "Popeye", 25, 1000));
            flota[0] += Salon.Comedor;
            flota[0] += Salon.Gimnasio;
            flota.Add(new Crucero("CLKF1349", "Barba Negra", 100, 1000));
            flota[1] += Salon.Comedor;
            flota[1] += Salon.Piscina;
            flota.Add(new Crucero("VOLF4931", "La Sirena", 110, 1000));
            flota[2] += Salon.Comedor;
            flota[2] += Salon.Gimnasio;
            flota[2] += Salon.Piscina;
            flota.Add(new Crucero("CSBV1593", "Alto Barco", 350, 1000));
            flota[3] += Salon.Comedor;
            flota[3] += Salon.Comedor;
            flota[3] += Salon.Gimnasio;
            flota[3] += Salon.Piscina;
            flota.Add(new Crucero("GGHB3555", "El choca puertos", 200, 1000));
            flota[4] += Salon.Comedor;
            flota.Add(new Crucero("CASC1314", "Tres Patitos", 222, 1000));
            flota[5] += Salon.Comedor;
            flota.Add(new Crucero("TITAN1C0", "El Titanic", 1000, 1000));
            flota[6] += Salon.Gimnasio;
            flota[6] += Salon.Gimnasio;
            flota[6] += Salon.Piscina;
            flota[6] += Salon.Piscina;
            flota[6] += Salon.Comedor;
            flota[6] += Salon.Comedor;
            flota[6] += Salon.Teatro;
            flota[6] += Salon.Teatro;
            flota[6] += Salon.Teatro;
            flota[6] += Salon.Casino;
            flota[6] += Salon.Casino;
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
        public static void HardcodearPasajeros(List<Venta> ventas, Viaje viaje, int cantidad, bool premium)
        {
            Random random = new Random();
            int dni;
            DateTime fechaMinima = new DateTime(1970, 1, 1);
            int range = (new DateTime(2004, 1, 1) - fechaMinima).Days;
            string[] nombres = { "Daphne", "Hilliard", "Garvy", "Arnold",  "Corilla", "Davine", "Frankie", "Alfie", "Tuck",
                "Jethro", "Keri", "Pepillo", "Roxanne", "Daniella", "Ethelind" };
            string[] apellidos = { "Godsmark","Makiver", "McCallister", "Denison", "Drewell", "Owers", "Enser", "Benneyworth", "Wickstead" };
            Equipaje equipaje = new Equipaje(random.Next(1, 20), false);
            for (int i = 0; i < cantidad; i++)
            {
                dni = random.Next(2000000, 5000000);
                Pasajero pasajero = new Pasajero(nombres[random.Next(0, nombres.Length)]+" "+apellidos[random.Next(0, apellidos.Length)], dni, fechaMinima.AddDays(random.Next(range)), premium ? TipoPasajero.Premium : TipoPasajero.Turista, random.Next(0,2) == 0? Genero.Femenino : Genero.Masculino);
                viaje += pasajero;
                pasajero += equipaje;
                if(i%2==0)
                {
                    pasajero += new Equipaje(1, true);
                }
                ventas.Add(new Venta(viaje, new List<Pasajero> { pasajero }));
            }
        }
        public static void HardcodearViajes(List<Viaje> viajes, List<Puerto> puertos, List<Crucero> cruceros)
        {
            viajes.Add(new Viaje(puertos[0], puertos[1], cruceros[0], DateTime.Now));
            viajes.Add(new Viaje(puertos[0], puertos[2], cruceros[1], DateTime.Now));
            viajes.Add(new Viaje(puertos[0], puertos[3], cruceros[2], DateTime.Now));
            viajes.Add(new Viaje(puertos[0], puertos[6], cruceros[3], DateTime.Now));
            viajes.Add(new Viaje(puertos[0], puertos[3], cruceros[4], DateTime.Now));
            viajes.Add(new Viaje(puertos[0], puertos[1], cruceros[5], DateTime.Now));
        }
    }
}
