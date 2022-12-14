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
        private float precioBruto;
        private Viaje viaje;
        private DateTime fecha;
        private List<Pasajero> clientes;

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
        }

        public override int Id
        {
            get
            {
                return base.id;
            }
        }
        public int CantidadPasajes
        {
            get
            {
                return this.clientes.Count;
            }
        }
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
        public float PrecioBruto
        {
            get
            {
                return this.precioBruto;
            }
        }
        public float PrecioNeto
        {
            get
            {
                return this.precioBruto + (this.precioBruto * 21 / 100);
            }
        }
        public bool EsServicioRegional
        {
            get
            {
                return this.viaje.Destino.EsDestinoRegional;
            }
        }
        public Viaje Viaje
        {
            get
            {
                return this.viaje;
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
