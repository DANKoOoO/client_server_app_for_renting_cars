using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije.SOKlijent
{
    public class DodajAdminaSO : SystemOperationBase
    {
        protected override void Izvrsi(IEntity entity, object parametri)
        {
            foreach (Korisnik k in repository.VratiSve(entity).Cast<Korisnik>().ToList())
            {
                if (k.KorisnickoIme == ((Admin)entity).KorisnickoIme)
                {
                    throw new Exception("Vec postoji korisnika sa tim korisnickim imenom u sistemu!");

                }
            }
            //admin.ID = repository.VratiID(admin);
            //repository.Dodaj(admin as Korisnik);



            Admin ad = (Admin)entity;
            ad.ID = repository.VratiID(entity);
            ad.Ocena = 0;
            ad.NaPoslu = false;
            ad.Tip = true;
            ad.BrojIznajmljivanja = 0;
            //storageKorisnik.DodajAdmina(admin);

            repository.DodajSaNasledjivanjem(ad);
        }
    }
}
