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
    public partial class FrmViaje : Form
    {
        private bool estaEditando;
        private Viaje viajeDelForm;
        public Viaje ViajeDelForm
        {
            get
            {
                return this.viajeDelForm;
            }
        }
        public FrmViaje()
        {
            InitializeComponent();
            this.estaEditando = false;
            this.Text = "Registro de viaje";
            this.lblError.ForeColor = Color.Red;
            this.lblError.Text = "";
            this.cboCrucero.DataSource = SistemaCruceros.flota;
            this.cboDestino.DataSource = new List<Puerto>(SistemaCruceros.puertos);
            this.cboOrigen.DataSource = new List<Puerto>(SistemaCruceros.puertos);
            this.cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCrucero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboOrigen.Enabled = false;
        }

        public FrmViaje(Viaje viaje) : this()
        {
            this.estaEditando = true;
            this.viajeDelForm = viaje;
            this.cboCrucero.SelectedItem = viaje.Crucero;
            this.cboOrigen.SelectedItem = viaje.Origen;
            this.cboDestino.SelectedItem = viaje.Destino;
            this.dtpFechaSalida.Value = viaje.Salida;
            this.viajeDelForm.Crucero.EstaEnViaje = false;
            this.btnAceptar.Text = "Aplicar cambios";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Crucero crucero = (Crucero)this.cboCrucero.SelectedItem;
            Puerto origen = (Puerto)this.cboOrigen.SelectedItem;
            Puerto destino = (Puerto)this.cboDestino.SelectedItem;
            DateTime fechaSalida = this.dtpFechaSalida.Value;
            try
            {
                if (estaEditando)
                {
                    this.viajeDelForm.Salida = this.dtpFechaSalida.Value;
                    this.viajeDelForm.Destino = (Puerto)this.cboDestino.SelectedItem;
                    this.viajeDelForm.Crucero.EstaEnViaje = true;
                }
                else
                {
                    this.viajeDelForm = new Viaje(origen, destino, crucero, fechaSalida);
                }
                this.DialogResult = DialogResult.OK;
            }catch(Exception viajeEx)
            {
                this.lblError.Text = viajeEx.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (estaEditando)
            {
                this.viajeDelForm.Crucero.EstaEnViaje = true;
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
