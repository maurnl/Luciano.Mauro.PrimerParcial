﻿using Parcial.Entities;
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
            this.btnAccionDos.Text = "Base de datos de pasajeros";
            this.btnAccionUno.Text = "Ver informacion detallada...";
            this.Text = "Listado de pasajeros";
            this.lblCombobox.Text = "Mostrando viaje...";
            this.cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCombobox.DataSource = SistemaCruceros.viajes;
            if(SistemaCruceros.viajes.Count != 0)
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

        private void btnAccionDos_Click(object sender, EventArgs e)
        {
            base.fuenteDeDatos.DataSource = SistemaCruceros.BaseDeDatosPasajeros;
            base.ActualizarListado();
        }
    }
}
