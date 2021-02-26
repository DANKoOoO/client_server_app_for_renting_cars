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
    public class DodavanjeAutomobilaKontroler
    {
        internal void Sacuvaj(TextBox txtKubukaza, TextBox txtMarka, TextBox txtModel, TextBox txtRegistracija)
        {
            if (!UserControlHelpers.DobroUnetTextBox(txtMarka) | !UserControlHelpers.DobroUnetTextBox(txtModel) | !UserControlHelpers.DobroUnetTextBox(txtKubukaza) | !UserControlHelpers.DobroUnetTextBox(txtRegistracija) | !UserControlHelpers.DobarFormatKubikaze(txtKubukaza))
            {
                MessageBox.Show("Svi podaci moraju biti uneti ispravno!");
                return;
            }
            try
            {
                UserControlHelpers.DobroUnetaRegistracija(txtRegistracija);
                try
                {
                    //Kontroler.Instance.DodajAutomobil(txtMarka.Text, txtModel.Text, txtKubukaza.Text, txtRegistracija.Text);
                    Komunikacija.Instance.DodajAutomobil(txtMarka.Text, txtModel.Text, txtKubukaza.Text, (txtRegistracija.Text).ToUpper());
                    MessageBox.Show("Uspesno je dodat automobil u sistem!");
                    List<TextBox> listaTextBoxova = new List<TextBox>
                    {
                        txtMarka,
                        txtModel,
                        txtKubukaza,
                        txtRegistracija
                    };
                    UserControlHelpers.OcistiTextBoxove(listaTextBoxova);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
