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
        List<Viaje> viajesEnSistema;
        List<Venta> ventasFiltradas;
        public FrmListadoVentas()
        {
            InitializeComponent();
            this.ventasFiltradas = new List<Venta>();
            this.viajesEnSistema = new List<Viaje>();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            this.btnAccionUno.Text = "Calcular recaudacion";
            this.btnAccionDos.Text = "Mostrar destino mas demandado";
            this.viajesEnSistema.AddRange(SistemaCruceros.Viajes);  
            this.viajesEnSistema.AddRange(SistemaCruceros.HistorialViajes);
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = viajesEnSistema;
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
            foreach (Venta ventaEnSistema in SistemaCruceros.Ventas)
            {
                if (viajeSeleccionado.Equals(ventaEnSistema.Viaje))
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
            Viaje viajeSeleccionado = (Viaje)this.cboCombobox.SelectedItem;
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

        protected override string ObtenerAyuda()
        {
            return base.ObtenerAyuda() + "- Presione 'Calcular recaudación' para calcular la recaudación total del viaje seleccionado.\n" +
                "- Presione 'Mostrar destino más demandado' para mostrar el destino con más ventas.";
        }
        private void btnAccionDos_Click(object sender, EventArgs e)
        {
            MostrarDestinoMasDemandado(SistemaCruceros.ObtenerDestinoMasDemandado());
        }
    }
}
