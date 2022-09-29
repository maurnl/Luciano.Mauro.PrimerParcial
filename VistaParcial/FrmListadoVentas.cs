using Parcial.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaParcial
{
    public partial class FrmListadoVentas : FrmListadoBase
    {
        List<Venta> ventasFiltradas;
        public FrmListadoVentas()
        {
            InitializeComponent();
            this.ventasFiltradas = new List<Venta>();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            this.btnAccionUno.Text = "Calcular recaudacion";
            this.btnAccionDos.Text = "Mostrar destino mas demandado";
            this.cboCombobox.DataSource = SistemaCruceros.viajes;
            this.cboCombobox.SelectedIndex = 0;
            MostrarVentasDelViaje();
            base.fuenteDeDatos.DataSource = ventasFiltradas;
            ActualizarListado();
            this.Text = "Listado de ventas";
        }

        private void MostrarVentasDelViaje()
        {
            Viaje viajeSeleccionado = (Viaje)cboCombobox.SelectedItem;
            this.ventasFiltradas.Clear();
            foreach (Venta ventaEnSistema in SistemaCruceros.ventas)
            {
                if (viajeSeleccionado == ventaEnSistema.Viaje)
                {
                    ventasFiltradas.Add(ventaEnSistema);
                }
            }
            base.ActualizarListado();
        }

        private void cboCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.MostrarVentasDelViaje();
        }

        private void btnAccionUno_Click(object sender, EventArgs e)
        {
            this.CalcularRecaudacionDeViaje();
        }

        private void CalcularRecaudacionDeViaje()
        {
            Viaje viajeSeleccionado = (Viaje)base.cboCombobox.SelectedItem;
            if (viajeSeleccionado is null)
            {
                return;
            }
            float recaudacionPremium = viajeSeleccionado.PrecioPremium * viajeSeleccionado.PasajerosPremiumABordo;
            float recaudacionTurista = viajeSeleccionado.PrecioTurista * viajeSeleccionado.PasajerosTuristasABordo;
            MessageBox.Show($"Recaudacion Premium: ${recaudacionPremium}. \nRecaudacion Turista: ${recaudacionTurista}.\nTotal: ${recaudacionPremium + recaudacionTurista}",
                $"{viajeSeleccionado}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarDestinoMasDemandado(Puerto puerto)
        {
            MessageBox.Show($"Destino mas demandado: {puerto}", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Puerto CalcularDestinoMasDemandado()
        {
            Puerto puertoMasDemandado = null;
            int cantidadDemandasActual = 0;
            int cantidadDemandasMaxima = 0;
            bool primeraVuelta = true;
            foreach (Viaje viaje in SistemaCruceros.viajes)
            {
                foreach (Venta venta in SistemaCruceros.ventas)
                {
                    if(primeraVuelta || cantidadDemandasActual > cantidadDemandasMaxima)
                    {
                        primeraVuelta = false;
                        puertoMasDemandado = venta.Viaje.Destino;
                        cantidadDemandasMaxima = cantidadDemandasActual;
                    }
                }
            }
            return puertoMasDemandado;
        }

        private void btnAccionDos_Click(object sender, EventArgs e)
        {
            MostrarDestinoMasDemandado(CalcularDestinoMasDemandado());
        }
    }
}
