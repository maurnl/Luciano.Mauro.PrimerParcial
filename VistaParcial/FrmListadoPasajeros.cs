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
        public FrmListadoPasajeros()
        {
            InitializeComponent();
        }
        public FrmListadoPasajeros(List<Viaje> listaEntidades) : this()
        {
            if (listaEntidades != null && listaEntidades.Count == 0)
            {
                throw new Exception("Cargue algun dato a la lista primero.");
            }
            this.lblCombobox.Text = "Mostrando viaje...";
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = listaEntidades;
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
