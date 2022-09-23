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
        }

        protected internal void LimpiarFiltros()
        {
            this.fuenteDeDatos.Filter = null;
        }
        
        protected internal void ActualizarListado()
        {
            this.fuenteDeDatos.ResetBindings(false);
        }

        private void dgvListado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow filaActual = this.dgvListado.Rows[e.RowIndex];
            if (filaActual.Cells[0].GetType() == typeof(bool) && (bool)filaActual.Cells[0].Value)
            {
                filaActual.DefaultCellStyle.BackColor = Color.LightSalmon;
            }
        }
    }
}
