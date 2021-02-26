using Domen;
using SistemskeOperacije;
using SistemskeOperacije.SOAutomobil;
using SistemskeOperacije.SOIznajmljivanje;
using SistemskeOperacije.SOKlijent;
using SistemskeOperacije.SOOcena;
using Storage;
using Storage.Implementacija;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{ 
    public class Kontroler
    {

        private static Kontroler kontroler;
        private Kontroler()
        {

        }
        public static Kontroler Instance
        {
            get
            {
                if(kontroler == null)
                {
                    kontroler = new Kontroler();
                }
                return kontroler;
            }
        }

        public List<Clan> VratiSveClanove()
        {
            VratiSveClanoveSO so = new VratiSveClanoveSO();
            so.ExecuteTemplate(new Clan(), null);
            return so.Rezultat;
        }

        public Korisnik PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            Clan cl = new Clan { KorisnickoIme = korisnickoIme, Lozinka = lozinka };
            PrijaviSeSO so = new PrijaviSeSO();
            so.ExecuteTemplate(cl, null);
            return so.Rezultat;
        }

        public List<Clan> VratiClanaSaPocetnimSlovima(string pocetnaSlova)
        {
            VratiClanoveSaPocetnimSlovimaSO so = new VratiClanoveSaPocetnimSlovimaSO();
            so.ExecuteTemplate(new Clan(), pocetnaSlova);
            return so.Rezultat;
        }   

        public void IzmeniStanjeAutomobila(List<Automobil> list)
        {
            IzmeniStanjeAutomobilaSO so = new IzmeniStanjeAutomobilaSO();
            so.ExecuteTemplate(new Automobil(), list);

        }

        public void DodajIznajmljivanje(List<Iznajmljivanje> iznajmljivanja)
        {
            DodajIznajmljivanjeSO so = new DodajIznajmljivanjeSO();
            so.ExecuteTemplate(new Iznajmljivanje(), iznajmljivanja);
        }

        public void UkloniAutomobile(List<Automobil> listaZaBrisanje)
        {
            UkloniAutomobilSO so = new UkloniAutomobilSO();
             so.ExecuteTemplate(new Automobil(), listaZaBrisanje);

        }

        public void DodajOcenu(Ocena ocena)
        {
            DodajOcenuSO so = new DodajOcenuSO();
            so.ExecuteTemplate(ocena, null);
        }

        public List<Automobil> VratiAutomobileSaOdredjenimParametrima(Automobil automobil)
        {
            VratiAutomobileSaOdredjenimParametrimaSO so = new VratiAutomobileSaOdredjenimParametrimaSO();
            so.ExecuteTemplate(automobil, null);
            return so.Rezultat;
        }

        public List<Automobil> VratiSveAutomobile()
        {
            VratiSveAutomobileSO so = new VratiSveAutomobileSO();
            so.ExecuteTemplate(new Automobil(), null);
            return so.Rezultat;
        }

        public string VratiID()
        {
            VratiKlijentIDSO so = new VratiKlijentIDSO();
            so.ExecuteTemplate(new Clan(), null);
            return so.Rezultat;
        }

        public void DodajAutomobil(Automobil automobil)
        {
            DodajAutomobilSO so = new DodajAutomobilSO();
            so.ExecuteTemplate(automobil, null);
        }

        public void DodajAdmina(Admin admin)
        {
            DodajAdminaSO so = new DodajAdminaSO();
            so.ExecuteTemplate(admin, null);
        }

        public void DodajClana(Clan clan)
        {
            DodajClanaSO so = new DodajClanaSO();
            so.ExecuteTemplate(clan, null);
        }
    }
}
