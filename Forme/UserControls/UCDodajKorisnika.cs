using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forme.Helpers;
using Controller;
using Forme.Communication;
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCDodajKorisnika : UserControl
    {
        private DodavanjeKorisnikaKontroler dodavanjeKorisnikaKontroler;
        public UCDodajKorisnika(DodavanjeKorisnikaKontroler dkk)
        {
            dodavanjeKorisnikaKontroler = dkk;
            InitializeComponent();
        }

        private void UCDodajKorisnika_Load(object sender, EventArgs e)
        {
            dodavanjeKorisnikaKontroler.Loaduj(cbAdminClan, cbFizickoPravno, txtID);         
        }

        private void CbAdminClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dodavanjeKorisnikaKontroler.AdminILIClan(lblFizickoPravno, lblPozicija, txtPozicija, cbFizickoPravno, cbAdminClan);
        }

        private void BtnSacuvajKorisnika_Click(object sender, EventArgs e)
        {
            dodavanjeKorisnikaKontroler.Sacuvaj(cbAdminClan, txtPozicija, txtPrezime, txtIme, txtKorisnickoIme, txtLozinka, txtID, cbFizickoPravno);          
        }
    }
}
