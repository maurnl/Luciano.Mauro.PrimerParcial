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
        private List<FrmListadoBase> formsListadoAbiertos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(Usuario user, FrmLogin login, SistemaApp sistema) : this()
        {
            this.lblError.Text = "";
            this.user = user;
            this.login = login;
            this.sistema = sistema;
            this.formsListadoAbiertos = new List<FrmListadoBase>(3);
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
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
            AbrirFormListado(((Button)sender).Name);
        }
        private void btnListadoPasajeros_Click(object sender, EventArgs e)
        {
            AbrirFormListado(((Button)sender).Name);
        }

        private void ActualizarFormListados()
        {
            foreach (FrmListadoBase formListadoAbierto in this.formsListadoAbiertos)
            {
                formListadoAbierto.ActualizarListado();
            }
        }

        private void CerrarFormListados()
        {
            foreach (FrmListadoBase formListadoAbierto in this.formsListadoAbiertos)
            {
                formListadoAbierto.Close();
            }
        }

        private FrmListadoBase ObtenerListadoAbierto(string tipo)
        {
            FrmListadoBase formRetorno = null;
            foreach (FrmListadoBase formListadoAbierto in this.formsListadoAbiertos)
            {
                if(tipo == "viajes" && formListadoAbierto is FrmListadoViajes formListadoViajes)
                {
                    formRetorno = formListadoViajes;
                } else if(tipo == "pasajeros" && formListadoAbierto is FrmListadoPasajeros formListadoPasajeros){
                    formRetorno = formListadoPasajeros;
                }
            }
            return formRetorno;
        }

        private void AbrirFormListado(string listado)
        {
            FrmListadoBase formListado;
            try
            {
                switch (listado)
                {
                    case "btnListadoPasajeros":
                        formListado = new FrmListadoPasajeros(this.sistema.Viajes);
                        break;
                    case "btnListadoViajes":
                        formListado = new FrmListadoViajes(this.sistema.Viajes);
                        break;
                    default:
                        formListado = new FrmListadoPasajeros(this.sistema.Viajes);
                        break;
                }
                formListado.Show();
                this.formsListadoAbiertos.Add(formListado);
            }
            catch(Exception listadoEx)
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = listadoEx.Message;
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarFormListados();
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

        private void btnAltaPasajero_Click(object sender, EventArgs e)
        {
            FrmListadoViajes formListadoViajesAbierto = (FrmListadoViajes)ObtenerListadoAbierto("viajes");
            if(formListadoViajesAbierto == null)
            {
                return;
            }
            Viaje viajeSeleccionado = formListadoViajesAbierto.ViajeSeleccionado;
            FrmAltaPasajero formAltaPasajero = new FrmAltaPasajero(viajeSeleccionado);
            if(formAltaPasajero.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach(Pasajero pasajeroPosible in formAltaPasajero.PasajerosPosibles)
                    {
                        viajeSeleccionado += pasajeroPosible;
                    }
                }catch(Exception agregarPasajerosEx)
                {
                    this.lblError.ForeColor = Color.Red;
                    this.lblError.Text = agregarPasajerosEx.Message;
                }
            }
            FrmListadoPasajeros frmListadoPasajeros = ((FrmListadoPasajeros)ObtenerListadoAbierto("pasajeros"));
            if (frmListadoPasajeros != null)
            {
                frmListadoPasajeros.ViajeSeleccionado = viajeSeleccionado;

            }
            ActualizarFormListados();
        }
    }
}
