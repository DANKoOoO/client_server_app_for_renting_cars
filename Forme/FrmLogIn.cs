using Controller;
using Domen;
using Forme.Communication;
using Forme.Controller;
using Forme.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmLogIn : Form
    {
        private LoginKontroler loginKontroler;
        public FrmLogIn(LoginKontroler lk)
        {
            loginKontroler = lk;
            InitializeComponent();
            txtKorisnickoIme.Text = "admin";
            txtLozinka.Text = "admin";
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            loginKontroler.PrijaviSe(txtKorisnickoIme, txtLozinka);
        }

        private void FrmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
