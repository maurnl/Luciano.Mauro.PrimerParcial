using Parcial.Entities;
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
    public partial class FrmMain : Form
    {
        private Usuario user;
        private Sistema sistema;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Usuario user) : this()
        {
            this.user = user;
            this.sistema = new Sistema();
            this.Text = $"Operador conectado ID {this.user.Id}: {this.user.NombreCompleto}";
        }
    }
}
