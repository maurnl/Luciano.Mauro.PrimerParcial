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
    public partial class FrmMain : Form
    {
        private Usuario user;
        private FrmLogin login;
        private SistemaApp sistema;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Usuario user, FrmLogin login, SistemaApp sistema) : this()
        {
            this.user = user;
            this.login = login;
            this.sistema = sistema;
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
        }
        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            FrmViaje formViaje = new FrmViaje(this.sistema.Flota, this.sistema.Puertos);

            if(formViaje.ShowDialog() == DialogResult.OK)
            {
                this.sistema.Viajes.Add(formViaje.Viaje);
            }
            CargarListado("listadoViajes");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Show();
        }

        private void CargarListado(string listado)
        {
            this.dgvListado.DataSource = null;
            switch (listado)
            {
                case "listadoViajes":
                    if(this.sistema.Viajes.Count > 0)
                    {
                        this.dgvListado.DataSource = this.sistema.Viajes;
                    }
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CargarListado("listadoViajes");
        }
    }
}
