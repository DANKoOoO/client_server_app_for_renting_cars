using Controller;
using Domen;
using Forme.Communication;
using Forme.Controller;
using Forme.UserControls;
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
    public partial class FrmGlavna : Form
    {
        private Korisnik ulogovanKorisnik;
        private GlavniKontoler glavniKontroler;
        public FrmGlavna()
        {
            InitializeComponent();
        }

        public FrmGlavna(Korisnik k, GlavniKontoler gk)
        {
            glavniKontroler = gk;
            ulogovanKorisnik = k;
            InitializeComponent();

        }


        private void FrmGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Komunikacija.Instance.ZavrsiKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri odjavljivanju sa servera! " + ex.Message);
            }
            finally
            {
                MainCoordinator.Instance.ZatvoriGlavnuFormu();
            }
        }

        private void DodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glavniKontroler.OtvoriUCZaDodavanjeKorisnika(pnlGlavni);
        }

        private void DodajAutomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glavniKontroler.OtvoriUCZaDodavanjeAutomobila(pnlGlavni);
        }

        private void PretraziAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glavniKontroler.OtvoriUCZaPretraguAutomobila(pnlGlavni, ulogovanKorisnik);

        }

        private void TsmiIzmenaStanja_Click(object sender, EventArgs e)
        {
            glavniKontroler.OtvoriUCZaIzmenuStanjaAutomobila(pnlGlavni);
        }

        private void IzmeniKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glavniKontroler.SetUserControl(pnlGlavni, new UCIzmenaKorisnika());
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            glavniKontroler.Loaduj(lblGlavna, ulogovanKorisnik, tsmiDodajAutomobil, tsmiKorisnici, tsmiIzmenaStanja);
           
        }


    }
}
