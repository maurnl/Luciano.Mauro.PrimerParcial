using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Venta
    {
        private List<Pasajero> clientes;
        private DateTime fecha;
        private Viaje viaje;
        private float precioBruto;

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
        public int CantidadPasajes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        public Venta(DateTime fecha, Viaje viaje, float precioBruto, List<Pasajero> clientes)
        {
            this.fecha = fecha;
            this.viaje = viaje;
            this.precioBruto = precioBruto;
            this.clientes = clientes;
        }

        public override string ToString()
        {
            return $"Fecha: {Fecha}. Importe bruto: {this.precioBruto}. Precio neto (+IVA 21%): {PrecioNeto}";
        }
    }
}
