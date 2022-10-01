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
            CargarInfo(this.pasajeroAMostrar);
        }

        private void CargarInfo(Pasajero pasajero)
        {
            string genero = "women";
            if(pasajero.Genero == Genero.Masculino)
            {
                genero = "men";
            }
            this.lblNombre.Text = pasajero.NombreCompleto;
            this.lblDni.Text = pasajero.Pasaporte.Dni.ToString();
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
