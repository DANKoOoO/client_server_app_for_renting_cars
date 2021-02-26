using Domen;
using Forme.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class MainCoordinator
    {
        private FrmLogIn frmLogIn;
        private FrmGlavna frmGlavna;
        private FrmUklanjanje frmUklanjanje;
        private FrmIznajmljivanje frmIznajmljivanje;

        private GlavniKontoler glavniKontroler = new GlavniKontoler();
        private LoginKontroler loginKontroler = new LoginKontroler();
        
        // singleton
        private static MainCoordinator instance;
        private MainCoordinator() { }
        public static MainCoordinator Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public void OtvoriLogInFormu()
        {
            frmLogIn = new FrmLogIn(loginKontroler);
            frmLogIn.ShowDialog();
        }

        public void OtvoriGlavnuFromu(Korisnik k)
        {
            frmLogIn.Dispose();
            frmLogIn = null;

            frmGlavna = new FrmGlavna(k, glavniKontroler);
            frmGlavna.ShowDialog();
        }

        internal void ZatvoriGlavnuFormu()
        {
            frmGlavna.Dispose();
            frmGlavna = null;

            //frmLogIn = new FrmLogIn(loginKontroler);
            //frmLogIn.ShowDialog();
        }
        internal void ZatvoriFormuUklanjanje()
        {
            frmUklanjanje.Dispose();
            frmUklanjanje = null;
        }


        internal void OtvoriFormuUklanjanje(List<Automobil> automobili)
        {
            frmUklanjanje = new FrmUklanjanje(automobili, new UklanjanjeKontroler());
            frmUklanjanje.ShowDialog();
        }

        internal void OtvoriFormuIznajmljivanja(List<Automobil> automobili, Korisnik trenutniKorisnik)
        {
            frmIznajmljivanje = new FrmIznajmljivanje(automobili,trenutniKorisnik);
            frmIznajmljivanje.ShowDialog();
        }

        internal void ZatvoriFormuZaIznajmljivanje()
        {
            frmIznajmljivanje.Dispose();
            frmIznajmljivanje = null;
        }
    }
}
