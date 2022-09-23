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
        }
        public FrmListadoViajes(List<Viaje> listaEntidades) : this()
        {
            if (listaEntidades != null && listaEntidades.Count == 0)
            {
                throw new Exception("Cargue algun dato a la lista primero.");
            }
            base.fuenteDeDatos.DataSource = listaEntidades;
            base.btnAccionUno.Text = "Agregar pasajero...";
            ActualizarListado();
        }

        private void btnFiltroUno_Click(object sender, EventArgs e)
        {

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

        protected internal override void LimpiarFiltros()
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
                if (viaje.ViajeFinalizado)
                {
                    filaActual.DefaultCellStyle.BackColor = Color.LightSalmon;
                    filaActual.Visible = false;
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
            base.LimpiarFiltros();
            LimpiarFiltros();
        }
    }
}
