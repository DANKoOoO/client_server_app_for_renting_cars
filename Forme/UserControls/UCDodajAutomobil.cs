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
    public partial class UCDodajAutomobil : UserControl
    {
        private DodavanjeAutomobilaKontroler dodavanjeAutomobilaKontroler;
        public UCDodajAutomobil(DodavanjeAutomobilaKontroler dak)
        {
            dodavanjeAutomobilaKontroler = dak;
            InitializeComponent();
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            dodavanjeAutomobilaKontroler.Sacuvaj(txtKubukaza, txtMarka, txtModel, txtRegistracija);
            
        }
    }
}
