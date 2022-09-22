using Parcial.Util;
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
    public partial class FrmRegister : Form
    {
        private string nombreCompleto;
        private string username;
        private string password;

        public string NombreCompleto
        {
            get
            {
                return this.nombreCompleto;
            }
        }
        public string Username
        {
            get
            {
                return this.username;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public FrmRegister()
        {
            InitializeComponent();
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.lblError.ForeColor = Color.Red;
            this.lblError.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            string nombreCompleto = this.txtName.Text + " " + this.txtLastName.Text;

            try
            {
                Validador.ValidarStringAlfabetica(nombreCompleto);
                Validador.ValidarStringVacia(username);
                Validador.ValidarStringVacia(password);

                this.username = username;
                this.password = password;
                this.nombreCompleto = nombreCompleto;

                this.DialogResult = DialogResult.OK;
            } catch (Exception datosRegistroEx)
            {
                this.lblError.Text = datosRegistroEx.Message;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
