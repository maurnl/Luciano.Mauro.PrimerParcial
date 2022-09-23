using Parcial.Entities;
using Parcial.Login;
using Parcial.Util;
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
    public partial class FrmListadoBase : Form
    {
        protected BindingSource fuenteDeDatos;
        public bool TieneDatosCargados
        {
            get
            {
                return this.fuenteDeDatos.Count > 0;
            }
        }
        public FrmListadoBase()
        {
            InitializeComponent();
            this.fuenteDeDatos = new BindingSource();
            this.dgvListado.DataSource = this.fuenteDeDatos;
            this.dgvListado.ScrollBars = ScrollBars.Both;
            this.dgvListado.ReadOnly = true;
        }

        protected internal virtual void LimpiarFiltros()
        {
            foreach (DataGridViewRow fila in this.dgvListado.Rows)
            {
                fila.Height = 25;
            }
        }
        
        protected internal void ActualizarListado()
        {
            this.fuenteDeDatos.ResetBindings(false);
        }

        protected virtual void dgvListado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //DataGridViewRow filaActual = this.dgvListado.Rows[e.RowIndex];
            //if (filaActual.DataBoundItem is Viaje viaje)
            //{
            //    if (viaje.ViajeFinalizado)
            //    {
            //        filaActual.DefaultCellStyle.BackColor = Color.LightSalmon;
            //    } 
            //    else
            //    {
            //        filaActual.DefaultCellStyle.BackColor = Color.LightGreen;
            //    }
            //    if(viaje.PasajerosABordo >= viaje.Crucero.CapacidadPasajeros)
            //    {
            //        filaActual.DefaultCellStyle.BackColor = Color.Yellow;
            //    }
            //} else if (filaActual.DataBoundItem is Pasajero pasajero)
            //{
            //    if (pasajero.TipoPasajero == TipoPasajero.Premium)
            //    {
            //        filaActual.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            //    }
            //    else
            //    {
            //        filaActual.DefaultCellStyle.BackColor = Color.LightBlue;
            //    }
            //}

        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
    }
}
