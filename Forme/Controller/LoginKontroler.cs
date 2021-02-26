using Common.Exceptions;
using Domen;
using Forme.Communication;
using Forme.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class LoginKontroler
    {

        public void PrijaviSe(TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom! " + ex.Message);
                Environment.Exit(0);
            }
            if (!UserControlHelpers.DobroUnetTextBox(txtKorisnickoIme) | !UserControlHelpers.DobroUnetTextBox(txtLozinka))
            {
                MessageBox.Show("Sva polja moraju biti popunjena ispravno!");
                return;
            }
            try
            {
                //Korisnik k = Kontroler.Instance.PrijaviKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);
                Korisnik k = Komunikacija.Instance.PrijaviKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);

                MessageBox.Show($"Korisnik {k.Ime} {k.Prezime} se uspesno prijavio");
                MainCoordinator.Instance.OtvoriGlavnuFromu(k);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
