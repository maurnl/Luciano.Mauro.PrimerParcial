using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class SistemaApp
    {
        private List<Crucero> flota;
        private List<Viaje> viajes;
        private List<Venta> ventas;
        private List<Puerto> puertos;

        public List<Crucero> Flota
        {
            get
            {
                return this.flota;
            }
        }
        public List<Viaje> Viajes
        {
            get
            {
                return this.viajes;
            }
        }
        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
            }
        }
        public List<Puerto> Puertos
        {
            get
            {
                return this.puertos;
            }
        }

        public SistemaApp()
        {
            this.flota = new List<Crucero>();
            this.viajes = new List<Viaje>();
            this.ventas = new List<Venta>();
            this.puertos = new List<Puerto>();
        }
    }
}
