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
        private Pasajero pasajeroActual;
        private Viaje viaje;
        private List<Pasajero> pasajerosPosibles;

        public List<Pasajero> PasajerosPosibles
        {
            get
            {
                return this.pasajerosPosibles;
            }
        }
        public FrmAltaPasajero()
        {
            InitializeComponent();
        }

        public FrmAltaPasajero(Viaje viaje) : this()
        {
            this.pasajerosPosibles = new List<Pasajero>();
            this.viaje = viaje;
        }

        private void FrmAltaPasajero_Load(object sender, EventArgs e)
        {
            this.cboTipoPasajero.DataSource = Enum.GetValues(typeof(TipoPasajero));
            this.cboTipoPasajero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.lblError.Text = "";
            this.lblErrorBusqueda.Text = "";
            this.btnEliminarPasajero.Enabled = false;
            this.groupBox1.BackColor = Color.FromArgb(150, 209, 209, 209);
            this.groupBox2.BackColor = Color.FromArgb(150, 209, 209, 209);
            this.groupBox3.BackColor = Color.FromArgb(150, 209, 209, 209);
            this.gpbEquipajes.BackColor = Color.FromArgb(150, 209, 209, 209);
            this.cboGenero.DataSource = Enum.GetValues(typeof(Genero));
            this.cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            SetEquipajeControls(false);
            ActualizarDatosDeViaje();
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
                    this.lstEquipajes.Items.Add(this.pasajeroActual[i].ToString());
                }
            }
        }


        private void btnRegistrarPasajero_Click(object sender, EventArgs e)
        {
            string nombreCompleto = this.txtNombre.Text + " " + this.txtApellido.Text;
            string dni = this.txtDni.Text;
            DateTime fechaNacimiento = this.dtpFechaNacimiento.Value;
            TipoPasajero tipo = (TipoPasajero)this.cboTipoPasajero.SelectedItem;
            Genero genero = (Genero)this.cboGenero.SelectedItem;
            Pasajero nuevoPasajero = SistemaCruceros.ObtenerPasajeroEnSistema(int.Parse(dni));
            if (nuevoPasajero is null)
            {
                nuevoPasajero = new Pasajero(nombreCompleto, int.Parse(dni), fechaNacimiento, tipo, genero);
            }
            this.pasajerosPosibles.Add(nuevoPasajero);
            this.lstPasajeros.Items.Add(nuevoPasajero.ToString());
            this.pasajeroActual = nuevoPasajero;
            this.btnEliminarPasajero.Enabled = true;
            this.lblErrorBusqueda.Text = "";
            LimpiarDatosPasajero();
            ActualizarEquipajes();
        }
        private void lstPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstPasajeros.SelectedIndex != -1)
            {
                this.pasajeroActual = this.pasajerosPosibles[this.lstPasajeros.SelectedIndex];
                ActualizarEquipajes();
                SetEquipajeControls(true);
            }
            else
            {
                SetEquipajeControls(false);
            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstPasajeros.SelectedIndex;
            this.pasajerosPosibles.RemoveAt(indiceSeleccionado);
            this.lstPasajeros.Items.RemoveAt(indiceSeleccionado);
            if (indiceSeleccionado == 0)
            {
                this.btnEliminarPasajero.Enabled = false;
                this.lstEquipajes.Items.Clear();
                return;
            }
            this.lstPasajeros.SelectedIndex = indiceSeleccionado - 1;
            this.pasajeroActual = this.pasajerosPosibles[indiceSeleccionado - 1];
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
            this.lblError.Text = "";
            float peso = (int)this.nudPeso.Value;
            bool esDeMano = this.chkEsDeMano.Checked;
            Equipaje nuevoEquipaje = new Equipaje(peso, esDeMano);
            try
            {
                this.pasajeroActual += nuevoEquipaje;
            }catch(Exception agregarEquipajeEx)
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = agregarEquipajeEx.Message;
            }
            ActualizarEquipajes();
        }

        private void SetEquipajeControls(bool valor)
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

        private void ActualizarDatosDeViaje()
        {
            float capacidadBodegaTotal = this.viaje.Crucero.PesoBodegaMaximo;
            float capacidadBodegaActual = this.viaje.Crucero.PesoBodegaActual;

            int capacidadPasajerosTurista = this.viaje.Crucero.CapacidadPasajerosTurista;
            int pasajerosTuristaABordo = this.viaje.PasajerosTuristasABordo;

            int capacidadPasajerosPremium = this.viaje.Crucero.CapacidadPasajerosPremium;
            int pasajerosPremiumABordo = this.viaje.PasajerosPremiumABordo;

            this.lblLugaresPremiumDisponible.ForeColor = Color.Green;
            this.lblLugaresTuristaDisponibles.ForeColor = Color.Green;
            this.lblPesoDisponible.ForeColor = Color.Green;
            if (pasajerosTuristaABordo >= capacidadPasajerosTurista * 80 / 100)
            {
                this.lblLugaresTuristaDisponibles.ForeColor = Color.Orange;
            }
            if (pasajerosPremiumABordo >= capacidadPasajerosPremium * 80 / 100)
            {
                this.lblLugaresPremiumDisponible.ForeColor = Color.Orange;
            }
            if (capacidadBodegaActual >= capacidadBodegaTotal * 80 / 100)
            {
                this.lblPesoDisponible.ForeColor = Color.Orange;
            }

            this.lblLugaresPremiumDisponible.Text = $"Pasajeros Premium: {pasajerosPremiumABordo}/{capacidadPasajerosPremium}.";
            this.lblLugaresTuristaDisponibles.Text = $"Pasajeros Turista: {pasajerosTuristaABordo}/{capacidadPasajerosTurista}.";
            this.lblPesoDisponible.Text = $"Peso en bodega: {capacidadBodegaActual}/{capacidadBodegaTotal} kg";
        }

        private void LimpiarDatosPasajero()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtDni.Text = "";
            this.dtpFechaNacimiento.Value = SistemaCruceros.FechaDelSistema;
        }

        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroBusqueda = SistemaCruceros.ObtenerPasajeroEnSistema(int.Parse(this.txtDni.Text));
            if(pasajeroBusqueda is null)
            {
                this.lblErrorBusqueda.ForeColor = Color.Red;
                this.lblErrorBusqueda.Text = "No se encontro el pasajero";
                return;
            }
            this.lblErrorBusqueda.ForeColor = Color.Green;
            this.lblErrorBusqueda.Text = "Pasajero encontrado y cargado";
            this.txtNombre.Text = pasajeroBusqueda.NombreCompleto.Split(" ")[0];
            this.txtApellido.Text = pasajeroBusqueda.NombreCompleto.Split(" ")[1];
            this.txtDni.Text = pasajeroBusqueda.Dni.ToString();
            this.dtpFechaNacimiento.Value = pasajeroBusqueda.FechaNacimiento;
            this.cboTipoPasajero.SelectedItem = pasajeroBusqueda.TipoPasajero;
        }
    }
}
