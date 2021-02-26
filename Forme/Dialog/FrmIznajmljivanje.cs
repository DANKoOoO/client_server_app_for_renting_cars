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
    public partial class FrmIznajmljivanje : Form
    {
        private int idAdmina;
        private List<Automobil> automobiliZaIznajmljivanje = new List<Automobil>();
        private IznajmljivanjeKontroler iznajmljivanjeKontroler;
        
        public FrmIznajmljivanje()
        {
            InitializeComponent();
        }

        public FrmIznajmljivanje(List<Automobil> automobili, Korisnik trenutniKorisnik)
        {
            iznajmljivanjeKontroler = new IznajmljivanjeKontroler();
            automobiliZaIznajmljivanje = automobili;
            idAdmina = trenutniKorisnik.ID;
            InitializeComponent();
        }

        private void FrmIznajmljivanje_Load(object sender, EventArgs e)
        {
            iznajmljivanjeKontroler.Loaduj(dgvAutomobili, txtDatumPocetka, dgvClanovi, ref automobiliZaIznajmljivanje);
           
        }

        private void TxtUnosClanova_TextChanged(object sender, EventArgs e)
        {
            iznajmljivanjeKontroler.IndexChanged(dgvClanovi, txtUnosClanova);          
        }

        private void BtnIznajmi_Click(object sender, EventArgs e)
        {
            iznajmljivanjeKontroler.Iznajmi(dgvClanovi, txtDatumKraja, dgvAutomobili, idAdmina);
            
        }
    }
}
