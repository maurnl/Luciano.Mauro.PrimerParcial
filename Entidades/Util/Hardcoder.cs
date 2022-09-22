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
            flota.Add(new Crucero("CLKF1349", "Barba Negra", 100, 1000));
            flota.Add(new Crucero("VOLF4931", "La Sirena", 100, 1000));
        }

        public static void HardcodearPuertos(List<Puerto> puertos)
        {
            puertos.Add(new Puerto(Provincia.Montevideo, Pais.Uruguay, true));
            puertos.Add(new Puerto(Provincia.Ushuaia, Pais.Argentina, true));
            puertos.Add(new Puerto(Provincia.PuertoMadryn, Pais.Argentina, true));
            puertos.Add(new Puerto(Provincia.Recife, Pais.Brasil, true));
            puertos.Add(new Puerto(Provincia.RioDeJaneiro, Pais.Brasil, true));
            puertos.Add(new Puerto(Provincia.IslaDePascua, Pais.Chile, true));
            puertos.Add(new Puerto(Provincia.Santiago, Pais.Chile, true));
            puertos.Add(new Puerto(Provincia.Cartagena, Pais.Colombia, true));
            puertos.Add(new Puerto(Provincia.IslaGalapagos, Pais.Ecuador, true));
            puertos.Add(new Puerto(Provincia.Lima, Pais.Peru, true));

            puertos.Add(new Puerto(Provincia.LaHabana, Pais.Cuba, false));
            puertos.Add(new Puerto(Provincia.Miami, Pais.EEUU, false));
            puertos.Add(new Puerto(Provincia.NuevaYork, Pais.EEUU, false));
            puertos.Add(new Puerto(Provincia.Taipei, Pais.Taiwan, false));
            puertos.Add(new Puerto(Provincia.Venecia, Pais.Italia, false));
            puertos.Add(new Puerto(Provincia.Atenas, Pais.Grecia, false));
            puertos.Add(new Puerto(Provincia.Acapulco, Pais.Mexico, false));
            puertos.Add(new Puerto(Provincia.Bangkok, Pais.Tailandia, false));
        }
    }
}
