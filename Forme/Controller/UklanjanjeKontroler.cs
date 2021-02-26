using Domen;
using Forme.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class UklanjanjeKontroler
    {
        internal void Izbaci(DataGridView dgvAutomobiliZaUklanjanje, ref BindingList<Automobil> automobili)
        {
            foreach (DataGridViewRow row in dgvAutomobiliZaUklanjanje.SelectedRows)
            {
                try
                {
                    automobili.Remove((Automobil)row.DataBoundItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal void Ukloni(ref BindingList<Automobil> automobili)
        {
            try
            {
                List<Automobil> listaZaBrisanje = automobili.ToList();
                //Kontroler.Instance.UkloniAutomobile(listaZaBrisanje);
                Komunikacija.Instance.UkloniAutomobile(listaZaBrisanje);
                MessageBox.Show("Uspesno su uklonjeni automobili iz sistema!");
                MainCoordinator.Instance.ZatvoriFormuUklanjanje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void Loaduj(DataGridView dgvAutomobiliZaUklanjanje, ref BindingList<Automobil> automobili)
        {
            dgvAutomobiliZaUklanjanje.DataSource = automobili;
            for (int i = 6; i < dgvAutomobiliZaUklanjanje.ColumnCount; i++)
            {
                dgvAutomobiliZaUklanjanje.Columns[i].Visible = false; ;
            }
        }
    }
}
