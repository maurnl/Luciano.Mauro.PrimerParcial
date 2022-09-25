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
    public partial class FrmListadoPasajeros : FrmListadoBase
    {
        public Viaje ViajeSeleccionado
        {
            set
            {
                this.fuenteDeDatos.DataSource = value.Pasajeros;
            }
        }

        public FrmListadoPasajeros()
        {
            InitializeComponent();
            this.lblCombobox.Text = "Mostrando viaje...";
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = SistemaCruceros.Viajes;
            this.fuenteDeDatos.DataSource = ((Viaje)this.cboCombobox.SelectedItem).Pasajeros;
            base.ActualizarListado();
        }

        private void cboCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fuenteDeDatos.DataSource = ((Viaje)this.cboCombobox.SelectedItem).Pasajeros;
            base.ActualizarListado();
        }
    }
}
