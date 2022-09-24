using Parcial.Entities;
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
        private SistemaApp sistema;
        private FrmListadoViajes formListadoViajes;
        private FrmListadoPasajeros formListadoPasajeros;

        public FrmPrincipalContenedor(Usuario user, FrmLogin login, SistemaApp sistema)
        {
            InitializeComponent();
            this.user = user;
            this.login = login;
            this.sistema = sistema;
            this.formListadoViajes = new FrmListadoViajes(this.sistema.Viajes);
            this.formListadoPasajeros = new FrmListadoPasajeros(this.sistema.Viajes);
        }

        private void FrmPrincipalContenedor_Load(object sender, EventArgs e)
        {
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
            this.IsMdiContainer = true;
            this.formListadoPasajeros.MdiParent = this;
            this.formListadoViajes.MdiParent = this;
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formListadoPasajeros.Hide();
            this.formListadoViajes.Show();
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formListadoViajes.Hide();
            this.formListadoPasajeros.Show();
        }

        private void nuevoViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViaje formViaje = new FrmViaje(this.sistema.Flota, this.sistema.Puertos);
            if (formViaje.ShowDialog() == DialogResult.OK)
            {
                this.sistema.Viajes.Add(formViaje.Viaje);
                ActualizarFormListados();
            }
        }

        private void ActualizarFormListados()
        {
            formListadoPasajeros.ActualizarListado();
            formListadoViajes.ActualizarListado();
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
    }
}
