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
using VistaParcial.Properties;

namespace VistaParcial
{
    public partial class FrmListadoBase : Form
    {
        protected BindingSource fuenteDeDatos;
        public FrmListadoBase()
        {
            InitializeComponent();
            this.dgvListado.ScrollBars = ScrollBars.Both;
            this.fuenteDeDatos = new BindingSource();
            this.dgvListado.DataSource = this.fuenteDeDatos;
            this.dgvListado.ReadOnly = true;
            this.lblError.Text = "";
            this.ClientSize = new Size(1395, 850);
        }
        private void FrmListadoBase_Load(object sender, EventArgs e)
        {
            this.btnAyuda.Text = "";
            this.btnAyuda.BackgroundImage = (Image)Resources.ResourceManager.GetObject("ayuda_icon");
            this.btnAyuda.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnAyuda.Location = new Point(30, this.Height - 125);
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected virtual void LimpiarFiltros()
        {
            foreach (DataGridViewRow fila in this.dgvListado.Rows)
            {
                fila.Height = 25;
            }
        }
        
        public void ActualizarListado()
        {
            this.fuenteDeDatos.ResetBindings(false);
            this.PintarFilas();
        }

        protected virtual void PintarFilas()
        {
            if(this.dgvListado.DataSource == null)
            {
                return;
            }

            for (int i = 0; i < this.dgvListado.RowCount; i++)
            {
                DataGridViewRow filaActual = this.dgvListado.Rows[i];
                {
                    if (i%2 == 0)
                    {
                        filaActual.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
        }

            

        protected virtual string ObtenerAyuda()
        {
            return "- Presione 'Eliminar filtros' para eliminar los filtros actualmente aplicados al listado.\n" + 
                "- Seleccione un elemento presionando en la celda libre a la izquierda del ID de cada elemento.\n";
        }

        public void RemoverSeleccionDatagrid()
        {
            this.dgvListado.ClearSelection();
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ObtenerAyuda());
        }
    }
}
