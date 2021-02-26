using Controller;
using Domen;
using Forme.Communication;
using Forme.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmUklanjanje : Form
    {
        private BindingList<Automobil> automobili = new BindingList<Automobil>();
        private UklanjanjeKontroler uklanjanjeKontroler = new UklanjanjeKontroler();
        public FrmUklanjanje()
        {
            InitializeComponent();
        }

        public FrmUklanjanje(List<Automobil> a, UklanjanjeKontroler uk)
        {
            uklanjanjeKontroler = uk;
            InitializeComponent();
            automobili = new BindingList<Automobil>(a);
        }

        private void FrmUklanjanje_Load(object sender, EventArgs e)
        {
            uklanjanjeKontroler.Loaduj(dgvAutomobiliZaUklanjanje, ref automobili);
        }

        private void BtnIzbaci_Click(object sender, EventArgs e)
        {
            uklanjanjeKontroler.Izbaci(dgvAutomobiliZaUklanjanje, ref automobili);         
        }

        private void BtnUkloni_Click(object sender, EventArgs e)
        {
            uklanjanjeKontroler.Ukloni(ref automobili);           
        }
    }
}
