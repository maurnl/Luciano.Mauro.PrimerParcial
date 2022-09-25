﻿using Parcial.Entities;
using Parcial.Login;
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
    public partial class FrmPrincipalContenedor : Form
    {
        private Usuario user;
        private FrmLogin login;
        private FrmListadoViajes formListadoViajes;
        private FrmListadoPasajeros formListadoPasajeros;
        private FrmListadoVentas formListadoVentas;

        public FrmPrincipalContenedor(Usuario user, FrmLogin login)
        {
            InitializeComponent();
            this.user = user;
            this.login = login;
            this.formListadoViajes = new FrmListadoViajes();
            this.formListadoPasajeros = new FrmListadoPasajeros();
            this.formListadoVentas = new FrmListadoVentas();
        }

        private void FrmPrincipalContenedor_Load(object sender, EventArgs e)
        {
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
            this.IsMdiContainer = true;
            this.formListadoPasajeros.MdiParent = this;
            this.formListadoViajes.MdiParent = this;
            this.formListadoVentas.MdiParent = this;
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListado("viajes");
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListado("pasajeros");
        }

        private void FrmPrincipalContenedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void FrmPrincipalContenedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListado("ventas");
        }

        private void MostrarListado(string nombreListado)
        {
            this.formListadoPasajeros.Hide();
            this.formListadoVentas.Hide();
            this.formListadoViajes.Hide();
            switch (nombreListado)
            {
                case "viajes":
                    this.formListadoViajes.Show();
                    break;
                case "pasajeros":
                    this.formListadoPasajeros.Show();
                    break;
                case "ventas":
                    this.formListadoVentas.Show();
                    break;
                default:
                    this.formListadoViajes.Show();
                    break;
            }
        }

        private void simularPasoDelTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSimularTiempo frmSimularTiempo = new FrmSimularTiempo();
            if(frmSimularTiempo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Tiempo actualizado!");
            }
            MostrarListado("viajes");
        }

        private void nuevoViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViaje formViaje = new FrmViaje();
            if(formViaje.ShowDialog() == DialogResult.OK)
            {
                SistemaCruceros.Viajes.Add(formViaje.ViajeDelForm);
            }
            MostrarListado("viajes");
        }
    }
}
