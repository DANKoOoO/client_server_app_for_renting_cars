using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageKorisnik
    {
        List<Korisnik> SviKorisnici();

        void DodajAdmina(Korisnik k);

        void DodajClana(Korisnik k);
        string KorisnikID();
        List<Korisnik> VratiSveClanove();
        List<Korisnik> VratiClanoveSaPocetnimSlovima(string pocetnaSlova);
    }
}
