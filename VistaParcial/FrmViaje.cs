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
        private Viaje viajeNuevo;
        public Viaje Viaje
        {
            get
            {
                return this.viajeNuevo;
            }
        }
        public FrmViaje()
        {
            InitializeComponent();
            this.estaEditando = false;
            this.Text = "Registro de viaje";
            this.lblError.ForeColor = Color.Red;
            this.lblError.Text = "";
        }
        
        public FrmViaje(List<Crucero> cruceros, List<Puerto> puertos) : this()
        {
            this.cboCrucero.DataSource = cruceros;

            this.cboDestino.DataSource = new List<Puerto>(puertos);
            this.cboDestino.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cboOrigen.DataSource = new List<Puerto>(puertos);
            this.cboOrigen.Enabled = false;
        }

        public FrmViaje(List<Crucero> cruceros, List<Puerto> puertos, Viaje viaje) : this(cruceros, puertos)
        {
            this.viajeNuevo = viaje;
            this.estaEditando = true;
            this.cboCrucero.SelectedItem = viaje.Crucero;
            this.cboOrigen.SelectedItem = viaje.Origen;
            this.cboDestino.SelectedItem = viaje.Destino;
            this.cboDestino.Enabled = false;
            this.dtpFechaSalida.Value = viaje.Salida;
            viaje.Crucero.EstaEnViaje = false;
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
                    this.viajeNuevo.Salida = this.dtpFechaSalida.Value;
                }
                else
                {
                    this.viajeNuevo = new Viaje(origen, destino, crucero, fechaSalida);
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
                this.viajeNuevo.Crucero.EstaEnViaje = true;
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
