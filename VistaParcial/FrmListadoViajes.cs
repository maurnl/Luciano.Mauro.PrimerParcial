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
            this.fuenteDeDatos.DataSource = listaEntidades;
            ActualizarListado();
        }


    }
}
