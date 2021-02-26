using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using Forme.Communication;
using Forme.Helpers;
using static System.Windows.Forms.Control;

namespace Forme.Controller
{
    public class OcenaKontroler
    {
        internal void Loaduj(Label lblAutomobil, Automobil automobil)
        {
            foreach (Automobil a in Komunikacija.Instance.VratiSveAutomobile())
            {
                if (a.ID == automobil.ID)
                {
                    automobil = a;
                    break;
                }
            }
            lblAutomobil.Text = automobil.Marka + " " + automobil.Model;
        }

        internal void Oceni(RadioButton rb1, RadioButton rb2, RadioButton rb3, RadioButton rb4, RadioButton rb5, Korisnik trenutniKorisnik, Automobil automobil, TextBox txtOpis, ControlCollection controls)
        {
            List<RadioButton> radioButtons = new List<RadioButton>
            {
                rb1,
                rb2,
                rb3,
                rb4,
                rb5
            };
            if (!UserControlHelpers.DobroUnetTextBox(txtOpis))
            {
                MessageBox.Show("Dodajte opis!");
                return;
            }
            if (!radioButtons.Any(rb => rb.Checked))
            {
                MessageBox.Show("Odaberite ocenu!");
                return;
            }
            try
            {
                int ocena;
                var checkedButton = controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);
                ocena = Int32.Parse(checkedButton.Text);
                // Kontroler.Instance.DodajOcenu(Kontroler.Instance.trenutniKorisnik, automobil.ID, txtOpis.Text, ocena);
                Komunikacija.Instance.DodajOcenu(trenutniKorisnik, automobil.ID, txtOpis.Text, ocena);
                txtOpis.Text = "";
                foreach (RadioButton rb in radioButtons)
                {
                    rb.Checked = false;
                }
                MessageBox.Show("Uspesno ste ocenili auto!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vec ste ocenili ovaj auto");
                Console.WriteLine(ex);
            }
        }
    }
}
