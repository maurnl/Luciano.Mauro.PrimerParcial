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
        private User user;

        public User User
        {
            get
            {
                return this.user;
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
            string fullName = this.txtName.Text + " " + this.txtLastName.Text;

            try
            {
                Validator.ValidStringValidation(password);
                Validator.ValidStringValidation(username);
                Validator.AlphabeticStringValidation(fullName);

                this.user = new User(fullName, username, password);
                this.DialogResult = DialogResult.OK;
            }catch(Exception registerException)
            {
                this.lblError.Text = registerException.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
