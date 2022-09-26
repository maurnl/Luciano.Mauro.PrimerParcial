﻿using Parcial.Entities;
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
    public partial class FrmSimularTiempo : Form
    {
        public FrmSimularTiempo()
        {
            InitializeComponent();
            this.Text = "Avanzar tiempo";
            this.label1.Text = "Ingrese cantidad de dias a avanzar:";
            this.btnAceptar.Text = "Avanzar dias";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SistemaCruceros.Viajes.Count; i++)
            {
                SistemaCruceros.Viajes[i] += TimeSpan.FromDays((double)this.nudDias.Value);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}