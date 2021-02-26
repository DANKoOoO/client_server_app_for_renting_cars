using Domen;
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
    public class IznajmljivanjeKontroler
    {
        internal void Loaduj(DataGridView dgvAutomobili, TextBox txtDatumPocetka, DataGridView dgvClanovi, ref List<Automobil> automobiliZaIznajmljivanje)
        {
            dgvAutomobili.DataSource = automobiliZaIznajmljivanje;
            for(int i = 6; i < dgvAutomobili.ColumnCount; i++)
            {
                dgvAutomobili.Columns[i].Visible = false;
            }
            txtDatumPocetka.Text = DateTime.Now.ToString("dd-MM-yyyy");
            //dgvClanovi.DataSource = Kontroler.Instance.VratiSveClanove();
            //dgvClanovi.DataSource = Komunikacija.Instance.VratiSveClanove();
            dgvClanovi.DataSource = Komunikacija.Instance.VratiClanaSaPocetnimSlovima("");
            dgvClanovi.Columns["Tip"].Visible = false;
            dgvClanovi.Columns["Lozinka"].Visible = false;
            for (int i = 0; i < 14; i++)
            {
                dgvClanovi.Columns[i].Visible = false;
            }
            for (int i = 18; i < dgvClanovi.ColumnCount; i++)
            {
                dgvClanovi.Columns[i].Visible = false;
            }
        }

        internal void IndexChanged(DataGridView dgvClanovi, TextBox txtUnosClanova)
        {
            //dgvClanovi.DataSource = Kontroler.Instance.VratiClanaSaPocetnimSlovima(txtUnosClanova.Text);
            dgvClanovi.DataSource = Komunikacija.Instance.VratiClanaSaPocetnimSlovima(txtUnosClanova.Text);
        }

        internal void Iznajmi(DataGridView dgvClanovi, TextBox txtDatumKraja, DataGridView dgvAutomobili, int idAdmina)
        {
            DateTime? datumKraja = new DateTime?();
            Clan clan = new Clan();
            List<Automobil> automobili = new List<Automobil>();
            List<int> idAutomobila = new List<int>();

            if (!UserControlHelpers.DobroUnetTextBox(txtDatumKraja))
            {
                MessageBox.Show("Morate uneti datum do koga je automobil iznajmljen!");
                return;
            }
            datumKraja = UserControlHelpers.DobraFormaDatuma(txtDatumKraja.Text);
            if (datumKraja == null)
            {
                MessageBox.Show("Morate uneti datum u ispravnom obliku!");
                return;
            }

            clan = (Clan)dgvClanovi.SelectedRows[0].DataBoundItem;
            foreach (DataGridViewRow row in dgvAutomobili.Rows)
            {
                ((Automobil)row.DataBoundItem).Stanje = Stanja.iznajmljen;
                automobili.Add((Automobil)row.DataBoundItem);
            }
            foreach (Automobil a in automobili)
            {
                idAutomobila.Add(a.ID);
            }

            try
            {
                //Kontroler.Instance.DodajIznajmljivanje(datumKraja, DateTime.Now, clan.ID, idAutomobila);
                Komunikacija.Instance.DodajIznajmljivanje(datumKraja, DateTime.Now, clan.ID, idAdmina, idAutomobila);
                MessageBox.Show($"Uspesno ste iznajmili automobile clanu: {clan.Ime} {clan.Prezime}");
                MainCoordinator.Instance.ZatvoriFormuZaIznajmljivanje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
