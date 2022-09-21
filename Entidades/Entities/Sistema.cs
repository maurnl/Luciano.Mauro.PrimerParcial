using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Sistema
    {
        private List<Crucero> flota;
        private List<Viaje> viajes;
        private List<Venta> ventas;

        public Sistema()
        {
            this.flota = new List<Crucero>();
            this.viajes = new List<Viaje>();
            this.ventas = new List<Venta>();
        }
    }
}
