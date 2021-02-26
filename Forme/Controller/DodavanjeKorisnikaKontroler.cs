using Forme.Communication;
using Forme.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class DodavanjeKorisnikaKontroler
    {
        internal void Loaduj(ComboBox cbAdminClan, ComboBox cbFizickoPravno, TextBox txtID)
        {
            List<string> adminClan = new List<string>();
            adminClan.Add("admin");
            adminClan.Add("clan");
            cbAdminClan.DataSource = adminClan;
            List<string> fizickoPravno = new List<string>();
            fizickoPravno.Add("fizicko");
            fizickoPravno.Add("pravno");
            cbFizickoPravno.DataSource = fizickoPravno;

            // txtID.Text = Kontroler.Instance.VratiID();
            txtID.Text = Komunikacija.Instance.VratiID();
        }

        internal void AdminILIClan(Label lblFizickoPravno, Label lblPozicija, TextBox txtPozicija, ComboBox cbFizickoPravno, ComboBox cbAdminClan)
        {
            if ((string)cbAdminClan.SelectedValue == "admin")
            {
                lblPozicija.Visible = true;
                txtPozicija.Visible = true;

                lblFizickoPravno.Visible = false;
                cbFizickoPravno.Visible = false;
            }
            else
            {
                lblPozicija.Visible = false;
                txtPozicija.Visible = false;

                lblFizickoPravno.Visible = true;
                cbFizickoPravno.Visible = true;
            }
        }

        internal void Sacuvaj(ComboBox cbAdminClan, TextBox txtPozicija, TextBox txtPrezime, TextBox txtIme, TextBox txtKorisnickoIme, TextBox txtLozinka, TextBox txtID, ComboBox cbFizickoPravno)
        {
            List<TextBox> listaTextBoxova = new List<TextBox>
                    {
                        txtKorisnickoIme,
                        txtLozinka,
                        txtIme,
                        txtPrezime,
                        txtPozicija
                    };
            if (cbAdminClan.Text == "admin")
            {
                if (!UserControlHelpers.DobroUnetTextBox(txtKorisnickoIme) | !UserControlHelpers.DobroUnetTextBox(txtLozinka) | !UserControlHelpers.DobroUnetTextBox(txtIme) | !UserControlHelpers.DobroUnetTextBox(txtPrezime) | !UserControlHelpers.DobroUnetTextBox(txtPozicija))
                {
                    MessageBox.Show("Sva polja moraju biti popunjena ispravno!");
                    return;
                }
                try
                {
                    //Kontroler.Instance.DodajAdmina(txtKorisnickoIme.Text, txtLozinka.Text, txtIme.Text, txtPrezime.Text, txtPozicija.Text);
                    Komunikacija.Instance.DodajAdmina(txtKorisnickoIme.Text, txtLozinka.Text, txtIme.Text, txtPrezime.Text, txtPozicija.Text);

                    MessageBox.Show("Uspesno je dodat korisnik u sistem!");

                    txtID.Text = "" + (Int32.Parse(txtID.Text) + 1);
                    UserControlHelpers.OcistiTextBoxove(listaTextBoxova);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (!UserControlHelpers.DobroUnetTextBox(txtKorisnickoIme) | !UserControlHelpers.DobroUnetTextBox(txtLozinka) | !UserControlHelpers.DobroUnetTextBox(txtIme) | !UserControlHelpers.DobroUnetTextBox(txtPrezime))
                {
                    MessageBox.Show("Sva polja moraju biti popunjena ispravno!");
                    return;
                }
                try
                {
                    //  Kontroler.Instance.DodajClana(txtKorisnickoIme.Text, txtLozinka.Text, txtIme.Text, txtPrezime.Text, cbFizickoPravno.Text);
                    Komunikacija.Instance.DodajClana(txtKorisnickoIme.Text, txtLozinka.Text, txtIme.Text, txtPrezime.Text, cbFizickoPravno.Text);

                    MessageBox.Show("Uspesno je dodat korisnik u sistem!");

                    txtID.Text = "" + (Int32.Parse(txtID.Text) + 1);
                    UserControlHelpers.OcistiTextBoxove(listaTextBoxova);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
