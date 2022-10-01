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
        private FrmListadoViajes formListadoViajes;
        private FrmListadoPasajeros formListadoPasajeros;
        private FrmListadoVentas formListadoVentas;
        private FrmListadoHistorial formListadoHistorial;

        public FrmPrincipalContenedor(Usuario user, FrmLogin login)
        {
            InitializeComponent();
            this.user = user;
            this.login = login;
            this.formListadoViajes = new FrmListadoViajes();
            this.formListadoPasajeros = new FrmListadoPasajeros();
            this.formListadoVentas = new FrmListadoVentas();
            this.formListadoHistorial = new FrmListadoHistorial();
        }

        private void FrmPrincipalContenedor_Load(object sender, EventArgs e)
        {
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
            this.lblBienvenido.Text = $"Bienvenido, {this.user.NombreCompleto}";
            this.IsMdiContainer = true;
            this.formListadoPasajeros.MdiParent = this;
            this.formListadoViajes.MdiParent = this;
            this.formListadoVentas.MdiParent = this;
            this.formListadoHistorial.MdiParent = this;
            ActualizarLabelFecha();
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

        private void MostrarListado(string nombreListado)
        {
            FrmListadoBase formMostrado;
            this.lblBienvenido.Visible = false;
            switch (nombreListado)
            {
                case "viajes":
                    formMostrado = formListadoViajes;
                    break;
                case "pasajeros":
                    formMostrado = formListadoPasajeros;
                    break;
                case "ventas":
                    formMostrado = formListadoVentas;
                    break;
                case "historico":
                    formMostrado = formListadoHistorial;
                    break;
                default:
                    formMostrado = formListadoViajes;
                    break;
            }
            formMostrado.Show();
            formMostrado.Activate();
            formMostrado.ActualizarListado();
        }

        private void nuevoViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViaje formViaje = new FrmViaje();
            if(formViaje.ShowDialog() == DialogResult.OK)
            {
                SistemaCruceros.viajes.Add(formViaje.ViajeDelForm);
            }
            MostrarListado("viajes");
        }

        private void unaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSpan tiempoASimular = TimeSpan.FromDays(5);
            int cantidadViajes = SistemaCruceros.viajes.Count;
            for (int i = cantidadViajes - 1; i >= 0; i--)
            {
                SistemaCruceros.viajes[i] += tiempoASimular;
            }
            SistemaCruceros.fechaDelSistema += tiempoASimular;
            SistemaCruceros.ActualizarViajesActivos();
            ActualizarLabelFecha();
            MostrarListado("viajes");
        }

        private void otroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSimularTiempo frmSimularTiempo = new FrmSimularTiempo();
            if (frmSimularTiempo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Tiempo actualizado!");
            }
            ActualizarLabelFecha();
            MostrarListado("viajes");
        }

        private void ActualizarLabelFecha()
        {
            this.fechaToolStripMenuItem.Text = "Fecha del sistema: " + SistemaCruceros.fechaDelSistema.ToShortDateString();
        }

        private void FrmPrincipalContenedor_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListado("viajes");
        }

        private void verListadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarListado("pasajeros");
        }

        private void verListadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarListado("ventas");
        }

        private void verListadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarListado("historico");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
