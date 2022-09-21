using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Viaje
    {
        private static int contadorViaje;
        private static Random random;
        private int duracion;
        private float precioPasaje;
        private List<Pasajero> pasajeros;
        private DateTime salida;
        private DateTime llegada;

        public Aeropuerto Origen { get; set; }
        public Aeropuerto Destino { get; set; }
        public Avion Avion { get; set; }
        public float PrecioTurista { get => precioPasaje; private set => precioPasaje = value; }
        public float PrecioPremium { get => precioPasaje + (precioPasaje * 15 / 100); }
        public int Duracion { get => this.duracion; private set => this.duracion = value; }
        public int PasajerosABordo { get => this.pasajeros.Count; }
        public List<Pasajero> Pasajeros { get => pasajeros; private set => pasajeros = value; }
        public DateTime Salida { get => this.salida; private set => this.salida = value; }
        public DateTime Llegada { get => this.llegada; private set => this.llegada = value; }

    }
}
