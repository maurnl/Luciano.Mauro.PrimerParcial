using Parcial.Entities;
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
    public partial class FrmListadoPasajeros : FrmListadoBase
    {
        public FrmListadoPasajeros()
        {
            InitializeComponent();
        }
        private void FrmListadoPasajeros_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de pasajeros";
            this.lblCombobox.Text = "Mostrando viaje...";
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = SistemaCruceros.viajes;
        }

        protected override void PintarFilas()
        {
            for (int i = 0; i < this.dgvListado.RowCount; i++)
            {
                DataGridViewRow filaActual = base.dgvListado.Rows[i];
                if (filaActual.DataBoundItem is Pasajero pasajero)
                {
                    filaActual.DefaultCellStyle.BackColor = Color.LightBlue;
                    if (pasajero.TipoPasajero == TipoPasajero.Premium)
                    {
                        filaActual.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                    }
                }
            }
        }

        private void cboCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Pasajero> pasajeros = SistemaCruceros.viajes[this.cboCombobox.SelectedIndex].Pasajeros;
            base.fuenteDeDatos.DataSource = pasajeros;
            base.ActualizarListado();
        }
    }
}
