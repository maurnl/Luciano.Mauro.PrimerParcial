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
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Usuario user) : this()
        {
            this.user = user;
        }
    }
}
