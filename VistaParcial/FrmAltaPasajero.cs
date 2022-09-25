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
        }

        public FrmAltaPasajero(Viaje viaje) : this()
        {
            this.pasajeros = new List<Pasajero>();
            this.viaje = viaje;
        }

        private void FrmAltaPasajero_Load(object sender, EventArgs e)
        {
            this.cboTipoPasajero.DataSource = Enum.GetValues(typeof(TipoPasajero));
            this.btnEliminarPasajero.Enabled = false;
            SetEquipajeControlsActivados(false);
        }

        private void ActualizarEquipajes()
        {
            int cantidadEquipajes = this.pasajeroActual.CantidadEquipaje;
            this.lstEquipajes.Items.Clear();
            this.lstEquipajes.Items.Add("No se registraron equipajes...");
            if (cantidadEquipajes > 0)
            {
                this.lstEquipajes.Items.Clear();
                for (int i = 0; i < cantidadEquipajes; i++)
                {
                    this.lstEquipajes.Items.Add(Equipaje.Mostrar(this.pasajeroActual[i]));
                }
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
            ActualizarEquipajes();
        }
        private void lstPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstPasajeros.SelectedIndex != -1)
            {
                this.pasajeroActual = this.pasajeros[this.lstPasajeros.SelectedIndex];
                ActualizarEquipajes();
                SetEquipajeControlsActivados(true);
            }
            else
            {
                SetEquipajeControlsActivados(false);
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
            ActualizarEquipajes();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRegistrarEquipaje_Click(object sender, EventArgs e)
        {
            float peso = (int)this.nudPeso.Value;
            bool esDeMano = this.chkEsDeMano.Checked;
            Equipaje nuevoEquipaje = new Equipaje(peso, esDeMano);
            try
            {
                this.pasajeroActual += nuevoEquipaje;
            }catch(Exception agregarEquipajeEx)
            {
                this.lblError.Text = agregarEquipajeEx.Message;
            }
            ActualizarEquipajes();
        }

        private void SetEquipajeControlsActivados(bool valor)
        {
            this.lstEquipajes.BackColor = Color.LightGray;
            if(valor)
            {
                this.lstEquipajes.BackColor = Color.White;
            }
            foreach (Control control in this.gpbEquipajes.Controls)
            {
                control.Enabled = valor;
            }
        }
    }
}
