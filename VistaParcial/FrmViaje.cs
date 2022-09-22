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
            this.Text = "Registro de viaje";
            this.lblError.ForeColor = Color.Red;
            this.lblError.Text = "";
        }
        
        public FrmViaje(List<Crucero> cruceros, List<Puerto> puertos) : this()
        {
            this.cboCrucero.DataSource = cruceros;
            this.cboOrigen.DataSource = new List<Puerto>(puertos);
            this.cboDestino.DataSource = new List<Puerto>(puertos);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Crucero crucero = (Crucero)this.cboCrucero.SelectedItem;
            Puerto origen = (Puerto)this.cboOrigen.SelectedItem;
            Puerto destino = (Puerto)this.cboDestino.SelectedItem;
            DateTime fechaSalida = this.dtpFechaSalida.Value;
            try
            {
                this.viajeNuevo = new Viaje(origen, destino, crucero, fechaSalida);
                this.DialogResult = DialogResult.OK;
            }catch(Exception viajeEx)
            {
                this.lblError.Text = viajeEx.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
