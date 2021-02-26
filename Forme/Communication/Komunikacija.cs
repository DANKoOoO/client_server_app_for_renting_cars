using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Communication
{
    public class Komunikacija
    {
        private Socket socket;

        private static Komunikacija instance;
        private ComunicationClient klijent;
        private Komunikacija() {
            
        }

        public static Komunikacija Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Komunikacija();
                }
                return instance;
            }
        }


        public void PoveziSe()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            klijent = new ComunicationClient(socket);

        }

        public void ZavrsiKonekciju()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.PrekiniKonekciju };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }

        internal List<Korisnik> VratiSveClanove()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiSveClanove };
            klijent.PosaljiZahtev(zahtev);
            return (List<Korisnik>)klijent.PrimiOdgovor(); 
        }

        internal List<Clan> VratiClanaSaPocetnimSlovima(string text)
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiClanoveSaPocetnimSlovima, Objekat = text };
            klijent.PosaljiZahtev(zahtev);
            return (List<Clan>)klijent.PrimiOdgovor();
        }

        internal string VratiID()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiID };
            klijent.PosaljiZahtev(zahtev);
            return (string)klijent.PrimiOdgovor();
        }

        internal void DodajIznajmljivanje(DateTime? datumKraja, DateTime now, int clanID, int idAdmina,List<int> idjeviAutomobila)
        {
            List<Iznajmljivanje> iznajmljivanja = new List<Iznajmljivanje>();
            foreach (int idAutomobila in idjeviAutomobila)
            {
                Iznajmljivanje i = new Iznajmljivanje { ClanID = clanID, AdminID = idAdmina, DatumPocetka = now, DatumKraja = (DateTime)datumKraja, AutomobilID = idAutomobila };
                iznajmljivanja.Add(i);
            }
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.DodajIznajmljivanje, Objekat = iznajmljivanja };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }

        internal void DodajAutomobil(string marka, string model, string kubikaza, string registracija)
        {
            Automobil a = new Automobil { Marka = marka, Model = model, Kubikaza = Double.Parse(kubikaza), Registracija = registracija };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.DodajAutomobil, Objekat = a };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }

        internal void DodajOcenu(Korisnik trenutniKorisnik, int iD, string text, int ocena)
        {
            Ocena o = new Ocena { ClanID = trenutniKorisnik.ID, AutomobilID = iD, OcenaNumericka = ocena, Opis = text };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.DodajOcenu, Objekat = o };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }


        internal Korisnik PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.PrijaviKorisnika, KorisnickoIme = korisnickoIme, Lozinka = lozinka};
            klijent.PosaljiZahtev(zahtev);
            return (Korisnik)klijent.PrimiOdgovor();
        }

        internal void IzmeniStanjeAutomobila(List<Automobil> listaAutomobila)
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.IzmeniStanjeAutomobila, Objekat = listaAutomobila };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }

        internal void UkloniAutomobile(List<Automobil> listaZaBrisanje)
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.UkloniAutomobile, Objekat = listaZaBrisanje };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }

        internal List<Automobil> VratiSveAutomobile()
        {
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiSveAutomobile };
            klijent.PosaljiZahtev(zahtev);
            return (List<Automobil>)klijent.PrimiOdgovor();
        }

        internal List<Automobil> VratiAutomobileSaOdredjenimParametrima(string marka, string model, string kubikaza, string registracija)
        {
            double kub = Double.MaxValue;
            if (!string.IsNullOrWhiteSpace(kubikaza))
            {
                if (!Double.TryParse(kubikaza, out kub)) return null;
            }

            Automobil a = new Automobil { Marka = marka, Model = model, Kubikaza = kub, Registracija = registracija };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiAutomobileSaOdredjenimParametrima, Objekat = a };
            klijent.PosaljiZahtev(zahtev);
            return (List<Automobil>)klijent.PrimiOdgovor();
        }

        internal void DodajAdmina(string korisnickoIme, string lozinka, string ime, string prezime, string pozicija)
        {
            Admin a = new Admin { KorisnickoIme = korisnickoIme, Lozinka = lozinka, Ime = ime, Prezime = prezime, Pozicija = pozicija };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.DodajAdmina, Objekat = a};
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();

        }

        internal void DodajClana(string korisnickoIme, string lozinka, string ime, string prezime, string fizickoPravno)
        {
            Clan c = new Clan { KorisnickoIme = korisnickoIme, Lozinka = lozinka, Ime = ime, Prezime = prezime, FizickoPravno = fizickoPravno };
            Zahtev zahtev = new Zahtev() { Operacija = Operacija.DodajClana, Objekat = c };
            klijent.PosaljiZahtev(zahtev);
            klijent.PrimiOdgovor();
        }
    }
}
