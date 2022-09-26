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
    public partial class FrmListadoVentas : FrmListadoBase
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
            base.fuenteDeDatos.DataSource = SistemaCruceros.ventas;
        }
    }
}
