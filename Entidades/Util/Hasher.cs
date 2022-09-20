using System;
using System.Security.Cryptography;
using System.Text;

namespace Parcial.Util
{
    public class Hasher
    {
        /// <summary>
        /// Hasher class. For storing passwords securely using SHA512.
        /// </summary>
        /// <param name="text">Text to hash</param>
        /// <param name="hasher"></param>
        /// <returns></returns>
        public static string HashText(string text, HashAlgorithm hasher)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] hashedBytes = hasher.ComputeHash(textBytes);
            hasher.Clear();
            return Convert.ToBase64String(hashedBytes);
        }
    }
}
