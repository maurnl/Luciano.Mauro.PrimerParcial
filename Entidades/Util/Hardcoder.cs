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
        public static void HardcodearUsuarios(UserManager userManager)
        {
            userManager.TryCrearUsuario("Mauro Luciano", "maurnl", "contrasenia123");
        }
    }
}
