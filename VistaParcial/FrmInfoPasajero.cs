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
    public partial class FrmInfoPasajero : Form
    {
        private Pasajero pasajeroAMostrar;
        public FrmInfoPasajero()
        {
            InitializeComponent();
        }

        public FrmInfoPasajero(Pasajero pasajeroAMostrar) : this()
        {
            this.pasajeroAMostrar = pasajeroAMostrar;
        }

        private void FrmInfoPasajero_Load(object sender, EventArgs e)
        {
            this.button1.Text = "Volver";
            this.BackColor = Color.LightBlue;
            CargarInfo(this.pasajeroAMostrar);
        }

        private void CargarInfo(Pasajero pasajero)
        {
            string genero = "women";
            if(pasajero.Genero == Genero.Masculino)
            {
                genero = "men";
            }
            this.lblNombre.Text = "Nombre: " + pasajero.NombreCompleto;
            this.lblDni.Text = "Nro Pasaporte: " + pasajero.Pasaporte.NumeroPasaporte.ToString();
            this.lblCantidadViajes.Text = "Cantidad de valijas: " + pasajero.CantidadViajesRealizados.ToString();
            this.lblEdad.Text = "Edad: " + pasajero.Edad.ToString();
            this.lblGenero.Text = "Genero: " + pasajero.Genero.ToString();
            CargarEquipaje(pasajero);
            this.ptbFoto.Load(GenerarImagenRandom(genero));
        }

        private string GenerarImagenRandom(string sexo)
        {
            Random random = new Random();
            return $"https://randomuser.me/api/portraits/{sexo}/{random.Next(1,100)}.jpg";
        }

        private void CargarEquipaje(Pasajero pasajero)
        {
            lstEquipajes.Items.Clear();
            for (int i = 0; i < pasajero.CantidadEquipaje; i++)
            {
                lstEquipajes.Items.Add(pasajero[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
