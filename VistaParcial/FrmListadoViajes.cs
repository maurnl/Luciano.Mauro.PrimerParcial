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
    public partial class FrmListadoViajes : FrmListadoBase
    {
        public FrmListadoViajes()
        {
            InitializeComponent();
            base.fuenteDeDatos.DataSource = SistemaCruceros.Viajes;
            base.btnAccionUno.Text = "Agregar pasajero...";
            base.ActualizarListado();
        }

        private void btnFiltroUno_Click(object sender, EventArgs e)
        {
            Viaje viajeSeleccionado = (Viaje)this.fuenteDeDatos.Current;
            FrmAltaPasajero formAltaPasajero = new FrmAltaPasajero(viajeSeleccionado);
            if (formAltaPasajero.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Pasajero> clientes = new List<Pasajero>();
                    foreach (Pasajero pasajeroPosible in formAltaPasajero.PasajerosPosibles)
                    {
                        viajeSeleccionado += pasajeroPosible;
                        clientes.Add(pasajeroPosible);
                    }
                    Venta venta = new Venta(viajeSeleccionado, clientes);
                    SistemaCruceros.Ventas.Add(venta);
                }
                catch (Exception agregarPasajerosEx)
                {
                    MessageBox.Show(agregarPasajerosEx.Message);
                    //this.lblError.ForeColor = Color.Red;
                    //this.lblError.Text = agregarPasajerosEx.Message;
                }
            }
            base.ActualizarListado();
        }

        private void chkFiltroUno_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
            this.chkFiltroUno.Enabled = false;
        }

        private void chkFiltroDos_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
            this.chkFiltroDos.Enabled = false;

        }

        private void AplicarFiltros()
        {
            bool checkGimnasio = this.chkFiltroUno.Checked;
            bool checkPiscina = this.chkFiltroDos.Checked;
            if (checkPiscina || checkGimnasio)
            {
                foreach (DataGridViewRow fila in base.dgvListado.Rows)
                {
                    if(!((Viaje)fila.DataBoundItem).Crucero.TieneGimnasio && checkGimnasio
                        || !((Viaje)fila.DataBoundItem).Crucero.TienePiscina && checkPiscina)
                    {
                        fila.Height = 0;
                    }
                }
            }
        }

        protected override void LimpiarFiltros()
        {
            base.LimpiarFiltros();
            this.chkFiltroUno.Enabled = true;            
            this.chkFiltroDos.Enabled = true;
            this.chkFiltroUno.Checked = false;
            this.chkFiltroDos.Checked = false;
        }

        protected override void dgvListado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow filaActual = this.dgvListado.Rows[e.RowIndex];
            if (filaActual.DataBoundItem is Viaje viaje)
            {
                if (viaje.ViajeEstaFinalizado)
                {
                    filaActual.DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    filaActual.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (viaje.PasajerosABordo >= viaje.Crucero.CapacidadPasajeros)
                {
                    filaActual.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void btnAccionDos_Click(object sender, EventArgs e)
        {
            Viaje viajeAEditar = ((Viaje)base.fuenteDeDatos.Current);
            FrmViaje formEditarViaje = new FrmViaje(viajeAEditar);
            if (formEditarViaje.ShowDialog() == DialogResult.OK)
            {
                base.ActualizarListado();
            }
        }

        private void FrmListadoViajes_Load(object sender, EventArgs e)
        {
            this.btnAccionDos.Text = "Editar viaje...";
        }
    }
}
