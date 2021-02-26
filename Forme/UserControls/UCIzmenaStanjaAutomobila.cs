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
    public partial class UCIzmenaStanjaAutomobila : UserControl
    {
        BindingList<Automobil> automobili1;
        BindingList<Automobil> automobili2 = new BindingList<Automobil>();
        private IzmenaStanjaAutomobilaKontroler izmenaStanjaAutomobilaKontroler;
        public UCIzmenaStanjaAutomobila(IzmenaStanjaAutomobilaKontroler isk)
        {
            izmenaStanjaAutomobilaKontroler = isk;
            InitializeComponent();
        }

        private void UCIzmenaStanjaAutomobila_Load(object sender, EventArgs e)
        {
            izmenaStanjaAutomobilaKontroler.Loaduj(dgvSviAutomobili, dgvAutomobiliZaIzmenu, ref automobili1, ref automobili2);          
        }

        private void BtnDodajZaIzmenu_Click(object sender, EventArgs e)
        {
            izmenaStanjaAutomobilaKontroler.DodajDole(ref automobili1, ref automobili2, dgvSviAutomobili);          
        }

        private void BtnVratiNazad_Click(object sender, EventArgs e)
        {
            izmenaStanjaAutomobilaKontroler.VratiGore(ref automobili1, ref automobili2, dgvAutomobiliZaIzmenu);           
        }

        private void BtnSacuvajNovaStanja_Click(object sender, EventArgs e)
        {
            izmenaStanjaAutomobilaKontroler.Sacuvaj(ref automobili2);         
        }
    }
}
