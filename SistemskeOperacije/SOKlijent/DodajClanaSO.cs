using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOKlijent
{
    public class DodajClanaSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            foreach (Korisnik k in repository.VratiSve(entity).Cast<Korisnik>().ToList())
            {
                if (k.KorisnickoIme == ((Clan)entity).KorisnickoIme)
                {
                    throw new Exception("Vec postoji korisnika sa tim korisnickim imenom u sistemu!");

                }
            }

            //clan.ID = repository.VratiID(clan);            
            //repository.Dodaj(clan);

            Clan cl = (Clan)entity;

            cl.ID = repository.VratiID(entity);
            cl.Status = "nov";
            cl.Tip = false;

            //storageKorisnik.DodajClana(clan);
            repository.DodajSaNasledjivanjem(cl);
        }
    }
}
