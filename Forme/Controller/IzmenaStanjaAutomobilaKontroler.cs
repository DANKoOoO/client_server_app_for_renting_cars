using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using Forme.Communication;

namespace Forme.Controller
{
    public class IzmenaStanjaAutomobilaKontroler
    {
        internal void Loaduj(DataGridView dgvSviAutomobili, DataGridView dgvAutomobiliZaIzmenu, ref BindingList<Automobil> automobili1, ref BindingList<Automobil> automobili2)
        {
            automobili1 = new BindingList<Automobil>(Komunikacija.Instance.VratiSveAutomobile());

            dgvSviAutomobili.DataSource = automobili1;
            for (int i = 6; i < dgvSviAutomobili.ColumnCount; i++)
            {
                dgvSviAutomobili.Columns[i].Visible = false;
            }
            dgvSviAutomobili.Columns["Stanje"].DisplayIndex = 5;

            dgvAutomobiliZaIzmenu.DataSource = automobili2;

            DataGridViewComboBoxColumn kolonaStanja = new DataGridViewComboBoxColumn();
            for (int i = 6; i < dgvAutomobiliZaIzmenu.ColumnCount; i++)
            {
                dgvAutomobiliZaIzmenu.Columns[i].Visible = false;
            }

            kolonaStanja.DataPropertyName = "Stanje";
            kolonaStanja.DataSource = Enum.GetValues(typeof(Stanja));
            kolonaStanja.HeaderText = "Novo stanje";
            dgvAutomobiliZaIzmenu.Columns.Add(kolonaStanja);


        }

        internal void DodajDole(ref BindingList<Automobil> automobili1, ref BindingList<Automobil> automobili2, DataGridView dgvSviAutomobili)
        {
            foreach (DataGridViewRow row in dgvSviAutomobili.SelectedRows)
            {
                automobili2.Add((Automobil)row.DataBoundItem);
                automobili1.Remove((Automobil)row.DataBoundItem);
            }
        }

        internal void VratiGore(ref BindingList<Automobil> automobili1, ref BindingList<Automobil> automobili2, DataGridView dgvAutomobiliZaIzmenu)
        {
            foreach (DataGridViewRow row in dgvAutomobiliZaIzmenu.SelectedRows)
            {
                automobili1.Add((Automobil)row.DataBoundItem);
                automobili2.Remove((Automobil)row.DataBoundItem);
            }
        }

        internal void Sacuvaj(ref BindingList<Automobil> automobili2)
        {
            try
            {
                //Kontroler.Instance.IzmeniStanjeAutomobila(new List<Automobil>(automobili2));
                foreach(Automobil a in automobili2)
                {
                    if(a.Stanje == Stanja.iznajmljen)
                    {
                        MessageBox.Show("Ne mogu se iznajmiti automobili na oboj formi.\nOtvorite formu za iznajmljivanje");
                        return;
                    }
                }
                Komunikacija.Instance.IzmeniStanjeAutomobila(new List<Automobil>(automobili2));
                MessageBox.Show("Uspesno ste izmenili stanja automobila");
                automobili2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
