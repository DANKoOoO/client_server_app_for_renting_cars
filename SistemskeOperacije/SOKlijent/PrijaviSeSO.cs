using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOKlijent
{
    public class PrijaviSeSO : SystemOperationBase
    {
        public Korisnik Rezultat;
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            
            Clan cl = (Clan)entity;
            foreach (Korisnik k in repository.VratiSve(cl).Cast<Korisnik>().ToList())
            {
                if (k.KorisnickoIme == ((Clan)entity).KorisnickoIme && k.Lozinka == ((Clan)entity).Lozinka)
                {
                    // trenutniKorisnik = k;
                    // return k;
                    Rezultat = k;
                }
            }
        }
    }
}
