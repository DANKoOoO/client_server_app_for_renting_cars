using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Domen;
using Forme.Communication;
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCPretraziAutomobile : UserControl
    {
        private Korisnik trenutniKorisnik;
        PretragaAutomobilaKontroler pretragaAutomobilaKontroler;
        public UCPretraziAutomobile(Korisnik ulogovaniKorisnik, PretragaAutomobilaKontroler pak)
        {
            pretragaAutomobilaKontroler = pak;
            trenutniKorisnik = ulogovaniKorisnik;
            InitializeComponent();
        }

        private void BtnOceni_Click(object sender, EventArgs e)
        {
            pretragaAutomobilaKontroler.Oceni(dgvAutomobili, trenutniKorisnik);
           
        }

        internal void UCPretraziAutomobile_Load(object sender, EventArgs e)
        {
            pretragaAutomobilaKontroler.Loaduj(dgvAutomobili, cbMarka, cbModel, btnOceni, trenutniKorisnik, btnUkloni, btnIznajmi, txtRegistracija, lblRegistracija);
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            pretragaAutomobilaKontroler.Pretrazi(this, cbMarka,cbModel,txtKubikaza,txtRegistracija,dgvAutomobili);     
        }

        private void BtnUkloni_Click(object sender, EventArgs e)
        {
            pretragaAutomobilaKontroler.Ukloni(this ,dgvAutomobili);
        }

        private void BtnIznajmi_Click(object sender, EventArgs e)
        {
            pretragaAutomobilaKontroler.Iznajmi(this, dgvAutomobili, trenutniKorisnik);         
        }
    }
}
