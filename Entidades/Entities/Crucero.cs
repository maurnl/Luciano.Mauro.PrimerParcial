using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private int cantidadSalones;
        private int cantidadCasinos;
        private float capacidadBodega;

        public Crucero()
        {
            this.cantidadCamarotes = 1;
            this.cantidadCasinos = 0;
            this.capacidadBodega = 500F;
            this.nombre = "Nave sin nombre";
        }                          
    }
}
