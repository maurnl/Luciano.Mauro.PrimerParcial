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
    public partial class FrmPrincipal : Form
    {
        private Usuario user;
        private FrmLogin login;
        private SistemaApp sistema;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.lblError.Text = "";
        }

        public FrmPrincipal(Usuario user, FrmLogin login, SistemaApp sistema) : this()
        {
            this.user = user;
            this.login = login;
            this.sistema = sistema;
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Show();

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            FrmViaje formViaje = new FrmViaje(this.sistema.Flota, this.sistema.Puertos);

            if (formViaje.ShowDialog() == DialogResult.OK)
            {
                this.sistema.Viajes.Add(formViaje.Viaje);
                ActualizarFormListados();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoViajes formListado = new FrmListadoViajes(this.sistema.Viajes);
                formListado.Show();
            }catch(Exception listadoViajesEx)
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = listadoViajesEx.Message;
            }
        }

        private void ActualizarFormListados()
        {
            FormCollection formsAbiertos = Application.OpenForms;
            foreach (Form formAbierto in formsAbiertos)
            {
                if(formAbierto is FrmListadoBase formListado)
                {
                    formListado.ActualizarListado();
                }
            }
        }
    }
}
