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
    public partial class FrmListadoViajes : FrmListadoBase
    {
        public FrmListadoViajes()
        {
            InitializeComponent();
        }
        public FrmListadoViajes(List<Viaje> listaEntidades) : this()
        {
            if (listaEntidades != null && listaEntidades.Count == 0)
            {
                throw new Exception("Cargue algun dato a la lista primero.");
            }
            base.fuenteDeDatos.DataSource = listaEntidades;
            base.btnFiltroUno.Text = "Agregar pasajero...";
            ActualizarListado();
        }

        private void btnFiltroUno_Click(object sender, EventArgs e)
        {

        }

        private void chkFiltroUno_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFiltros();
        }

        private void chkFiltroDos_CheckedChanged(object sender, EventArgs e)
        {
            ToggleFiltros();
        }

        private void ToggleFiltros()
        {
            bool checkGimnasio = this.chkFiltroUno.Checked;
            bool checkPiscina = this.chkFiltroDos.Checked;

            if (checkGimnasio && checkPiscina)
            {
                base.fuenteDeDatos.Filter = "OfrecePiscina like '%SI%'";
            }else if(checkGimnasio && !checkPiscina)
            { 
                base.fuenteDeDatos.Filter = "OfreceGimnasio like '%SI%'";

            }else if (!checkGimnasio && checkPiscina)
            {
                base.fuenteDeDatos.Filter = "OfrecePiscina like '%SI%'";
            } else
            {
                base.LimpiarFiltros();
            }
            ActualizarListado();
        }
    }
}
