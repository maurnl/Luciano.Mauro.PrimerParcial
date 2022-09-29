using FluentValidation;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            this.Text = "Inicio de sesion";
            this.lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;


            if (!SistemaUsuarios.VerificarPassword(username, password))
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = "Credenciales invalidas! Reintente...";
                return;
            }

            Usuario user = SistemaUsuarios.BuscarPorNombreDeUsuario(username);
            FrmPrincipalContenedor app = new FrmPrincipalContenedor(user, this);
            app.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister formRegister = new FrmRegister();
            try
            {
                if (formRegister.ShowDialog() == DialogResult.OK)
                {
                    //this.sistemaUsuarios.TryCrearUsuario(formRegister.NombreCompleto, formRegister.Username, formRegister.Password);
                    this.lblError.ForeColor = Color.DarkGreen;
                    this.lblError.Text = "Registrado correctamente!";
                    SistemaUsuarios.AgregarUsuario(formRegister.UsuarioDelForm);
                }
            }
            catch (Exception nuevoUsuarioEx)
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = nuevoUsuarioEx.Message;
            }
        }

        private void btnAutologin_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "maurnl";
            this.txtPassword.Text = "contrasenia123";
        }
    }
}
