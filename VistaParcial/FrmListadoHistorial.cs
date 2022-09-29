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
    public partial class FrmListadoHistorial : FrmListadoBase
    {
        public FrmListadoHistorial()
        {
            InitializeComponent();
            base.fuenteDeDatos.DataSource = SistemaCruceros.historialViajes;
        }
        private void FrmListadoHistorial_Load(object sender, EventArgs e)
        {
            this.Text = "Informes";
            this.btnAccionUno.Text = "Ver viajes finalizados";
            this.btnAccionDos.Text = "Ver recaudacion por destinos";
            this.btnReiniciarFiltros.Text = "Calcular recaudacion del viaje";
            this.btnGanancias.Text = "Ver ganancias por servicio";
        }

        private void btnAccionUno_Click(object sender, EventArgs e)
        {
            base.fuenteDeDatos.DataSource = SistemaCruceros.historialViajes;
            base.ActualizarListado();
            this.btnAccionUno.Enabled = true;
            this.btnReiniciarFiltros.Enabled = true;
        }

        private void CalcularRecaudacionDeViaje()
        {
            Viaje viajeSeleccionado = (Viaje)base.fuenteDeDatos.Current;
            if(viajeSeleccionado is null)
            {
                return;
            }
            float recaudacionPremium = viajeSeleccionado.PrecioPremium * viajeSeleccionado.PasajerosPremiumABordo;
            float recaudacionTurista = viajeSeleccionado.PrecioTurista * viajeSeleccionado.PasajerosTuristasABordo;
            MessageBox.Show($"Recaudacion Premium: ${recaudacionPremium}. \nRecaudacion Turista: ${recaudacionTurista}.\nTotal: ${recaudacionPremium + recaudacionTurista}",
                $"{viajeSeleccionado}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalcularRecaudacionPorServicio()
        {
            float acumuladorRegional = 0;
            float acumuladorExtraregional = 0;
            foreach (Venta venta in SistemaCruceros.ventas)
            {
                if(venta.EsServicioRegional)
                {
                    acumuladorRegional += venta.PrecioNeto;
                } else
                {
                    acumuladorExtraregional += venta.PrecioNeto;
                }
            }
            MessageBox.Show($"Recaudacion por servicios regionales: ${acumuladorRegional}.\n" +
                $"Recaudacion por servicios extraregionales: ${acumuladorExtraregional}.\n" +
                $"Total: ${acumuladorExtraregional + acumuladorRegional}");
        }

        private void btnAccionDos_Click(object sender, EventArgs e)
        {
            base.fuenteDeDatos.DataSource = SistemaCruceros.contadorRecaudacionDestinos.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value).Reverse();
            base.ActualizarListado();
            this.btnReiniciarFiltros.Enabled = false;
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            CalcularRecaudacionDeViaje();
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            CalcularRecaudacionPorServicio();
        }
    }
}
