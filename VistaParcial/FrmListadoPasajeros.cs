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
            this.lblCombobox.Text = "Mostrando viaje...";
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = SistemaCruceros.Viajes;
        }

        private void PintarListado(int cantFilas)
        {
            for (int i = 0; i < cantFilas; i++)
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
            List<Pasajero> pasajeros = SistemaCruceros.Viajes[this.cboCombobox.SelectedIndex].Pasajeros;
            base.fuenteDeDatos.DataSource = pasajeros;
            base.ActualizarListado();
            PintarListado(pasajeros.Count);
        }
    }
}
