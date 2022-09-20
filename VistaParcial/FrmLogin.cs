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
        private UserManager userManager;
        public FrmLogin()
        {
            InitializeComponent();
            this.userManager = new UserManager();
            this.StartPosition = FormStartPosition.CenterScreen;
            Hardcoder.HardcodearUsuarios(this.userManager);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Inicio de sesion";
            this.lblError.Text = "";
            this.lblError.ForeColor = Color.Red;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;


            if (!userManager.CheckPassword(username, password))
            {
                lblError.Text = "Credenciales invalidas! Reintente...";
                return;
            }

            User user = userManager.FindByUsername(username);

            MessageBox.Show($"{user.FullName}");
            FrmMain app = new FrmMain(user);
            app.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister formRegister = new FrmRegister();

            if(formRegister.ShowDialog() == DialogResult.OK)
            {
                User newUser = formRegister.User;
                try
                {
                    this.userManager.TryRegisterUser(newUser.FullName, newUser.Username, newUser.Password);
                }
                catch (Exception newUserException)
                {
                    this.lblError.Text = newUserException.Message;
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
