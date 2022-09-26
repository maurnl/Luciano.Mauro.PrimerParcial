using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Venta : EntidadBase
    {
        private static int contadorVenta;
        private List<Pasajero> clientes;
        private DateTime fecha;
        private Viaje viaje;
        private float precioBruto;

        public string Clientes
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Pasajero cliente in this.clientes)
                {
                    sb.Append(cliente.ToString() + " / ");
                }
                return sb.ToString();
            }
        }
        public string Fecha
        {
            get
            {
                return this.fecha.ToShortDateString();
            }
        }
        public float PrecioNeto
        {
            get
            {
                return this.precioBruto + (this.precioBruto * 21 / 100);
            }
        }
        public string Viaje
        {
            get
            {
                return this.viaje.ToString();
            }
        }
        public bool EsServicioRegional
        {
            get
            {
                return this.viaje.Destino.EsDestinoRegional;
            }
        }
        public int CantidadPasajes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        static Venta()
        {
            Venta.contadorVenta = 0;
        }
        public Venta(Viaje viaje, List<Pasajero> clientes)
        {
            base.id = Venta.contadorVenta;
            Venta.contadorVenta++;
            this.viaje = viaje;
            this.clientes = clientes;
            this.fecha = DateTime.Now;
            this.precioBruto = CalcularPrecioBruto();
            if (SistemaCruceros.contadorRecaudacionDestinos.ContainsKey(viaje.Destino))
            {
                SistemaCruceros.contadorRecaudacionDestinos[viaje.Destino] += this.PrecioNeto;
            }
            else
            {
                SistemaCruceros.contadorRecaudacionDestinos.Add(viaje.Destino, this.PrecioNeto);
            }
        }

        private float CalcularPrecioBruto()
        {
            float acumuladorPrecios = 0;
            foreach (Pasajero pasajero in this.clientes)
            {
                if(pasajero.TipoPasajero == TipoPasajero.Premium)
                {
                    acumuladorPrecios += this.viaje.PrecioPremium;
                } else
                {
                    acumuladorPrecios += this.viaje.PrecioTurista;
                }
            }
            return acumuladorPrecios;
        }

        public override string ToString()
        {
            return $"Fecha: {Fecha}. Importe bruto: {this.precioBruto}. Precio neto (+IVA 21%): {PrecioNeto}";
        }
    }
}
