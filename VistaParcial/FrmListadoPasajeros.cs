using Parcial.Entities;
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
    public partial class FrmListadoPasajeros : FrmListadoBase
    {
        List<Pasajero> listaPasajerosFiltrada;
        public FrmListadoPasajeros()
        {
            InitializeComponent();
            this.listaPasajerosFiltrada = new List<Pasajero>();
        }
        private void FrmListadoPasajeros_Load(object sender, EventArgs e)
        {
            this.cboFiltro.Items.Add("DNI"); 
            this.cboFiltro.Items.Add("Nombre y apellido"); 
            this.cboFiltro.Items.Add("Edad");
            this.cboFiltro.SelectedIndex = 0;
            this.cboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnAccionDos.Text = "Base de datos de pasajeros";
            this.btnAccionUno.Text = "Ver informacion detallada...";
            this.Text = "Listado de pasajeros";
            this.lblCombobox.Text = "Mostrando viaje...";
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = SistemaCruceros.Viajes;
            if(SistemaCruceros.Viajes.Count != 0)
            {
                this.cboCombobox.SelectedIndex = 0;
            }
            LlenarListadoPorViaje();
            base.fuenteDeDatos.DataSource = listaPasajerosFiltrada;
        }

        protected override void PintarFilas()
        {
            for (int i = 0; i < this.dgvListado.RowCount; i++)
            {
                DataGridViewRow filaActual = base.dgvListado.Rows[i];
                if (filaActual.DataBoundItem is Pasajero pasajero)
                {
                    filaActual.DefaultCellStyle.BackColor = Color.LightBlue;
                    if (pasajero.TipoPasajero == TipoPasajero.Premium)
                    {
                        filaActual.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                    }
                }
            }
        }

        private void cboCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarListadoPorViaje();
            base.ActualizarListado();
        }

        private void LlenarListadoPorViaje()
        {
            this.listaPasajerosFiltrada.Clear();
            Viaje viajeSeleccionado = (Viaje)this.cboCombobox.SelectedItem;
            for (int i = 0; i < viajeSeleccionado.PasajerosABordo; i++)
            {
                listaPasajerosFiltrada.Add(viajeSeleccionado[i]);
            }
            base.fuenteDeDatos.DataSource = this.listaPasajerosFiltrada;
        }

        protected override string ObtenerAyuda()
        {
            return base.ObtenerAyuda() + "- Seleccione un pasajero presionando en la celda a la izquierda del ID.\n" +
                "- Presione 'Ver información detallada' para ver información sobre el pasajero seleccionado.\n" +
                "- Presione 'Base de datos de pasajeros' para ver TODOS los pasajeros registrados en el sistema.\n" +
                "- Para filtrar, eliga el campo para usar de criterio y luego ingrese un valor.";
        }

        private void btnAccionDos_Click(object sender, EventArgs e)
        {
            base.fuenteDeDatos.DataSource = SistemaCruceros.BaseDeDatosPasajeros;
            base.ActualizarListado();
        }

        private void AplicarFiltro(string valor, string propiedad)
        {
            OrdenarPorCantidadDeViajes();
            base.LimpiarFiltros();
            foreach (DataGridViewRow filaActual in base.dgvListado.Rows)
            {
                Pasajero pasajeroActual = (Pasajero)filaActual.DataBoundItem;
                switch (propiedad)
                {
                    case "DNI":
                        if (!pasajeroActual.Pasaporte.NumeroPasaporte.ToString().Contains(valor))
                        {
                            filaActual.Height = 0;
                        }
                        break;
                    case "Nombre y apellido":
                        if (!pasajeroActual.NombreCompleto.ToLower().Contains(valor))
                        {
                            filaActual.Height = 0;
                        }
                        break;
                    case "Edad":
                        if (!pasajeroActual.Edad.ToString().Contains(valor))
                        {
                            filaActual.Height = 0;
                        }
                        break;
                }
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(this.txtFiltro.Text, (string)this.cboFiltro.SelectedItem);
        }

        private void btnAccionUno_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroSeleccionado = (Pasajero)base.fuenteDeDatos.Current;
            if(pasajeroSeleccionado is null)
            {
                return;
            }
            FrmInfoPasajero formInfoPasajero = new FrmInfoPasajero(pasajeroSeleccionado);
            formInfoPasajero.ShowDialog();
        }

        private void OrdenarPorCantidadDeViajes()
        {
            bool estaDesordenado;
            Pasajero aux;
            var lista = this.listaPasajerosFiltrada;
            do
            {
                estaDesordenado = false;
                for (int i = 1; i < lista.Count; i++)
                {
                    if ((lista[i].CantidadViajesRealizados < lista[i - 1].CantidadViajesRealizados && true) || (lista[i].CantidadViajesRealizados > lista[i - 1].CantidadViajesRealizados && false))
                    {
                        aux = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = aux;
                        estaDesordenado = true;
                    }
                }
            } while (estaDesordenado);
        }
    }
}
