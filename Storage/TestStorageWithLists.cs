using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storage
{
    public static class TestStorageWithLists
    {
        private static List<Korisnik> korisnici;
        
        public static List<Korisnik> GetKorisniks()
        {
            korisnici = new List<Korisnik>();
            korisnici.Add(new Admin
            {
                KorisnickoIme = "admin",
                Lozinka = "admin",
                ID = 1,
                Ime = "Admin",
                Prezime = "Adminovic",
                BrojIznajmljivanja = 0,
                NaPoslu = true,
                Ocena = 0.0,
                Pozicija = "Direktor",
                Tip = true
            });
            korisnici.Add(new Clan
            {
                KorisnickoIme = "clan",
                Lozinka = "clan",
                ID = 2,
                Ime = "Clan",
                Prezime = "Clanovic",
                FizickoPravno = "fizicko",
                Status = "zlatni",
                Tip = false
            });
            return korisnici;
        }


    }
}
