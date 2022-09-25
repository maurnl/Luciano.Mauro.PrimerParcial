using Parcial.Entities;
using Parcial.Login;
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
    public partial class FrmListadoBase : Form
    {
        protected BindingSource fuenteDeDatos;
        public bool TieneDatosCargados
        {
            get
            {
                return this.fuenteDeDatos.Count > 0;
            }
        }
        public FrmListadoBase()
        {
            InitializeComponent();
            this.fuenteDeDatos = new BindingSource();
            this.dgvListado.DataSource = this.fuenteDeDatos;
            this.dgvListado.ScrollBars = ScrollBars.Both;
            this.dgvListado.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.lblError.Text = "";
        }

        protected virtual void LimpiarFiltros()
        {
            foreach (DataGridViewRow fila in this.dgvListado.Rows)
            {
                fila.Height = 25;
            }
        }
        
        protected internal void ActualizarListado()
        {
            this.fuenteDeDatos.ResetBindings(false);
        }

        protected virtual void dgvListado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
    }
}
