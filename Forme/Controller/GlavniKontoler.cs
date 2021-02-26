using Domen;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class GlavniKontoler
    {
        private PretragaAutomobilaKontroler pretragaAutomobilaKontroler = new PretragaAutomobilaKontroler();
        private DodavanjeAutomobilaKontroler dodavanjeAutomobilaKontroler = new DodavanjeAutomobilaKontroler();
        private IzmenaStanjaAutomobilaKontroler izmenaStanjaAutomobilaKontroler = new IzmenaStanjaAutomobilaKontroler();
        private DodavanjeKorisnikaKontroler dodavanjeKorisnikaKontroler = new DodavanjeKorisnikaKontroler();

        internal void Loaduj(Label lblGlavna, Korisnik ulogovanKorisnik, ToolStripMenuItem tsmiDodajAutomobil, ToolStripMenuItem tsmiKorisnici, ToolStripMenuItem tsmiIzmenaStanja)
        {
            // lblGlavna.Text = $"Dobrodosli {Kontroler.Instance.trenutniKorisnik.Ime} {Kontroler.Instance.trenutniKorisnik.Prezime} !";
            lblGlavna.Text = $"Dobrodosli {ulogovanKorisnik.Ime} {ulogovanKorisnik.Prezime}!";

            if (ulogovanKorisnik.Tip)
            {
                tsmiKorisnici.Visible = true;
                tsmiDodajAutomobil.Visible = true;
                tsmiIzmenaStanja.Visible = true;
            }
            else
            {
                tsmiKorisnici.Visible = false;
                tsmiDodajAutomobil.Visible = false;
                tsmiIzmenaStanja.Visible = false;
            }

        }

        internal void OtvoriUCZaPretraguAutomobila(Panel pnlGlavni, Korisnik ulogovanKorisnik)
        {
            SetUserControl(pnlGlavni, new UCPretraziAutomobile(ulogovanKorisnik, pretragaAutomobilaKontroler));
        }
        internal void OtvoriUCZaDodavanjeKorisnika(Panel pnlGlavni)
        {
            SetUserControl(pnlGlavni, new UCDodajKorisnika(dodavanjeKorisnikaKontroler));
        }
        internal void OtvoriUCZaDodavanjeAutomobila(Panel pnlGlavni)
        {
            SetUserControl(pnlGlavni, new UCDodajAutomobil(dodavanjeAutomobilaKontroler));
        }
         internal void OtvoriUCZaIzmenuStanjaAutomobila(Panel pnlGlavni)
        {
            SetUserControl(pnlGlavni, new UCIzmenaStanjaAutomobila(izmenaStanjaAutomobilaKontroler));
        }


        internal void SetUserControl(Panel pnlGlavni, UserControl uc)
        {
            pnlGlavni.Controls.Clear();
            uc.Parent = pnlGlavni;
            uc.Dock = DockStyle.Fill;
        }
    }
}
