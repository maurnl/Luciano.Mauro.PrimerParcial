using Parcial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Util
{
    public static class Validador
    {
        public static void ValidarNull(object objectParam)
        {
            if(objectParam == null)
            {
                throw new ArgumentNullException();
            }
        }
        public static void ValidarStringVacia(string stringParam)
        {
            if(String.IsNullOrWhiteSpace(stringParam))
            {
                throw new FormatException("Dato ingresado no valido.");
            }
        }
        public static void ValidarStringAlfabetica(string stringParam)
        {
            Validador.ValidarStringVacia(stringParam);
            if (StringTieneNumeros(stringParam))
            {
                throw new FormatException("El texto ingresado no debe contener numeros.");
            }
        }
        private static bool StringTieneNumeros(string stringParam)
        {
            bool returnAux = false;
            foreach (char character in stringParam)
            {
                if (char.IsDigit(character))
                {
                    returnAux = true;
                    break;
                }
            }
            return returnAux;
        }
    }
}
