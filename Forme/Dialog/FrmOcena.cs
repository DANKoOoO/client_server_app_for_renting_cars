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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmOcena : Form
    {
        private Automobil automobil = new Automobil();
        private Korisnik trenutniKorisnik;
        private OcenaKontroler ocenaKontroler;

        public FrmOcena()
        {
            InitializeComponent();
        }

        public FrmOcena(Automobil a, Korisnik k, OcenaKontroler ok)
        {
            ocenaKontroler = ok;
            InitializeComponent();
            automobil = a;
            trenutniKorisnik = k;
        }

        private void FrmOcena_Load(object sender, EventArgs e)
        {
            ocenaKontroler.Loaduj(lblAutomobil, automobil);         
        }

        private void TxtOceni_Click(object sender, EventArgs e)
        {
            ocenaKontroler.Oceni(rb1, rb2, rb3, rb4, rb5, trenutniKorisnik, automobil, txtOpis, Controls);
        }
    }
}
