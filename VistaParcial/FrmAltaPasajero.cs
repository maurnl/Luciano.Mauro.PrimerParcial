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
    public partial class FrmAltaPasajero : Form
    {
        private Pasajero? pasajeroActual;
        private Viaje viaje;
        private List<Pasajero> pasajeros;

        public List<Pasajero> PasajerosPosibles
        {
            get
            {
                return this.pasajeros;
            }
        }
        public FrmAltaPasajero()
        {
            InitializeComponent();
            this.pasajeros = new List<Pasajero>();
        }

        private void FrmAltaPasajero_Load(object sender, EventArgs e)
        {
            this.cboTipoPasajero.DataSource = Enum.GetValues(typeof(TipoPasajero));
            this.btnEliminarPasajero.Enabled = false;
        }

        private void ActualizarListados()
        {
            this.lstEquipajes.Items.Clear();
            foreach (Equipaje valijasDelPasajero in this.pasajeroActual.Equipaje)
            {
                this.lstEquipajes.Items.Add(valijasDelPasajero.ToString());
            }
        }


        private void btnRegistrarPasajero_Click(object sender, EventArgs e)
        {
            string nombreCompleto = this.txtNombre.Text + " " + this.txtApellido.Text;
            string dni = this.txtDni.Text;
            DateTime fechaNacimiento = this.dtpFechaNacimiento.Value;
            DateTime fechaExpedido = this.dtpFechaPasaporte.Value;
            TipoPasajero tipo = (TipoPasajero)this.cboTipoPasajero.SelectedItem;
            Pasajero nuevoPasajero = new Pasajero(nombreCompleto, new Pasaporte(int.Parse(dni), fechaExpedido), fechaNacimiento, tipo);
            this.pasajeros.Add(nuevoPasajero);
            this.lstPasajeros.Items.Add(nuevoPasajero.ToString());
            this.pasajeroActual = nuevoPasajero;
            this.btnEliminarPasajero.Enabled = true;
            ActualizarListados();
        }

        private void lstPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstPasajeros.SelectedIndex != -1)
            {
                this.pasajeroActual = this.pasajeros[this.lstPasajeros.SelectedIndex];
            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstPasajeros.SelectedIndex;
            this.pasajeros.RemoveAt(indiceSeleccionado);
            this.lstPasajeros.Items.RemoveAt(indiceSeleccionado);
            if (indiceSeleccionado == 0)
            {
                this.btnEliminarPasajero.Enabled = false;
                this.lstEquipajes.Items.Clear();
                return;
            }
            this.lstPasajeros.SelectedIndex = indiceSeleccionado - 1;
            this.pasajeroActual = this.pasajeros[indiceSeleccionado - 1];
            ActualizarListados();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
