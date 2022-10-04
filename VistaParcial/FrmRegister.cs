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
using FluentValidation;

namespace VistaParcial
{
    public partial class FrmRegister : Form
    {
        private Usuario usuarioDelForm;

        public Usuario UsuarioDelForm
        {
            get
            {
                return this.usuarioDelForm;
            }
        }
        public FrmRegister()
        {
            InitializeComponent();
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.Text = "Registrarse";
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
                this.usuarioDelForm = new Usuario(nombreCompleto, username, password);
                ValidadorUsuario validador = new ValidadorUsuario();
                validador.ValidateAndThrow(usuarioDelForm);
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
