using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using Forme.Communication;
using Forme.UserControls;

namespace Forme.Controller
{
    public class PretragaAutomobilaKontroler
    {
        internal void Oceni(DataGridView dgvAutomobili, Korisnik trenutniKorisnik)
        {
            Automobil automobil = (Automobil)dgvAutomobili.SelectedRows[0].DataBoundItem;
            FrmOcena frmOcena = new FrmOcena(automobil, trenutniKorisnik, new OcenaKontroler());
            frmOcena.ShowDialog();
        }

        internal void Loaduj(DataGridView dgvAutomobili, ComboBox cbMarka, ComboBox cbModel, Button btnOceni, Korisnik trenutniKorisnik, Button btnUkloni, Button btnIznajmi, TextBox txtRegistracija, Label lblRegistracija)
        {
            // List<Automobil> automobili = Kontroler.Instance.VratiSveAutomobile();
            List<Automobil> automobili = Komunikacija.Instance.VratiSveAutomobile();
            List<string> marke = new List<string>();
            List<string> modeli = new List<string>();

            marke.Add("nebitno");
            modeli.Add("nebitno");

            foreach (Automobil a in automobili)
            {
                if (!marke.Contains(a.Marka))
                {
                    marke.Add(a.Marka);
                }
                if (!modeli.Contains(a.Model))
                {
                    modeli.Add(a.Model);
                }
            }

            dgvAutomobili.DataSource = automobili;
            cbMarka.DataSource = marke;
            cbModel.DataSource = modeli;
            for(int i = 6; i<dgvAutomobili.ColumnCount; i++)
            {
                dgvAutomobili.Columns[i].Visible = false; ;
            }

            if (trenutniKorisnik.Tip)
            {
                dgvAutomobili.Columns["id"].Visible = false;
                btnOceni.Visible = false;
            }
            else
            {
                btnUkloni.Visible = false;
                btnIznajmi.Visible = false;
                txtRegistracija.Visible = false;
                lblRegistracija.Visible = false;
            }
            dgvAutomobili.Columns["Stanje"].DisplayIndex = 5;
        }

        internal void Iznajmi(UCPretraziAutomobile uc, DataGridView dgvAutomobili, Korisnik trenutniKorisnik)
        {
            List<Automobil> automobili = new List<Automobil>();
            foreach (DataGridViewRow row in dgvAutomobili.SelectedRows)
            {
                if(((Automobil)row.DataBoundItem).Stanje != Stanja.uGarazi)
                {
                    MessageBox.Show("Neki od automobila nije dostupan za iznajmljivanje!");
                    return;
                }
                automobili.Add((Automobil)row.DataBoundItem);
            }
            MainCoordinator.Instance.OtvoriFormuIznajmljivanja(automobili, trenutniKorisnik);
            //FrmIznajmljivanje frmIznajmljivanje = new FrmIznajmljivanje(automobili, trenutniKorisnik, new IznajmljivanjeKontroler());
            //frmIznajmljivanje.ShowDialog();
            uc.UCPretraziAutomobile_Load(uc, null);
        }

        internal void Ukloni(UCPretraziAutomobile uc, DataGridView dgvAutomobili)
        {
            List<Automobil> automobili = new List<Automobil>();
            foreach (DataGridViewRow row in dgvAutomobili.SelectedRows)
            {
                automobili.Add((Automobil)row.DataBoundItem);
            }

            //FrmUklanjanje frmUklanjanje = new FrmUklanjanje(automobili);
            MainCoordinator.Instance.OtvoriFormuUklanjanje(automobili);
            uc.UCPretraziAutomobile_Load(uc, null);
        }

        internal void Pretrazi(UCPretraziAutomobile uc, ComboBox cbMarka, ComboBox cbModel, TextBox txtKubikaza, TextBox txtRegistracija, DataGridView dgvAutomobili)
        {
            //List<Automobil> dobijeniAutomobili = Kontroler.Instance.VratiAutomobileSaOdredjenimParametrima(cbMarka.Text, cbModel.Text, txtKubikaza.Text, txtRegistracija.Text);
            try
            {
                List<Automobil> dobijeniAutomobili = Komunikacija.Instance.VratiAutomobileSaOdredjenimParametrima(cbMarka.Text, cbModel.Text, txtKubikaza.Text, (txtRegistracija.Text).ToUpper());
                if (dobijeniAutomobili == null)
                {
                    MessageBox.Show("Ne postoji automobil sa tom registracijom\nPokusajte ponovo");
                    uc.UCPretraziAutomobile_Load(uc, null);
                }
                else
                {
                    dgvAutomobili.DataSource = dobijeniAutomobili;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
