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
        private SistemaUsuarios sistemaUsuarios;
        public FrmLogin()
        {
            InitializeComponent();
            this.sistemaUsuarios = new SistemaUsuarios();
            this.StartPosition = FormStartPosition.CenterScreen;
            Hardcoder.HardcodearUsuarios(this.sistemaUsuarios);
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


            if (!sistemaUsuarios.VerificarPassword(username, password))
            {
                this.lblError.ForeColor = Color.Red;
                this.lblError.Text = "Credenciales invalidas! Reintente...";
                return;
            }

            Usuario user = sistemaUsuarios.BuscarPorNombreDeUsuario(username);

            MessageBox.Show($"{user.NombreCompleto}");
            FrmMain app = new FrmMain(user, this);
            app.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister formRegister = new FrmRegister();
            if(formRegister.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.sistemaUsuarios.TryCrearUsuario(formRegister.NombreCompleto, formRegister.Username, formRegister.Password);
                    this.lblError.ForeColor = Color.DarkGreen;
                    this.lblError.Text = "Registrado correctamente!";
                }
                catch (Exception nuevoUsuarioEx)
                {
                    this.lblError.ForeColor = Color.Red;
                    this.lblError.Text = nuevoUsuarioEx.Message;
                }
            }
        }

        private void btnAutologin_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "maurnl";
            this.txtPassword.Text = "contrasenia123";
        }
    }
}
