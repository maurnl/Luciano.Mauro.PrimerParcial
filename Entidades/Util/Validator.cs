using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Util
{
    public static class Validator
    {
        public static void NullValidation(object objectParam)
        {
            if(objectParam == null)
            {
                throw new ArgumentNullException();
            }
        }
        public static void ValidStringValidation(string stringParam)
        {
            if(String.IsNullOrWhiteSpace(stringParam))
            {
                throw new FormatException("Dato ingresado no valido.");
            }
        }
        public static void AlphabeticStringValidation(string stringParam)
        {
            Validator.ValidStringValidation(stringParam);
            if (StringHasNumbers(stringParam))
            {
                throw new FormatException("El texto ingresado no debe contener numeros.");
            }
        }
        private static bool StringHasNumbers(string stringParam)
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
